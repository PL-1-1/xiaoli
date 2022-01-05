    //----------WayBillModifiedRePort开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillModifiedRePort//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  BillState { get; set; }

      public string  Opertype { get; set; }

      public DateTime  ? ModifieyDate { get; set; }

      public string  ModifieyMan { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? BillDate { get; set; }

      public string  StartSite { get; set; }

      public string  DestinationSite { get; set; }

      public string  MiddleSiteName { get; set; }

      public string  ConsignorName { get; set; }

      public string  ConsigneeName { get; set; }

      public string  ConsigneeCompany { get; set; }

      public string  Varieties { get; set; }

      public decimal  ? NowPay { get; set; }

      public decimal  ? FetchPay { get; set; }

      public decimal  ? MonthPay { get; set; }

      public decimal  ? ShortOwePay { get; set; }

      public decimal  ? DiscountTransfer { get; set; }

      public decimal  ? CollectionPay { get; set; }

      public string  PaymentMode { get; set; }

      public string  ConsignorCompany { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------WayBillModifiedRePort结束----------
    