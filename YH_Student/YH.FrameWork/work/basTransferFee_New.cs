    //----------basTransferFee_New开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basTransferFee_New//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  TransferFeeID { get; set; }

      public string  FromSite { get; set; }

      public string  TransferSite { get; set; }

      public string  ToProvince { get; set; }

      public string  ToCity { get; set; }

      public string  ToArea { get; set; }

      public double  ? HeavyPrice { get; set; }

      public double  ? LightPrice { get; set; }

      public double  ? ParcelPriceMin { get; set; }

      public string  Remark { get; set; }

      public string  companyid { get; set; }

      public DateTime  ? createdate { get; set; }

      public string  TransitMode { get; set; }

      public DateTime  ? lastModifyDate { get; set; }
 

    }
}
    //----------basTransferFee_New结束----------
    