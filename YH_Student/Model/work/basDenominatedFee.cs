    //----------basDenominatedFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basDenominatedFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? DenominatedFeeID { get; set; }

      public string  CusName { get; set; }

      public string  StartSite { get; set; }

      public string  Province { get; set; }

      public string  City { get; set; }

      public string  Area { get; set; }

      public double  ? WeightMin { get; set; }

      public double  ? WeightMax { get; set; }

      public double  ? HeavyPrice { get; set; }

      public double  ? HeavyPriceMin { get; set; }

      public double  ? VolumeMin { get; set; }

      public double  ? VolumeMax { get; set; }

      public double  ? LightPrice { get; set; }

      public double  ? LightPriceMin { get; set; }

      public decimal  ? DeliFee { get; set; }

      public decimal  ? ReceivFee { get; set; }

      public string  companyid { get; set; }

      public string  TransitMode { get; set; }

      public decimal  ? NumPrice { get; set; }

      public string  Varieties { get; set; }
 

    }
}
    //----------basDenominatedFee结束----------
    