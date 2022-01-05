    //----------WayBillWb开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillWb//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  Billno { get; set; }

      public int  ? Num { get; set; }

      public decimal  ? Weight { get; set; }

      public decimal  ? Volume { get; set; }

      public decimal  ? Freight { get; set; }

      public decimal  ? DeliFee { get; set; }

      public decimal  ? NowPay { get; set; }

      public decimal  ? FetchPay { get; set; }

      public decimal  ? MonthPay { get; set; }

      public decimal  ? ShortOwePay { get; set; }

      public decimal  ? BefArrivalPay { get; set; }

      public decimal  ? DiscountTransfer { get; set; }

      public decimal  ? SupportValue { get; set; }

      public decimal  ? ReceivFee { get; set; }

      public decimal  ? HandleFee { get; set; }

      public decimal  ? DeclareValue { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------WayBillWb结束----------
    