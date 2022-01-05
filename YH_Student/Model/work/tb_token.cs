    //----------tb_token开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class tb_token//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  userId { get; set; }

      public string  token { get; set; }

      public DateTime  ? expireTime { get; set; }

      public DateTime  ? updateTime { get; set; }

      public string  loginAreaName { get; set; }

      public string  loginCauseName { get; set; }

      public string  loginDepartName { get; set; }

      public string  loginSiteName { get; set; }

      public string  loginWebName { get; set; }

      public string  loginUserAccount { get; set; }

      public string  loginUserName { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------tb_token结束----------
    