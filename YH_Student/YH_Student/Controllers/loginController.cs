using Autho.JWT;
using Blog.Core.FrameWork.Entity;
using IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YH.Core.Model;
using YH.Core.Model.Models;
namespace YH_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        readonly IStudentServices _studentServices;
        readonly IWaybillServices _WaybillServices;
        public loginController(IStudentServices studentServices, IWaybillServices WaybillServices)
        {
            _studentServices = studentServices;
            _WaybillServices = WaybillServices;


        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="billno"></param>
        /// <returns></returns>
        [HttpGet("{billno}", Name = "Get")]
        [Authorize(Policy = "Admin")]
        [Authorize(Roles = "Admin")]
        public async Task<MessageModel<WayBill>> Get(string billno)
        {
            var data = await _WaybillServices.Query(u => u.BillNo == billno);
            return new MessageModel<WayBill>()
            {
                msg = "获取成功",
                response = data[0]
            };
        }
        // / <summary>
        /// 登录接口：随便输入字符，获取token，然后添加 Authoritarian
        // / </summary>
        // / <param name = "name" ></ param >
        // / < param name="pass"></param>
        /// <returns></returns>
        [HttpGet("GetToken")]
        
        // [Authorize(Policy = "Admin")]
        public async Task<object> GetJWTToken(string name, string pass)
        {
            string jwtStr = string.Empty;
            bool suc = false;
            //这里就是用户登陆以后，通过数据库去调取数据，分配权限的操作
            //这里直接写死了


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
            {
                return new JsonResult(new
                {
                    Status = false,
                    message = "用户名或密码不能为空"
                });
            }

            TokenModelJWT tokenModel = new TokenModelJWT();
            tokenModel.Uid = 1;
            tokenModel.Role = "Admin";

            jwtStr = JwtHelper.IssueJWT(tokenModel);
            suc = true;


            return Ok(new
            {
                success = suc,
                token = jwtStr
            });
        }
        // POST api/values
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<MessageModel<string>> Add([FromQuery] student student)
        {
            var data= await _studentServices.Add(student);
            return new MessageModel<string>()
            {
                msg = "添加成功",
                response = student?.ID.ToString()
            };
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<MessageModel<bool>> Dels(int id)
        {
            var data = new MessageModel<bool>();
            if (id != null)
            {
                var userDetail = await _studentServices.QueryByID(id);

                data.success = await _studentServices.DeleteById(userDetail);
                if (data.success)
                {
                    data.msg = "删除成功";
                    data.response = id>0;
                }
            }

            return data;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<MessageModel<string>> Update([FromBody] student student)
        {
            var data = await _studentServices.Update(student);
            return new MessageModel<string>()
            {
                msg = "更新成功",
                response = student?.ID.ObjToString()

        };
        }
    }
}
