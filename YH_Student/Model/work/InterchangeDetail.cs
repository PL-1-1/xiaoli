    //----------InterchangeDetail开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class InterchangeDetail//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  InterNo { get; set; }

      public string  billno { get; set; }

      public int  ? scanqty { get; set; }

      public string  webname { get; set; }

      public string  BatchNo { get; set; }

      public string  PackType { get; set; }

      public string  scanmode { get; set; }

      public string  downType { get; set; }

      public int  ? IsDelete { get; set; }

      public string  OperMan { get; set; }

      public DateTime  ? OperDate { get; set; }

      public DateTime  ? ScanTime { get; set; }

      public string  optMan { get; set; }

      public string  optManId { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------InterchangeDetail结束----------
    