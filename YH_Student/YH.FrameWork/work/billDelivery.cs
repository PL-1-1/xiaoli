    //----------billDelivery开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDelivery//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  DeliId { get; set; }

      public string  DeliCode { get; set; }

      public string  DeliMan { get; set; }

      public DateTime  ? DeliTime { get; set; }

      public string  DeliVehType { get; set; }

      public string  DeliCusName { get; set; }

      public string  DeliCusPhone { get; set; }

      public string  CarWeb { get; set; }

      public string  GoodsName { get; set; }

      public string  LoadPlace { get; set; }

      public string  ArriveSite { get; set; }

      public string  ContactMan { get; set; }

      public int  ? Num { get; set; }

      public decimal  ? Weight { get; set; }

      public decimal  ? Volume { get; set; }

      public decimal  ? Freight { get; set; }

      public string  Payment { get; set; }

      public decimal  ? CollectFee { get; set; }

      public string  Vehicle { get; set; }

      public DateTime  ? PickGoodsTime { get; set; }

      public string  BearDepart { get; set; }

      public string  DocuAttached { get; set; }

      public string  DeliRemark { get; set; }

      public string  DeliRegMan { get; set; }

      public string  VehicleNum { get; set; }

      public string  DriverName { get; set; }

      public string  DriverPhone { get; set; }

      public DateTime  ? DispatchTime { get; set; }

      public DateTime  ? PreToTime { get; set; }

      public decimal  ? VehFare { get; set; }

      public decimal  ? VehFareLast { get; set; }

      public int  ? VehFareVerifyState { get; set; }

      public string  VerifMan { get; set; }

      public DateTime  ? VerifDate { get; set; }

      public string  ControlWeb { get; set; }

      public string  AcceptDepart { get; set; }

      public string  SettleState { get; set; }

      public string  IsRent { get; set; }

      public string  ControlRemark { get; set; }

      public string  DeliState { get; set; }

      public string  UserCarDepart { get; set; }

      public string  VehicleLength { get; set; }

      public string  VehicleType { get; set; }

      public string  DepartContactMan { get; set; }

      public string  DepartTel { get; set; }

      public string  AcceptMan { get; set; }

      public string  BillNo { get; set; }

      public string  Cooperation { get; set; }

      public string  BatchNo { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public string  smsToDriver { get; set; }

      public string  smsToCustom { get; set; }

      public int  ? IsUnionShort { get; set; }

      public string  VehiclesDemand { get; set; }

      public string  LonAndLat { get; set; }

      public int  ? BillToType { get; set; }

      public string  VehicleWidth { get; set; }

      public string  VehicleHeight { get; set; }

      public string  companyid { get; set; }

      public string  VehicleRequire { get; set; }

      public string  FetchTimer { get; set; }

      public string  PcarType { get; set; }

      public string  DispatchDeliCode { get; set; }

      public string  Province { get; set; }

      public string  City { get; set; }

      public string  Area { get; set; }

      public string  Street { get; set; }

      public DateTime  ? DisDate { get; set; }

      public string  OrderId { get; set; }

      public int  ? IsSendWbps { get; set; }

      public string  paichedepartment { get; set; }

      public decimal  ? basFee { get; set; }

      public int  ? renewNo { get; set; }

      public string  ViceDriverName { get; set; }

      public decimal  ? PayFee { get; set; }

      public decimal  ? BackFee { get; set; }

      public decimal  ? ComeFee { get; set; }

      public decimal  ? OilCardFee { get; set; }

      public decimal  ? AddOilFee { get; set; }

      public string  OilCardNode { get; set; }

      public decimal  ? HopeFee { get; set; }

      public string  TalkResult { get; set; }
 

    }
}
    //----------billDelivery结束----------
    