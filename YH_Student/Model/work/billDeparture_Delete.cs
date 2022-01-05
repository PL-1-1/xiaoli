    //----------billDeparture_Delete开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDeparture_Delete//可以在这里加上基类等
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

      public string  companyid { get; set; }
 

    }
}
    //----------billDeparture_Delete结束----------
    