    //----------billSentCity开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billSentCity//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? SendID { get; set; }

      public string  BillNo { get; set; }

      public string  AcceptSiteName { get; set; }

      public string  AcceptWebName { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  SendMan { get; set; }

      public DateTime  ? SendDate { get; set; }

      public string  SendType { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billSentCity结束----------
    