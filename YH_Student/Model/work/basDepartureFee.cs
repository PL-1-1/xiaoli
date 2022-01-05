    //----------basDepartureFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basDepartureFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  FeeType { get; set; }

      public decimal  ? Price { get; set; }

      public string  Unit { get; set; }

      public string  companyid { get; set; }

      public string  Descript { get; set; }

      public decimal  ? MinLength { get; set; }

      public decimal  ? MaxLength { get; set; }

      public DateTime  ? lastModifyDate { get; set; }
 

    }
}
    //----------basDepartureFee结束----------
    