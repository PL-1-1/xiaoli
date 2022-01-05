    //----------basDeliveryFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basDeliveryFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  DeliveryFeeID { get; set; }

      public string  Province { get; set; }

      public string  City { get; set; }

      public string  Area { get; set; }

      public string  Street { get; set; }

      public double  ? CenterKilometres { get; set; }

      public double  ? MinWeight { get; set; }

      public double  ? MaxWeight { get; set; }

      public double  ? DeliveryFee { get; set; }

      public string  TransferMode { get; set; }

      public string  Remark { get; set; }

      public DateTime  ? OptTime { get; set; }

      public string  companyid { get; set; }

      public double  ? HeavyPrice { get; set; }

      public double  ? LightPrice { get; set; }

      public double  ? ParcelPriceMin { get; set; }

      public string  sitename { get; set; }

      public double  ? w0_300 { get; set; }

      public double  ? w300_1000 { get; set; }

      public double  ? w1000_3000 { get; set; }

      public double  ? w3000_5000 { get; set; }

      public double  ? w5000_8000 { get; set; }

      public double  ? w8000_ { get; set; }
 

    }
}
    //----------basDeliveryFee结束----------
    