    //----------WaybillSettlement开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WaybillSettlement//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  BillNo { get; set; }

      public decimal  ? MainlineFee { get; set; }

      public decimal  ? TransferFee { get; set; }

      public decimal  ? DepartureOptFee { get; set; }

      public decimal  ? TerminalOptFee { get; set; }

      public decimal  ? TerminalAllotFee { get; set; }

      public decimal  ? DepartureAllotFee { get; set; }

      public decimal  ? NoticeFee_C { get; set; }

      public decimal  ? SupportValue_C { get; set; }

      public decimal  ? AgentFee_C { get; set; }

      public decimal  ? PackagFee_C { get; set; }

      public decimal  ? OtherFee_C { get; set; }

      public decimal  ? HandleFee_C { get; set; }

      public decimal  ? StorageFee_C { get; set; }

      public decimal  ? WarehouseFee_C { get; set; }

      public decimal  ? ForkliftFee_C { get; set; }

      public decimal  ? Tax_C { get; set; }

      public decimal  ? ChangeFee_C { get; set; }

      public decimal  ? UpstairFee_C { get; set; }

      public decimal  ? CustomsFee_C { get; set; }

      public decimal  ? FrameFee_C { get; set; }

      public decimal  ? Expense_C { get; set; }

      public decimal  ? FuelFee_C { get; set; }

      public decimal  ? InformationFee_C { get; set; }

      public string  companyid { get; set; }

      public decimal  ? DeliveryFee { get; set; }

      public decimal  ? ReceiptFee_C { get; set; }

      public string  Batch { get; set; }

      public DateTime  ? BillDate { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  BegWeb { get; set; }

      public DateTime  ? CreateDate { get; set; }
 

    }
}
    //----------WaybillSettlement结束----------
    