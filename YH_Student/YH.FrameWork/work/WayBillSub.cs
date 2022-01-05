    //----------WayBillSub开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillSub//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SubId { get; set; }

      public string  BillNo { get; set; }

      public string  Varieties { get; set; }

      public string  Package { get; set; }

      public int  ? Num { get; set; }

      public decimal  ? FeeWeight { get; set; }

      public decimal  ? FeeVolume { get; set; }

      public decimal  ? Weight { get; set; }

      public decimal  ? Volume { get; set; }

      public decimal  ? WeightPrice { get; set; }

      public decimal  ? VolumePrice { get; set; }

      public string  FeeType { get; set; }

      public decimal  ? Freight { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------WayBillSub结束----------
    