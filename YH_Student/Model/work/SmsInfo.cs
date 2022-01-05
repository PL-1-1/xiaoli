    //----------SmsInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SmsInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  smsid { get; set; }

      public string  smsuserid { get; set; }

      public string  smspassword { get; set; }

      public string  smsCompanyName { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------SmsInfo结束----------
    