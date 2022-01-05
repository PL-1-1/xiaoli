    //----------basFreightFee_1开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basFreightFee_1//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  FreightId { get; set; }

      public string  StartSite { get; set; }

      public string  Province { get; set; }

      public string  City { get; set; }

      public string  Area { get; set; }

      public string  TransferSite { get; set; }

      public decimal  ? ParcelPriceMin { get; set; }

      public decimal  ? HeavyPrice { get; set; }

      public decimal  ? LightPrice { get; set; }

      public string  TransitMode { get; set; }

      public string  Prescription { get; set; }

      public string  Remark { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basFreightFee_1结束----------
    