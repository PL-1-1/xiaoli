    //----------billDepartureFBListTmp开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDepartureFBListTmp//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  PID { get; set; }

      public string  BillNo { get; set; }

      public string  CarNo { get; set; }

      public string  DriverName { get; set; }

      public string  DriverPhone { get; set; }

      public string  Madeby { get; set; }

      public DateTime  SendDate { get; set; }

      public string  FromCause { get; set; }

      public string  FromArea { get; set; }

      public string  FromSiteName { get; set; }

      public string  FromWebName { get; set; }

      public string  AcceptCompanyId { get; set; }

      public string  AcceptCause { get; set; }

      public string  AcceptArea { get; set; }

      public string  AcceptSiteName { get; set; }

      public string  AcceptWebName { get; set; }

      public string  AcceptMan { get; set; }

      public DateTime  ? AcceptDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billDepartureFBListTmp结束----------
    