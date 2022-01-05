    //----------billInventdetail开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billInventdetail//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  invBatchNo { get; set; }

      public string  billno { get; set; }

      public string  Varieties { get; set; }

      public string  Package { get; set; }

      public int  ? num { get; set; }

      public int  ? truenum { get; set; }

      public int  ? qty1 { get; set; }

      public int  ? qty2 { get; set; }

      public DateTime  ? optdate { get; set; }

      public string  optuser { get; set; }

      public decimal  ? FeeWeight { get; set; }

      public decimal  ? FeeVolume { get; set; }

      public string  ExceptionState { get; set; }

      public int  ? invpcs { get; set; }

      public string  companyid { get; set; }

      public int  ? invType { get; set; }

      public string  TransitMode { get; set; }

      public string  TransferSite { get; set; }

      public DateTime  ? ScanTime { get; set; }
 

    }
}
    //----------billInventdetail结束----------
    