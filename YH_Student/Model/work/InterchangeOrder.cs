    //----------InterchangeOrder开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class InterchangeOrder//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  InterNo { get; set; }

      public string  CarNo { get; set; }

      public string  CarDervice { get; set; }

      public string  CarPhone { get; set; }

      public string  KwNo { get; set; }

      public string  Username { get; set; }

      public string  Bsite { get; set; }

      public string  Bweb { get; set; }

      public string  Esite { get; set; }

      public string  InterStatus { get; set; }

      public DateTime  ? CreateDate { get; set; }

      public string  BatchNo { get; set; }

      public string  PackType { get; set; }

      public DateTime  ? PackDate { get; set; }

      public string  PackCreater { get; set; }

      public string  PackWeb { get; set; }

      public string  opttype { get; set; }

      public string  InterType { get; set; }

      public string  downType { get; set; }

      public int  ? isover { get; set; }

      public int  ? iCount { get; set; }

      public string  Eweb { get; set; }

      public string  operationType { get; set; }

      public string  ScanSite { get; set; }

      public string  ScanWeb { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------InterchangeOrder结束----------
    