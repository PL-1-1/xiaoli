    //----------NotTransferFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class NotTransferFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillNo { get; set; }

      public string  TransferSite { get; set; }

      public string  ReceivProvince { get; set; }

      public string  ReceivCity { get; set; }

      public string  ReceivArea { get; set; }

      public string  Package { get; set; }

      public decimal  ? FeeWeight { get; set; }

      public double  ? HeavyPrice { get; set; }

      public decimal  ? FeeVolume { get; set; }

      public double  ? LightPrice { get; set; }

      public double  ? ParcelPriceMin { get; set; }

      public int  BillToType { get; set; }

      public double  ? TransferFee { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------NotTransferFee结束----------
    