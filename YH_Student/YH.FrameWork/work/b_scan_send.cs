    //----------b_scan_send开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_scan_send//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  billno { get; set; }

      public DateTime  ? scandate { get; set; }

      public string  sitename { get; set; }

      public string  webname { get; set; }

      public string  username { get; set; }

      public string  carno { get; set; }

      public string  kwno { get; set; }

      public string  mdd { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------b_scan_send结束----------
    