    //----------WayBill2018开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBill2018//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  BillId { get; set; }

      public string  BillNo { get; set; }

      public string  VehicleNo { get; set; }

      public DateTime  ? BillDate { get; set; }

      public int  BillState { get; set; }

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

      public string  DisTranBranch { get; set; }

      public string  CollectionBranch { get; set; }

      public string  BillUserId { get; set; }

      public string  BillMan { get; set; }

      public int  ? DeviceSource { get; set; }

      public string  BegWeb { get; set; }

      public int  ? FetchToMonth { get; set; }

      public int  ? CollectionPayState { get; set; }

      public string  Package { get; set; }

      public int  ? sendremainqty { get; set; }

      public int  ? ActualSendFee { get; set; }

      public string  ReceiptState { get; set; }

      public string  ModifyRemark { get; set; }

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

      public int  ? OperTime { get; set; }

      public string  IsCenterBack { get; set; }

      public DateTime  ? OperBespeakTime { get; set; }

      public string  OperBespeakContent { get; set; }

      public string  LoadEweb { get; set; }

      public decimal  ? OptWeight { get; set; }

      public string  StorageLocation { get; set; }

      public int  ? PreState { get; set; }

      public string  ProRemark { get; set; }

      public int  ? BillToType { get; set; }

      public int  ? JMTFindex { get; set; }

      public string  OutWebName { get; set; }

      public string  ZuoFeiMan { get; set; }

      public DateTime  ? ZuoFeiDate { get; set; }

      public string  ShengStore { get; set; }

      public string  AreaWebStore { get; set; }

      public int  ? SendPreState { get; set; }

      public DateTime  ? LabelPrintDate { get; set; }

      public string  LabelPrintWeb { get; set; }

      public DateTime  ? ShortSCAcceptTime { get; set; }

      public int  ? LabelSeq { get; set; }

      public decimal  ? PartyAmount { get; set; }

      public string  PartyType { get; set; }

      public string  FetchAddress { get; set; }

      public string  companyid { get; set; }

      public DateTime  ? MiddleDate { get; set; }

      public decimal  ? AccMiddlePay { get; set; }

      public int  ? AccMiddlePayState { get; set; }

      public string  MiddleWebName { get; set; }

      public string  MiddleCarrier { get; set; }

      public double  ? MiddleSendFee { get; set; }

      public int  ? MiddleSendFeeState { get; set; }

      public decimal  ? ReceiptPay { get; set; }

      public decimal  ? OwePay { get; set; }

      public string  huidanqueren { get; set; }

      public string  BillConfirm { get; set; }

      public int  ? SystemSource { get; set; }

      public string  SignatureRequirements { get; set; }

      public string  numberCopies { get; set; }

      public string  OptCoverage { get; set; }

      public string  DisTranProvice { get; set; }

      public string  DisTranCity { get; set; }

      public string  DisTranType { get; set; }

      public string  DisTranRemark { get; set; }

      public string  DisTranPaymentType { get; set; }

      public string  DisTranProject { get; set; }

      public string  DisTranPhone { get; set; }

      public string  DisTranFeeType { get; set; }

      public string  CollectionProvice { get; set; }

      public string  CollectionCity { get; set; }

      public string  CollectionType { get; set; }

      public string  CollectionRemark { get; set; }

      public string  CollectionPaymentType { get; set; }

      public string  CollectionProject { get; set; }

      public string  CollectionPhone { get; set; }

      public string  CollectionFeeType { get; set; }

      public int  ? IsViewTrace { get; set; }

      public int  ? IsSortFee { get; set; }

      public string  auditMan { get; set; }

      public DateTime  ? auditData { get; set; }

      public int  AuditState { get; set; }

      public decimal  ? MatPay { get; set; }

      public int  ? IsMatPay { get; set; }

      public string  idName { get; set; }

      public string  idCode { get; set; }

      public int  ? IsRebateHasReturned { get; set; }

      public int  ? MarketSuper { get; set; }

      public int  ? IsRebates { get; set; }

      public DateTime  ? businessDate { get; set; }

      public string  ViaCompanyId { get; set; }

      public decimal  ? NumPrice { get; set; }
 

    }
}
    //----------WayBill2018结束----------
    