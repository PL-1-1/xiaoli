    //----------billDeparture2018开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDeparture2018//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  ContractNO { get; set; }

      public string  DepartureBatch { get; set; }

      public string  CarNO { get; set; }

      public string  CarrNO { get; set; }

      public string  DriverName { get; set; }

      public string  DriverPhone { get; set; }

      public string  BeginSite { get; set; }

      public string  EndSite { get; set; }

      public DateTime  ? DepartureDate { get; set; }

      public DateTime  ? ExpArriveDate { get; set; }

      public decimal  ? LoadWeight { get; set; }

      public decimal  ? ActWeight { get; set; }

      public decimal  ? LoadVolume { get; set; }

      public decimal  ? ActVolume { get; set; }

      public string  LoadPeoples { get; set; }

      public string  Creator { get; set; }

      public string  BoxNO { get; set; }

      public string  BigCarDescr { get; set; }

      public decimal  ? AccLine { get; set; }

      public string  FecthSite { get; set; }

      public decimal  ? AccBigCarFecth { get; set; }

      public string  FecthBillNO { get; set; }

      public decimal  ? AccBigCarSend { get; set; }

      public string  SendBillNO { get; set; }

      public string  SendAddr { get; set; }

      public decimal  ? AccShtBarge { get; set; }

      public string  ShtBargeDept { get; set; }

      public decimal  ? AccSomeLoad { get; set; }

      public string  UnloadAddr { get; set; }

      public decimal  ? AccBigcarOther { get; set; }

      public string  TakeDept { get; set; }

      public decimal  ? AccBigcarTotal { get; set; }

      public decimal  ? DriverTakePay { get; set; }

      public decimal  ? AccTakeCar { get; set; }

      public decimal  ? AccCollectPremium { get; set; }

      public decimal  ? NowPayDriver { get; set; }

      public decimal  ? ToPayDriver { get; set; }

      public decimal  ? BackPayDriver { get; set; }

      public decimal  ? AccFuelCard { get; set; }

      public string  FuelCardNO { get; set; }

      public string  LoadSite { get; set; }

      public string  LoadWeb { get; set; }

      public int  ? NowPayVerifState { get; set; }

      public string  NowPayVerifMan { get; set; }

      public DateTime  ? NowPayVerifDate { get; set; }

      public decimal  ? AccNowPayVerif { get; set; }

      public int  ? ToPayVerifState { get; set; }

      public string  ToPayVerifMan { get; set; }

      public DateTime  ? ToPayVerifDate { get; set; }

      public decimal  ? AccToPayVerif { get; set; }

      public int  ? BackPayVerifState { get; set; }

      public string  BackPayVerifMan { get; set; }

      public DateTime  ? BackPayVerifDate { get; set; }

      public decimal  ? AccBackPayVerif { get; set; }

      public int  ? FuelCardVerifState { get; set; }

      public string  FuelCardVerifMan { get; set; }

      public DateTime  ? FuelCardVerifDate { get; set; }

      public decimal  ? AccFuelCardVerif { get; set; }

      public string  LoadBusiDept { get; set; }

      public string  LoadArea { get; set; }

      public string  LoadDept { get; set; }

      public decimal  ? AccPremium { get; set; }

      public string  InsuranceNO { get; set; }

      public string  PrintMan { get; set; }

      public DateTime  ? PrintDate { get; set; }

      public int  ? isover { get; set; }

      public DateTime  ? ArrivedDate { get; set; }

      public string  Madeby { get; set; }

      public decimal  ? accdownesite { get; set; }

      public string  LoadingType { get; set; }

      public string  BigcarOtherRemark { get; set; }

      public string  VerifyMan { get; set; }

      public DateTime  ? VerifyDate { get; set; }

      public string  EndWebName { get; set; }

      public decimal  ? OilCardFee { get; set; }

      public string  OilCardNo { get; set; }

      public string  ISArrived { get; set; }

      public string  ArriveOperMan { get; set; }

      public DateTime  ? ArriveOperTime { get; set; }

      public string  ArriveOperWeb { get; set; }

      public int  ? BillToType { get; set; }

      public int  ? JMTFindex { get; set; }

      public string  ReMark { get; set; }

      public int  ? DriverTakePayState { get; set; }

      public string  DriverTakePayMan { get; set; }

      public DateTime  ? DriverTakePayDate { get; set; }

      public decimal  ? DriverTakePayVerif { get; set; }

      public decimal  ? AccPZ { get; set; }

      public string  CarType { get; set; }

      public string  CarLength { get; set; }

      public string  CarWidth { get; set; }

      public string  CarHeight { get; set; }

      public decimal  ? SumOptWeight { get; set; }

      public decimal  ? SumFeeWeight { get; set; }

      public decimal  ? SumFeeVolume { get; set; }

      public DateTime  ? DepDownGoodsTime { get; set; }

      public int  ? SumWebPCS { get; set; }

      public int  ? BillCount { get; set; }

      public int  ? SumNum { get; set; }

      public decimal  ? SumFreight { get; set; }

      public decimal  ? NetWeight { get; set; }

      public string  CarSoure { get; set; }

      public decimal  ? OilFee { get; set; }

      public decimal  ? oilVolume { get; set; }

      public decimal  ? oilPrice { get; set; }

      public int  ? oilCount { get; set; }

      public string  companyid { get; set; }

      public string  IsOperatonFeePay { get; set; }

      public string  IsInsurancePay { get; set; }

      public string  DepartPayAccount { get; set; }

      public int  ? PrintState { get; set; }

      public string  EndWeb { get; set; }

      public string  IsSortFeePay { get; set; }

      public string  IsManagerFeePay { get; set; }

      public int  ? dycs { get; set; }

      public string  CarStartState { get; set; }

      public int  ? RewardPunishVerifState { get; set; }

      public decimal  ? DriRewardPunishMondy { get; set; }

      public string  belongLine { get; set; }

      public string  Provider { get; set; }

      public string  oilCardAccount { get; set; }

      public string  oilCardBank { get; set; }

      public string  oilCardManName { get; set; }

      public string  oilCardProvince { get; set; }

      public string  oilCardCity { get; set; }

      public string  nowPayCity { get; set; }

      public string  nowPayProvince { get; set; }

      public string  bankPayCity { get; set; }

      public string  bankPayProvince { get; set; }

      public string  NowPayAccontName { get; set; }

      public string  NowPayBankName { get; set; }

      public string  NowPayAccountNO { get; set; }

      public string  BackPayAccontName { get; set; }

      public string  BackPayBankName { get; set; }

      public string  BackPayAccountNO { get; set; }

      public DateTime  ? ConfirmTime { get; set; }

      public string  ConfirmMan { get; set; }

      public string  DownGoodsState { get; set; }

      public string  SystemType { get; set; }

      public DateTime  ? OilVerifDate { get; set; }

      public string  OilVerifMan { get; set; }

      public int  ? OilVerifState { get; set; }

      public DateTime  ? RewardPunishVerifDate { get; set; }

      public string  RewardPunishVerifMan { get; set; }

      public string  Descompanyid { get; set; }

      public int  ? IsDepAgain { get; set; }

      public DateTime  ? DepartureDate_New { get; set; }
 

    }
}
    //----------billDeparture2018结束----------
    