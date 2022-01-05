    //----------b_users开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_users//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  UserName { get; set; }

      public string  loginsite { get; set; }

      public string  loginwebid { get; set; }

      public string  userid { get; set; }

      public string  password { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  PDApwd { get; set; }
 

    }
}
    //----------b_users结束----------
    