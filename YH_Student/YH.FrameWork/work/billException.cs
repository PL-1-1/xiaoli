    //----------billException开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billException//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ExtId { get; set; }

      public string  billNo { get; set; }

      public double  ? EXFee { get; set; }

      public string  ExtFeeType { get; set; }

      public DateTime  ? ExtInDate { get; set; }

      public string  ExtInMen { get; set; }

      public DateTime  ? ExtOutDate { get; set; }

      public string  ExtOutMen { get; set; }

      public string  ExtSite { get; set; }

      public string  ExtWeb { get; set; }

      public string  ExtCause { get; set; }

      public string  ExtArea { get; set; }

      public string  ExtType { get; set; }

      public decimal  ? ExCepTionBalance { get; set; }

      public int  ? ExCepTionState { get; set; }

      public string  ExCepTionMan { get; set; }

      public string  ExCepTonWeb { get; set; }

      public string  ExcepTionCause { get; set; }

      public string  ExcepTionArea { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billException结束----------
    