    //----------billAduit开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billAduit//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  AduitId { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? AduitDate { get; set; }

      public double  ? Amount { get; set; }

      public string  AduitBillState { get; set; }

      public string  AduitMan { get; set; }

      public string  AduitSite { get; set; }

      public string  AduitWeb { get; set; }

      public string  AduitCause { get; set; }

      public string  AduitArea { get; set; }

      public string  BackAduitMan { get; set; }

      public DateTime  ? BackAduitDate { get; set; }

      public string  BackAduitArea { get; set; }

      public string  BackAduitCause { get; set; }

      public string  BackAduitSite { get; set; }

      public string  BackRemark { get; set; }

      public string  BackAduitWeb { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billAduit结束----------
    