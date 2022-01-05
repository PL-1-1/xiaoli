    //----------RecRoute开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class RecRoute//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  webname { get; set; }

      public string  sitename { get; set; }

      public string  centername { get; set; }

      public string  bsitename { get; set; }

      public DateTime  ? opt_date { get; set; }

      public string  bCausename { get; set; }

      public string  bAreaname { get; set; }

      public Guid  ? RouteId { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------RecRoute结束----------
    