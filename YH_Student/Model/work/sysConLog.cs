    //----------sysConLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysConLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ConId { get; set; }

      public string  ConUser { get; set; }

      public DateTime  ? ConTime { get; set; }

      public string  ConHostName { get; set; }

      public string  ConMAc { get; set; }

      public string  ConLANIp { get; set; }

      public string  ConWANIp { get; set; }

      public string  ConAddress { get; set; }

      public string  UserName { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------sysConLog结束----------
    