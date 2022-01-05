    //----------basOtherName开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basOtherName//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ? CarRunTime { get; set; }

      public int  ? factqty { get; set; }

      public int  ? BillRunTime { get; set; }

      public int  ? HaveDaiShou { get; set; }

      public int  ? BillCount { get; set; }

      public int  ? TotalNum { get; set; }

      public decimal  ? TotalWeight { get; set; }

      public decimal  ? TotalVolume { get; set; }

      public decimal  ? TotalFetchPay { get; set; }

      public decimal  ? TotalDeliFee { get; set; }

      public decimal  ? TotalAccSend { get; set; }

      public decimal  ? TotalProfit { get; set; }

      public decimal  ? TotalSjSend { get; set; }

      public decimal  ? TotalCollectionPay { get; set; }

      public decimal  ? acctotal { get; set; }

      public string  SendOperator { get; set; }

      public DateTime  ? SendOperateTime { get; set; }

      public string  SendOperateSite { get; set; }

      public string  SendOperateWeb { get; set; }

      public string  SendOperateState { get; set; }

      public string  BackOperator { get; set; }

      public DateTime  ? BackOperateTime { get; set; }

      public string  BackOperateSite { get; set; }

      public string  BackOperateWeb { get; set; }

      public string  BackOperateState { get; set; }

      public string  ToFactoryOperator { get; set; }

      public DateTime  ? ToFactoryOperateTime { get; set; }

      public string  ToFactoryOperateSite { get; set; }

      public string  ToFactoryOperateWeb { get; set; }

      public string  ToFactoryOperateState { get; set; }

      public string  CustGetOperator { get; set; }

      public string  CustGetLinkTel { get; set; }

      public DateTime  ? CustGetOperateTime { get; set; }

      public string  CustGetOperateSite { get; set; }

      public string  CustGetOperateWeb { get; set; }

      public string  CustGetOperateState { get; set; }

      public double  ? FeeWeigtTotal { get; set; }

      public double  ? FeeVolumeTotal { get; set; }

      public int  ? shorConnNum { get; set; }

      public decimal  ? ArrComfirmFee { get; set; }

      public string  waybillno { get; set; }

      public int  ? ischecked { get; set; }

      public double  ? CurrentVerifyFee { get; set; }

      public string  billno_c { get; set; }

      public string  FeeType { get; set; }

      public decimal  ? AccountsPayable { get; set; }

      public decimal  ? UnpaidAccounts { get; set; }

      public decimal  ? PrepaidAccounts { get; set; }

      public decimal  ? sfjhf { get; set; }

      public decimal  ? sfmjf { get; set; }

      public decimal  ? sfzxf { get; set; }

      public decimal  ? sfccf { get; set; }

      public decimal  ? sfqtf { get; set; }

      public decimal  ? sfjhfsj { get; set; }

      public decimal  ? sfmjfsj { get; set; }

      public decimal  ? sfzxfsj { get; set; }

      public decimal  ? sfccfsj { get; set; }

      public decimal  ? sfqtfsj { get; set; }

      public decimal  ? zdjcf { get; set; }

      public decimal  ? zdmjf { get; set; }

      public decimal  ? zdzxf { get; set; }

      public decimal  ? zdccf { get; set; }

      public decimal  ? zdqtf { get; set; }

      public decimal  ? zdbgf { get; set; }

      public decimal  ? zdjcfsj { get; set; }

      public decimal  ? zdmjfsj { get; set; }

      public decimal  ? zdzxfsj { get; set; }

      public decimal  ? zdccfsj { get; set; }

      public decimal  ? zdqtfsj { get; set; }

      public decimal  ? zdbgfsj { get; set; }

      public decimal  ? wprice { get; set; }

      public decimal  ? vprice { get; set; }

      public int  ? IsPrint { get; set; }

      public string  SignWeb { get; set; }

      public decimal  ? BadAmout { get; set; }

      public int  ? sendqty { get; set; }

      public int  ? sendremainqty0 { get; set; }

      public string  SignMan { get; set; }

      public string  SignDate { get; set; }

      public string  NumEqually { get; set; }

      public decimal  ? SumNum { get; set; }

      public decimal  ? SumOptWeight { get; set; }

      public string  SumVolume { get; set; }

      public int  ? LckDay { get; set; }

      public decimal  ? SumDepartAmount { get; set; }

      public string  ArrConfirmState { get; set; }

      public int  ? remaindays { get; set; }

      public decimal  ? SumFeeWeight { get; set; }

      public decimal  ? SumFeeVolume { get; set; }

      public string  SendVerifState { get; set; }

      public string  DeliveryFee { get; set; }

      public string  isIncom { get; set; }

      public decimal  ? AccMiddleMaoli { get; set; }

      public string  TheMonth { get; set; }

      public string  aduitStateStr { get; set; }

      public string  OthterFeeOut { get; set; }

      public string  MiddleConfirmState { get; set; }

      public decimal  ? AccMiddlePayRadio { get; set; }

      public double  ? GrossProfit { get; set; }

      public double  ? Cost { get; set; }

      public DateTime  ? dedisysBillTime { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? BillDate { get; set; }

      public string  kmsbillno { get; set; }

      public string  BegWeb { get; set; }

      public string  BillMan { get; set; }

      public DateTime  ? ZXBillDate { get; set; }

      public string  ZXBegWeb { get; set; }

      public int  ? ZXBillState { get; set; }

      public string  ZXBillMan { get; set; }

      public decimal  ? Amount { get; set; }

      public decimal  ? AmountLeft { get; set; }

      public string  VerifyStatus { get; set; }

      public string  ComeFrom { get; set; }

      public string  BelongMonth { get; set; }

      public decimal  ? DeliveryFee_S { get; set; }

      public decimal  ? DeliveryFee_D { get; set; }

      public string  RunDate { get; set; }

      public decimal  ? Actualfeetotal { get; set; }

      public decimal  ? Addfeetotal { get; set; }

      public decimal  ? VerifAmount { get; set; }

      public string  WipArea { get; set; }

      public string  WipCause { get; set; }

      public string  WipWeb { get; set; }

      public string  MiddleFetchPayState { get; set; }

      public string  VerifyWeb { get; set; }

      public int  ? Shortcount { get; set; }

      public int  ? tShortcount { get; set; }

      public int  ? departcount { get; set; }

      public int  ? sendcount { get; set; }

      public int  ? unusualcount { get; set; }

      public int  ? signcount { get; set; }

      public DateTime  ? OperateTime { get; set; }

      public double  ? acc1 { get; set; }

      public double  ? acc2 { get; set; }

      public double  ? acc3 { get; set; }

      public double  ? acc4 { get; set; }

      public double  ? acc5 { get; set; }

      public double  ? acc6 { get; set; }

      public double  ? acc7 { get; set; }

      public double  ? acc8 { get; set; }

      public double  ? acc9 { get; set; }

      public string  UNTradeDay { get; set; }

      public string  SendBatchA { get; set; }

      public string  SendToWebA { get; set; }

      public string  SendWebA { get; set; }

      public DateTime  ? SendDateA { get; set; }

      public string  SendOperatorA { get; set; }

      public int  ? Qualified { get; set; }

      public int  ? UnQualified { get; set; }

      public string  QualifiedRate { get; set; }

      public string  LatestTrackInfomation { get; set; }

      public decimal  ? Surcharge { get; set; }

      public string  GrossProfitRate { get; set; }

      public decimal  ? AllFee { get; set; }

      public string  PCVerifyState { get; set; }

      public int  ? billscan { get; set; }

      public decimal  ? scanrate { get; set; }

      public string  DHCauseName { get; set; }

      public string  DHAreaName { get; set; }

      public int  ? scbillcount { get; set; }

      public int  ? lccount { get; set; }

      public int  ? secondlccount { get; set; }

      public decimal  ? ckrate { get; set; }

      public decimal  ? lcVolume { get; set; }

      public string  Varieties2 { get; set; }

      public string  Package2 { get; set; }

      public int  ? Num2 { get; set; }

      public decimal  ? FeeWeight2 { get; set; }

      public decimal  ? FeeVolume2 { get; set; }

      public decimal  ? Weight2 { get; set; }

      public decimal  ? Volume2 { get; set; }

      public decimal  ? VolumePrice2 { get; set; }

      public decimal  ? WeightPrice2 { get; set; }

      public decimal  ? Freight2 { get; set; }

      public string  FeeType2 { get; set; }

      public decimal  ? FeeVolume1 { get; set; }

      public decimal  ? FeeWeight1 { get; set; }

      public string  Varieties1 { get; set; }

      public string  Package1 { get; set; }

      public int  ? Num1 { get; set; }

      public decimal  ? Weight1 { get; set; }

      public decimal  ? Volume1 { get; set; }

      public decimal  ? WeightPrice1 { get; set; }

      public decimal  ? VolumePrice1 { get; set; }

      public decimal  ? Freight1 { get; set; }

      public string  FeeType1 { get; set; }

      public string  IsLiuCang { get; set; }

      public int  ? InventoryNum { get; set; }

      public string  InventoryReMark { get; set; }

      public string  aduitstate { get; set; }

      public string  ysweb { get; set; }

      public int  ? SumWebPCS { get; set; }

      public string  opertype { get; set; }

      public decimal  ? SumFreight { get; set; }

      public decimal  ? FenBoFee { get; set; }

      public decimal  ? SFFenBoFee { get; set; }

      public string  kcid { get; set; }

      public string  Type { get; set; }

      public string  IsAcceptejSend { get; set; }

      public string  outtime { get; set; }

      public string  DeliveryFeeX { get; set; }

      public int  ? PDCompare { get; set; }

      public decimal  ? accjs { get; set; }

      public decimal  ? accml { get; set; }

      public decimal  ? mllv { get; set; }

      public int  ? LeftGoodsNum { get; set; }

      public string  tx_type { get; set; }

      public string  bl_confirm { get; set; }

      public string  zf_billno { get; set; }

      public string  billType { get; set; }

      public decimal  ? AccountsAvg { get; set; }

      public string  belongWebName { get; set; }

      public decimal  ? JieSuanFee { get; set; }

      public decimal  ? zzml { get; set; }

      public DateTime  ? SCDate1 { get; set; }

      public DateTime  ? AcceptBillDate1 { get; set; }

      public string  SCDesWeb1 { get; set; }

      public DateTime  ? SCDate2 { get; set; }

      public DateTime  ? AcceptBillDate2 { get; set; }

      public string  SCDesWeb2 { get; set; }

      public DateTime  ? SCDate3 { get; set; }

      public DateTime  ? AcceptBillDate3 { get; set; }

      public string  SCDesWeb3 { get; set; }

      public string  companyid { get; set; }

      public decimal  ? outaccount { get; set; }

      public decimal  ? account { get; set; }

      public decimal  ? accleft { get; set; }

      public decimal  ? Totalin { get; set; }

      public DateTime  ? bdate { get; set; }

      public DateTime  ? edate { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  WebName { get; set; }

      public decimal  ? TwoPensPay { get; set; }

      public decimal  ? SettmentWeight { get; set; }

      public Guid  ? BillAccountID { get; set; }

      public decimal  ? StartReceivFee { get; set; }

      public double  ? acc10 { get; set; }

      public double  ? acc11 { get; set; }

      public decimal  ? Totalin1 { get; set; }

      public decimal  ? JHFee { get; set; }

      public decimal  ? totalCost { get; set; }

      public decimal  ? SFOtherFee { get; set; }

      public decimal  ? ZDOtherFee { get; set; }

      public decimal  ? NowPayMoney { get; set; }

      public decimal  ? NowPayBalance { get; set; }

      public decimal  ? MonthPayMoney { get; set; }

      public decimal  ? MonthPayBalance { get; set; }

      public decimal  ? ShortOwePayMoney { get; set; }

      public decimal  ? ShortOwePayBalance { get; set; }

      public decimal  ? FetchPayMoney { get; set; }

      public decimal  ? FetchPayBalance { get; set; }

      public decimal  ? ReceiptPayMoney { get; set; }

      public decimal  ? ReceiptPayBalance { get; set; }

      public decimal  ? OwePayMoney { get; set; }

      public decimal  ? OwePayBalance { get; set; }

      public decimal  ? VerifiBalance { get; set; }

      public decimal  ? VerifiMoney { get; set; }

      public string  FetchPayState { get; set; }

      public string  IsBackNowPayFee { get; set; }

      public string  BackNowPayAduitMan { get; set; }

      public DateTime  ? BackNowPayAduitDate { get; set; }

      public decimal  ? acc12 { get; set; }

      public decimal  ? acc13 { get; set; }

      public decimal  ? DiscountTransferFrist { get; set; }

      public decimal  ? DiscountTransferAdd { get; set; }

      public decimal  ? CollectionPayFrist { get; set; }

      public decimal  ? CollectionPayAdd { get; set; }

      public decimal  ? FreightAmountFrist { get; set; }

      public decimal  ? FreightAmountAdd { get; set; }

      public decimal  ? ActualFreightFrist { get; set; }

      public decimal  ? ActualFreightAdd { get; set; }

      public string  PaymentModeFrist { get; set; }

      public string  isPaymentMode { get; set; }

      public decimal  ? Amounted { get; set; }

      public string  CarNO { get; set; }

      public DateTime  ? CarDate { get; set; }

      public int  ? SumBill { get; set; }

      public decimal  ? SumFetchPay { get; set; }

      public decimal  ? BackFetched { get; set; }

      public decimal  ? BackFetch { get; set; }

      public decimal  ? SumOptFee { get; set; }

      public decimal  ? SumInsureFee { get; set; }

      public decimal  ? SumSendFee { get; set; }

      public decimal  ? SumMiddleFee { get; set; }

      public decimal  ? SumOtherFee { get; set; }

      public decimal  ? departure_profit { get; set; }

      public decimal  ? TotalPay { get; set; }

      public decimal  ? TotalFeeWeight { get; set; }

      public decimal  ? TotalFeeVolume { get; set; }

      public decimal  ? JSAmount { get; set; }

      public DateTime  ? LatestDepartTime { get; set; }

      public decimal  ? Loadmargin { get; set; }

      public decimal  ? latestHours { get; set; }

      public string  DepartStstus { get; set; }

      public string  isTwoDaysStay { get; set; }

      public decimal  ? lateDepartTime { get; set; }

      public decimal  ? lateEndTime { get; set; }

      public string  EndStstus { get; set; }

      public decimal  ? BillMargin { get; set; }

      public string  AccMiddlePay { get; set; }

      public int  ? qkdays { get; set; }

      public int  ? surplusDays { get; set; }

      public decimal  ? MatPay { get; set; }

      public string  ConfirmationState { get; set; }

      public decimal  ? ShareAccMiddlePay { get; set; }

      public string  checkstate { get; set; }

      public decimal  ? VehFare1 { get; set; }

      public decimal  ? SCFee1 { get; set; }

      public decimal  ? AccBigcarTotal1 { get; set; }

      public decimal  ? AccSend1 { get; set; }

      public decimal  ? AccMiddlePay1 { get; set; }

      public decimal  ? MiddleSendFee1 { get; set; }

      public decimal  ? HandFee1 { get; set; }

      public decimal  ? AccSendFee { get; set; }

      public decimal  ? SumOperationWeight { get; set; }

      public int  ? SumCarNum { get; set; }

      public decimal  ? CarTonsCost { get; set; }

      public decimal  ? AverageCarDepartAmount { get; set; }

      public decimal  ? AverageCarCost { get; set; }

      public decimal  ? AverageCarProfit { get; set; }

      public decimal  ? chengbenRate { get; set; }

      public decimal  ? CarCostRate { get; set; }

      public DateTime  ? LocalMiddleDate { get; set; }

      public DateTime  ? TerminalMiddleDate { get; set; }

      public DateTime  ? theInventoryDate { get; set; }

      public decimal  ? FetchChangeFee { get; set; }

      public decimal  ? NotFetchChangeFee { get; set; }

      public decimal  ? MiddleTonsCost { get; set; }

      public decimal  ? MiddleCostRate { get; set; }

      public decimal  ? YesPay { get; set; }

      public decimal  ? NoPay { get; set; }

      public decimal  ? MiddleBalance { get; set; }

      public decimal  ? SendTonsCost { get; set; }

      public decimal  ? SendCostRate { get; set; }

      public decimal  ? FetchTonsCost { get; set; }

      public decimal  ? FetchCostRate { get; set; }

      public decimal  ? sumActualFreight { get; set; }

      public decimal  ? sumjiesuan { get; set; }

      public decimal  ? AccCost { get; set; }

      public decimal  ? AccMargin { get; set; }

      public decimal  ? StartFeeVolume { get; set; }

      public decimal  ? StartFeeWeight { get; set; }

      public decimal  ? StartOperationWeight { get; set; }

      public decimal  ? ArriverFeeWeight { get; set; }

      public decimal  ? ArriverFeeVolume { get; set; }

      public decimal  ? ArriverOperationWeight { get; set; }

      public decimal  ? StationIn { get; set; }

      public decimal  ? StationOut { get; set; }

      public decimal  ? StationProfit { get; set; }

      public decimal  ? AmountMoney { get; set; }

      public decimal  ? SendProfit { get; set; }

      public decimal  ? MiddleProfit { get; set; }

      public decimal  ? TerminalProfit { get; set; }

      public decimal  ? SumMonthPay { get; set; }

      public decimal  ? BeyondMonthPay { get; set; }

      public decimal  ? YDChangeMoney { get; set; }

      public decimal  ? incomeAll { get; set; }

      public decimal  ? SFFeeAll { get; set; }

      public decimal  ? ZDFeeAll { get; set; }

      public decimal  ? GrossProfitLV { get; set; }

      public decimal  ? DepartureOptFeeAll { get; set; }

      public string  YSHXSTATE { get; set; }

      public DateTime  ? CnAduitTime { get; set; }

      public string  MiddleAduitState { get; set; }

      public string  FetchPayVerifState { get; set; }

      public string  TfAduitState { get; set; }

      public string  ISReceiptReturn { get; set; }

      public DateTime  ? ReceiptReturnDate { get; set; }

      public string  confirmType { get; set; }

      public string  ISImport { get; set; }

      public string  payflag { get; set; }

      public string  orderState { get; set; }

      public string  isFetch { get; set; }

      public string  isSend { get; set; }

      public string  sprogramType { get; set; }
 

    }
}
    //----------basOtherName结束----------
    