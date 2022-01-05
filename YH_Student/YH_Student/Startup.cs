using Autofac;
using Autofac.Extras.DynamicProxy;
using IServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Repository.sugar;
using Service;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using Autho.JWT;

namespace YH_Student
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            #region ע��Swagger
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc("v1", new OpenApiInfo { Title = "API�ӿ��ĵ�", Version = "v1", Description = "���� .NET Core 3.1 ��Api" });
                // ��ȡxml�ļ�·��
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
                o.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                var xmlPath = Path.Combine(basePath, "YH_Student.xml");
                // ����xml�ļ���ΪSwagger JSON and UI ����xml�ĵ�ע��·����
                o.IncludeXmlComments(xmlPath, true);
            });
            #endregion
            #region ���ݿ�����
            BaseDBConfig.ConnectionString = Configuration.GetSection("AppSettings:SqlServerConnection").Value;
            #endregion
            #region ������Ȩ��
            #region 1�����ڽ�ɫ��API��Ȩ 

            // 1����Ȩ��������ܼ򵥣�����ʲô����������
            // �������÷���ֻ��Ҫ��API���controller�ϱߣ��������Լ��ɣ�ע�⣬ֻ���ǽ�ɫ��:
            // [Authorize(Roles = "Admin")]

            // 2����֤����Ȼ�����±ߵ�configure������м������:app.UseMiddleware<JwtTokenAuth>();��������������޷���֤����ʱ�䣬���������Ҫ��֤����ʱ�䣬������Ҫ�±ߵĵ����ַ������ٷ���֤

            #endregion

            #region 2�����ڲ��Ե���Ȩ���򵥰棩

            // 1����Ȩ����������ϱߵ�����ͬ�����ô����ǲ�����controller�У�д��� roles ��
            // Ȼ����ôд [Authorize(Policy = "Admin")]
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Client", policy => policy.RequireRole("Client").Build());
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin").Build());
                options.AddPolicy("SystemOrAdmin", policy => policy.RequireRole("Admin", "System"));
            });


            // 2����֤����Ȼ�����±ߵ�configure������м������:app.UseMiddleware<JwtTokenAuth>();��������������޷���֤����ʱ�䣬���������Ҫ��֤����ʱ�䣬������Ҫ�±ߵĵ����ַ������ٷ���֤
            #endregion 
            #endregion


            #region ����֤��
            //��ȡ�����ļ�
            var audienceConfig = Configuration.GetSection("Audience");
            var symmetricKeyAsBase64 = audienceConfig["Secret"];
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);


            //2.1����֤��
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
             .AddJwtBearer(o =>
             {
                 o.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuerSigningKey = true,
                     IssuerSigningKey = signingKey,
                     ValidateIssuer = true,
                     ValidIssuer = audienceConfig["Issuer"],//������
                     ValidateAudience = true,
                     ValidAudience = audienceConfig["Audience"],//������
                     ValidateLifetime = true,
                     ClockSkew = TimeSpan.Zero,
                     RequireExpirationTime = true,
                 };

             });





            #endregion

        }
        private const string ApiName = "YH_Student.JWT";
        #region Autofac����ע��
        public void ConfigureContainer(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;
         
            var servicesDllFile = Path.Combine(basePath, "Service.dll");
            var repositoryDllFile = Path.Combine(basePath, "Repository.dll");
            // ��ȡ Service.dll ���򼯷��񣬲�ע��
            var assemblysServices = Assembly.LoadFrom(servicesDllFile);
            builder.RegisterAssemblyTypes(assemblysServices)
                      .AsImplementedInterfaces()
                      .InstancePerDependency()
                      .EnableInterfaceInterceptors();//����Autofac.Extras.DynamicProxy;
            // ��ȡ Repository.dll ���򼯷��񣬲�ע��
            var assemblysRepository = Assembly.LoadFrom(repositoryDllFile);
            builder.RegisterAssemblyTypes(assemblysRepository)
                   .AsImplementedInterfaces()
                   .InstancePerDependency();
        }
        #endregion
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            #region Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //���ݰ汾���Ƶ��� ����չʾ
                typeof(ApiVersions).GetEnumNames().OrderByDescending(e => e).ToList().ForEach(version =>
                {
                    c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"{ApiName} {version}");
                });
                //c.IndexStream = () => GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Blog.Core.index.html");
                c.RoutePrefix = ""; //·�����ã�����Ϊ�գ���ʾֱ���ڸ�������localhost:8001�����ʸ��ļ�,ע��localhost:8001/swagger�Ƿ��ʲ����ģ�ȥlaunchSettings.json��launchUrlȥ��
            });
            #endregion
            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(o =>
            {
                o.SwaggerEndpoint("/swagger/v1/swagger.json", "");
            });
            app.UseRouting();
            app.UseMiddleware<JwtTokenAuth>();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        public enum ApiVersions
        {
            /// <summary>
            /// v1 �汾
            /// </summary>
            v1 = 1,
            /// <summary>
            /// v2 �汾
            /// </summary>
            v2 = 2,
        }
    }
}
