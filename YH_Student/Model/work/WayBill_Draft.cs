    //----------WayBill_Draft开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBill_Draft//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillId { get; set; }

      public string  BillNo { get; set; }

      public string  VehicleNo { get; set; }

      public DateTime  ? BillDate { get; set; }

      public int  ? BillState { get; set; }

      public string  StartSite { get; set; }

      public string  TransferMode { get; set; }

      public string  DestinationSite { get; set; }

      public string  TransferSite { get; set; }

      public string  TransitLines { get; set; }

      public string  TransitMode { get; set; }

      public string  CusOderNo { get; set; }

      public string  ConsigneeCellPhone { get; set; }

      public string  ConsigneePhone { get; set; }

      public string  ConsigneeName { get; set; }

      public string  ConsigneeCompany { get; set; }

      public string  PickGoodsSite { get; set; }

      public string  ReceivProvince { get; set; }

      public string  ReceivCity { get; set; }

      public string  ReceivArea { get; set; }

      public string  ReceivStreet { get; set; }

      public string  ReceivAddress { get; set; }

      public string  ConsignorCellPhone { get; set; }

      public string  ConsignorPhone { get; set; }

      public string  ConsignorName { get; set; }

      public string  ConsignorCompany { get; set; }

      public string  ReceivMode { get; set; }

      public string  CusNo { get; set; }

      public string  CusType { get; set; }

      public string  ValuationType { get; set; }

      public string  ReceivOrderNo { get; set; }

      public string  Salesman { get; set; }

      public int  ? AlienGoods { get; set; }

      public int  ? GoodsVoucher { get; set; }

      public int  ? PreciousGoods { get; set; }

      public int  ? NoticeState { get; set; }

      public string  GoodsType { get; set; }

      public string  Varieties { get; set; }

      public int  ? Num { get; set; }

      public int  ? LeftNum { get; set; }

      public decimal  ? FeeWeight { get; set; }

      public decimal  ? FeeVolume { get; set; }

      public decimal  ? Weight { get; set; }

      public decimal  ? Volume { get; set; }

      public decimal  ? WeightPrice { get; set; }

      public decimal  ? VolumePrice { get; set; }

      public string  FeeType { get; set; }

      public decimal  ? Freight { get; set; }

      public decimal  ? DeliFee { get; set; }

      public decimal  ? ReceivFee { get; set; }

      public decimal  ? DeclareValue { get; set; }

      public decimal  ? SupportValue { get; set; }

      public decimal  ? Rate { get; set; }

      public decimal  ? Tax { get; set; }

      public decimal  ? InformationFee { get; set; }

      public decimal  ? Expense { get; set; }

      public decimal  ? NoticeFee { get; set; }

      public decimal  ? DiscountTransfer { get; set; }

      public decimal  ? CollectionPay { get; set; }

      public decimal  ? AgentFee { get; set; }

      public decimal  ? FuelFee { get; set; }

      public decimal  ? UpstairFee { get; set; }

      public decimal  ? HandleFee { get; set; }

      public decimal  ? ForkliftFee { get; set; }

      public decimal  ? StorageFee { get; set; }

      public decimal  ? CustomsFee { get; set; }

      public decimal  ? PackagFee { get; set; }

      public decimal  ? FrameFee { get; set; }

      public decimal  ? ChangeFee { get; set; }

      public decimal  ? OtherFee { get; set; }

      public int  ? IsInvoice { get; set; }

      public decimal  ? ReceiptFee { get; set; }

      public string  ReceiptCondition { get; set; }

      public decimal  ? FreightAmount { get; set; }

      public decimal  ? ActualFreight { get; set; }

      public string  CouponsNo { get; set; }

      public decimal  ? CouponsAmount { get; set; }

      public string  PaymentMode { get; set; }

      public decimal  ? PaymentAmout { get; set; }

      public string  PayMode { get; set; }

      public decimal  ? NowPay { get; set; }

      public decimal  ? FetchPay { get; set; }

      public decimal  ? MonthPay { get; set; }

      public decimal  ? ShortOwePay { get; set; }

      public decimal  ? BefArrivalPay { get; set; }

      public string  BillRemark { get; set; }

      public string  WebPlatform { get; set; }

      public string  WebBillNo { get; set; }

      public string  DisTranName { get; set; }

      public string  DisTranBank { get; set; }

      public string  DisTranAccount { get; set; }

      public string  CollectionName { get; set; }

      public string  CollectionBank { get; set; }

      public string  CollectionAccount { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DepName { get; set; }

      public string  SignMan { get; set; }

      public DateTime  ? SignTime { get; set; }

      public string  SignPapers { get; set; }

      public string  SignRemark { get; set; }

      public string  SCDesSite { get; set; }

      public string  SCDesWeb { get; set; }

      public string  TermtranSite { get; set; }

      public string  TermtranWeb { get; set; }

      public string  LoadSite { get; set; }

      public string  LoadWeb { get; set; }

      public string  StartBatch { get; set; }

      public string  DriverName { get; set; }

      public string  CarNO { get; set; }

      public DateTime  ? WebDate { get; set; }

      public string  SendVehNo { get; set; }

      public string  SendDriver { get; set; }

      public DateTime  ? SendTime { get; set; }

      public decimal  ? OtherTotalFee { get; set; }

      public decimal  ? BillTotalFee { get; set; }

      public string  DisTranBranch { get; set; }

      public string  CollectionBranch { get; set; }

      public string  BillUserId { get; set; }

      public string  BillMan { get; set; }

      public int  ? DeviceSource { get; set; }

      public string  BegWeb { get; set; }

      public int  ? FetchToMonth { get; set; }

      public decimal  ? AccMiddlePay { get; set; }

      public int  ? CollectionPayState { get; set; }

      public string  Package { get; set; }

      public DateTime  ? MiddleDate { get; set; }

      public int  ? sendremainqty { get; set; }

      public int  ? ActualSendFee { get; set; }

      public string  ReceiptState { get; set; }

      public string  ModifyRemark { get; set; }

      public decimal  ? MiddlePackageFee { get; set; }

      public decimal  ? MiddleHandleFee { get; set; }

      public decimal  ? MiddleForkliftFee { get; set; }

      public decimal  ? MiddleOtherFee { get; set; }

      public string  MiddleCarrier { get; set; }

      public string  MiddleBillNo { get; set; }

      public string  MiddleFetchAddress { get; set; }

      public int  ? MiddleFeePaymentState { get; set; }

      public string  MiddleStartSitePhone { get; set; }

      public string  MiddleEndSitePhone { get; set; }

      public string  MiddleOperator { get; set; }

      public string  MiddleRemark { get; set; }

      public string  MiddleOtherReason { get; set; }

      public string  MiddleBatch { get; set; }

      public string  MiddleSiteName { get; set; }

      public string  MiddleWebName { get; set; }

      public int  ? MiddleType { get; set; }

      public string  MiddleCauseName { get; set; }

      public string  MiddleAreaName { get; set; }

      public string  MiddleDepName { get; set; }

      public int  ? AccMiddlePayState { get; set; }

      public decimal  ? AccMiddlePayLeft { get; set; }

      public int  ? MiddleState { get; set; }

      public DateTime  ? PossiblArrivalTime { get; set; }

      public DateTime  ? ArrivalTime { get; set; }

      public DateTime  ? MiddleSendTime { get; set; }

      public int  ? MiddleTraceState { get; set; }

      public int  ? ArrivedState { get; set; }

      public string  ConsigneeCompany_K { get; set; }

      public string  ConsigneeName_K { get; set; }

      public string  ConsigneePhone_K { get; set; }

      public string  ConsigneeCellPhone_K { get; set; }

      public decimal  ? ChangeAddFee { get; set; }

      public string  BespeakContent { get; set; }

      public decimal  ? WarehouseFee { get; set; }

      public DateTime  ? BespeakTime { get; set; }

      public decimal  ? MainlineFee { get; set; }

      public decimal  ? DeliveryFee { get; set; }

      public decimal  ? TransferFee { get; set; }

      public decimal  ? DepartureOptFee { get; set; }

      public decimal  ? TerminalOptFee { get; set; }

      public decimal  ? TerminalAllotFee { get; set; }

      public decimal  ? DepartureAllotFee { get; set; }

      public double  ? Accept { get; set; }

      public int  ? IsReceiptFee { get; set; }

      public int  ? IsSupportValue { get; set; }

      public int  ? IsAgentFee { get; set; }

      public int  ? IsPackagFee { get; set; }

      public int  ? IsOtherFee { get; set; }

      public int  ? IsHandleFee { get; set; }

      public int  ? IsStorageFee { get; set; }

      public int  ? IsWarehouseFee { get; set; }

      public int  ? IsForkliftFee { get; set; }

      public int  ? IsChangeFee { get; set; }

      public int  ? IsUpstairFee { get; set; }

      public int  ? IsCustomsFee { get; set; }

      public int  ? IsFrameFee { get; set; }

      public decimal  ? ReceiptFee_C { get; set; }

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

      public decimal  ? OperationWeight { get; set; }

      public decimal  ? OptWeight { get; set; }

      public string  ShengStore { get; set; }

      public string  AreaWebStore { get; set; }

      public string  companyid { get; set; }

      public int  ? IsRebateHasReturned { get; set; }
 

    }
}
    //----------WayBill_Draft结束----------
    