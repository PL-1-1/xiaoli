    //----------tab_time开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class tab_time//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  sitename { get; set; }

      public string  Province { get; set; }

      public string  city { get; set; }

      public string  area { get; set; }

      public string  streeet { get; set; }

      public DateTime  ? stoptime { get; set; }

      public DateTime  ? starttime { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------tab_time结束----------
    