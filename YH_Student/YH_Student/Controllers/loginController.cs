using IServices;
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
    
        public loginController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
          
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public async Task<MessageModel<student>> Get(int id)
        {
            var data = await _studentServices.QueryByID(id);
            return new MessageModel<student>()
            {
                msg = "获取成功",          
                response = data
            };
        }
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
