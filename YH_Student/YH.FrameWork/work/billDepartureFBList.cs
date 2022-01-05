    //----------billDepartureFBList开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDepartureFBList//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  PID { get; set; }

      public string  BillNo { get; set; }

      public string  CarNo { get; set; }

      public string  DriverName { get; set; }

      public string  DriverPhone { get; set; }

      public DateTime  SendDate { get; set; }

      public string  FromCause { get; set; }

      public string  FromArea { get; set; }

      public string  FromSiteName { get; set; }

      public string  FromWebName { get; set; }

      public string  AcceptCompanyId { get; set; }

      public string  AcceptCause { get; set; }

      public string  AcceptArea { get; set; }

      public string  AcceptSiteName { get; set; }

      public string  AcceptWebName { get; set; }

      public string  AcceptMan { get; set; }

      public DateTime  ? AcceptDate { get; set; }

      public string  Madeby { get; set; }

      public string  companyid { get; set; }

      public string  AllocateBatch { get; set; }

      public int  ? RemainWebPCS { get; set; }

      public int  ? WebPCS { get; set; }

      public int  ? IsOut { get; set; }

      public int  ? FBBillState { get; set; }

      public decimal  ? FBTransferFee { get; set; }

      public decimal  ? FBDeliveryFee { get; set; }

      public decimal  ? FBTax_C { get; set; }

      public decimal  ? FBTerminalOptFee { get; set; }

      public decimal  ? FBSupportValue_C { get; set; }

      public decimal  ? FBStorageFee_C { get; set; }

      public decimal  ? FBNoticeFee_C { get; set; }

      public decimal  ? FBHandleFee_C { get; set; }

      public decimal  ? FBUpstairFee_C { get; set; }

      public decimal  ? FBReceiptFee_C { get; set; }

      public string  AllocateCount { get; set; }

      public decimal  ? MainlineFee_r { get; set; }

      public decimal  ? TransferFee_r { get; set; }

      public decimal  ? DeliveryFee_r { get; set; }

      public string  OptionType { get; set; }

      public decimal  ? FBDepartureOptFee { get; set; }

      public decimal  ? FBMainlineFee { get; set; }

      public decimal  ? FBDepartureAllotFee { get; set; }
 

    }
}
    //----------billDepartureFBList结束----------
    