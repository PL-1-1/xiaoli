    //----------sysUserPDA开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysUserPDA//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  UserId { get; set; }

      public string  UserAccount { get; set; }

      public string  UserName { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DepartName { get; set; }

      public int  ? UserState { get; set; }

      public DateTime  ? lastLogTime { get; set; }

      public string  LastLogLANIp { get; set; }

      public string  LastLogWANIp { get; set; }

      public int  ? IsRestart { get; set; }

      public string  PDApwd { get; set; }
 

    }
}
    //----------sysUserPDA结束----------
    