    //----------WayBillPlusMonth开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillPlusMonth//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillNo { get; set; }

      public int  ? NowPayVerifState { get; set; }

      public decimal  ? NowPayVerifBalance { get; set; }

      public string  NowPayVerifMan { get; set; }

      public DateTime  ? NowPayVerifTime { get; set; }

      public int  ? FetchPayVerifState { get; set; }

      public decimal  ? FetchPayVerifBalance { get; set; }

      public string  FetchPayVerifMan { get; set; }

      public DateTime  ? FetchPayVerifTime { get; set; }

      public int  ? MonthPayVerifState { get; set; }

      public decimal  ? MonthPayVerifBalance { get; set; }

      public string  MonthPayVerifMan { get; set; }

      public DateTime  ? MonthPayVerifTime { get; set; }

      public int  ? BefArrivalPayVerifState { get; set; }

      public decimal  ? BefArrivalPayVerifBalance { get; set; }

      public string  BefArrivalPayVerifMan { get; set; }

      public DateTime  ? BefArrivalPayVerifTime { get; set; }

      public int  ? DisTranVerifState { get; set; }

      public decimal  ? DisTranVerifBalance { get; set; }

      public string  DisTranVerifMan { get; set; }

      public DateTime  ? DisTranVerifTime { get; set; }

      public int  ? ShortOwePayVerifState { get; set; }

      public decimal  ? ShortOwePayVerifBalance { get; set; }

      public string  ShortOwePayVerifMan { get; set; }

      public DateTime  ? ShortOwePayVerifTime { get; set; }

      public decimal  ? ArrComfirmBalance { get; set; }

      public string  ArrComBedMan { get; set; }

      public string  ArrComBedWeb { get; set; }

      public string  ArrComBedSite { get; set; }

      public string  ArrComBedArea { get; set; }

      public string  ArrComBedCause { get; set; }

      public DateTime  ? ArrComBedTime { get; set; }

      public string  ArrComBedState { get; set; }

      public string  ArrComBedOutMan { get; set; }

      public string  ArrComBedOutTime { get; set; }

      public string  ArrComBedOutWeb { get; set; }

      public string  ArrComBedAduitWeb { get; set; }

      public string  ArrComBedAduitMan { get; set; }

      public DateTime  ? ArrComBedAduitTime { get; set; }

      public int  ? CollectionPayBackState { get; set; }

      public string  CollectionPayBackMan { get; set; }

      public DateTime  ? CollectionPayBackDate { get; set; }

      public int  ? CollectionPayPostState { get; set; }

      public string  CollectionPayPostMan { get; set; }

      public DateTime  ? CollectionPayPostDate { get; set; }

      public DateTime  ? MiddleOperDate { get; set; }

      public int  ? IsBackFetchFee { get; set; }

      public int  ? IsBackDeliveryFee { get; set; }

      public int  ? IsBackDepartureOptFee { get; set; }

      public int  ? IsTerminalOptFee { get; set; }

      public string  OutWeb { get; set; }

      public DateTime  ? OutTime { get; set; }

      public string  OutMan { get; set; }

      public string  OutCause { get; set; }

      public string  OutArea { get; set; }

      public string  BackFetchAdutMan { get; set; }

      public DateTime  ? BackFetchAdutDate { get; set; }

      public DateTime  ? BackDeliveryFeeDate { get; set; }

      public string  BackDeliveryFeeMan { get; set; }

      public string  BackDeliveryFeeDep { get; set; }

      public double  ? BackDeliveryFeeRate { get; set; }

      public double  ? DeliveryFee_S { get; set; }

      public double  ? DeliveryFee_D { get; set; }

      public string  SignType { get; set; }

      public int  ? IsBackTransferFee { get; set; }

      public DateTime  ? BackTransferFeeDate { get; set; }

      public string  BackTransferFeeMan { get; set; }

      public string  BackTransferFeeDep { get; set; }

      public double  ? BackTransferFeeRate { get; set; }

      public double  ? TransferFee_S { get; set; }

      public double  ? TransferFee_D { get; set; }

      public int  ? FenBoFeeAduitState { get; set; }

      public string  FenBoFeeAduitMan { get; set; }

      public DateTime  ? FenBoFeeAduitTime { get; set; }

      public decimal  ? DeliveryFee_C { get; set; }

      public int  ? DeliveryFee_CState { get; set; }

      public string  DeliveryFee_CMan { get; set; }

      public DateTime  ? DeliveryFee_CDate { get; set; }

      public string  DeliveryFee_CWeb { get; set; }

      public int  ? ZDFetchPayVerifState { get; set; }

      public decimal  ? ZDFetchPayVerifBalance { get; set; }

      public string  ZDFetchPayVerifMan { get; set; }

      public DateTime  ? ZDFetchPayVerifTime { get; set; }

      public string  companyid { get; set; }

      public decimal  ? CollectionPayVerifBalance { get; set; }

      public int  ? IsBackNowPayFee { get; set; }

      public string  BackNowPayAduitMan { get; set; }

      public DateTime  ? BackNowPayAduitDate { get; set; }
 

    }
}
    //----------WayBillPlusMonth结束----------
    