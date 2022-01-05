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
            #region 注册Swagger
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc("v1", new OpenApiInfo { Title = "API接口文档", Version = "v1", Description = "基于 .NET Core 3.1 的Api" });
                // 获取xml文件路径
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
                o.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                var xmlPath = Path.Combine(basePath, "YH_Student.xml");
                // 加载xml文件（为Swagger JSON and UI 设置xml文档注释路径）
                o.IncludeXmlComments(xmlPath, true);
            });
            #endregion
            #region 数据库连接
            BaseDBConfig.ConnectionString = Configuration.GetSection("AppSettings:SqlServerConnection").Value;
            #endregion
            #region 【简单授权】
            #region 1、基于角色的API授权 

            // 1【授权】、这个很简单，其他什么都不用做，
            // 无需配置服务，只需要在API层的controller上边，增加特性即可，注意，只能是角色的:
            // [Authorize(Roles = "Admin")]

            // 2【认证】、然后在下边的configure里，配置中间件即可:app.UseMiddleware<JwtTokenAuth>();但是这个方法，无法验证过期时间，所以如果需要验证过期时间，还是需要下边的第三种方法，官方认证

            #endregion

            #region 2、基于策略的授权（简单版）

            // 1【授权】、这个和上边的异曲同工，好处就是不用在controller中，写多个 roles 。
            // 然后这么写 [Authorize(Policy = "Admin")]
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Client", policy => policy.RequireRole("Client").Build());
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin").Build());
                options.AddPolicy("SystemOrAdmin", policy => policy.RequireRole("Admin", "System"));
            });


            // 2【认证】、然后在下边的configure里，配置中间件即可:app.UseMiddleware<JwtTokenAuth>();但是这个方法，无法验证过期时间，所以如果需要验证过期时间，还是需要下边的第三种方法，官方认证
            #endregion 
            #endregion


            #region 【认证】
            //读取配置文件
            var audienceConfig = Configuration.GetSection("Audience");
            var symmetricKeyAsBase64 = audienceConfig["Secret"];
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);


            //2.1【认证】
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
                     ValidIssuer = audienceConfig["Issuer"],//发行人
                     ValidateAudience = true,
                     ValidAudience = audienceConfig["Audience"],//订阅人
                     ValidateLifetime = true,
                     ClockSkew = TimeSpan.Zero,
                     RequireExpirationTime = true,
                 };

             });





            #endregion

        }
        private const string ApiName = "YH_Student.JWT";
        #region Autofac依赖注入
        public void ConfigureContainer(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;
         
            var servicesDllFile = Path.Combine(basePath, "Service.dll");
            var repositoryDllFile = Path.Combine(basePath, "Repository.dll");
            // 获取 Service.dll 程序集服务，并注册
            var assemblysServices = Assembly.LoadFrom(servicesDllFile);
            builder.RegisterAssemblyTypes(assemblysServices)
                      .AsImplementedInterfaces()
                      .InstancePerDependency()
                      .EnableInterfaceInterceptors();//引用Autofac.Extras.DynamicProxy;
            // 获取 Repository.dll 程序集服务，并注册
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
                //根据版本名称倒序 遍历展示
                typeof(ApiVersions).GetEnumNames().OrderByDescending(e => e).ToList().ForEach(version =>
                {
                    c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"{ApiName} {version}");
                });
                //c.IndexStream = () => GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Blog.Core.index.html");
                c.RoutePrefix = ""; //路径配置，设置为空，表示直接在根域名（localhost:8001）访问该文件,注意localhost:8001/swagger是访问不到的，去launchSettings.json把launchUrl去掉
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
            /// v1 版本
            /// </summary>
            v1 = 1,
            /// <summary>
            /// v2 版本
            /// </summary>
            v2 = 2,
        }
    }
}
