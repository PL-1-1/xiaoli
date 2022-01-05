    //----------trunkPlanDelivery开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class trunkPlanDelivery//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  DeliCode { get; set; }

      public string  DeliVehType { get; set; }

      public string  cmbAssignObjects { get; set; }

      public DateTime  ? DeliTime { get; set; }

      public string  DeliSite { get; set; }

      public string  Prescription { get; set; }

      public DateTime  ? LoadingTime { get; set; }

      public string  DeliWeb { get; set; }

      public string  GoodsName { get; set; }

      public int  ? Num { get; set; }

      public decimal  ? Weight { get; set; }

      public decimal  ? Volume { get; set; }

      public string  CarType { get; set; }

      public string  CarLength { get; set; }

      public decimal  ? ExpectedFreight { get; set; }

      public string  state { get; set; }

      public string  OrderId { get; set; }

      public decimal  ? basFee { get; set; }

      public string  RenewNo { get; set; }

      public string  vehicleNum { get; set; }

      public string  DriverName { get; set; }

      public string  DriverPhone { get; set; }

      public DateTime  ? DispatchTime { get; set; }

      public DateTime  ? PreToTIme { get; set; }

      public decimal  ? VehFare { get; set; }

      public string  AcceptDepart { get; set; }

      public string  IsRent { get; set; }

      public string  Remark { get; set; }

      public string  AcceptMan { get; set; }

      public string  Cooperation { get; set; }

      public string  ViceDriverName { get; set; }

      public string  Paichedepartment { get; set; }

      public decimal  ? PayFee { get; set; }

      public decimal  ? BackFee { get; set; }

      public decimal  ? ComeFee { get; set; }

      public decimal  ? OilCardFee { get; set; }

      public decimal  ? AddOilFee { get; set; }

      public string  OilCardNode { get; set; }

      public string  TalkResult { get; set; }

      public string  ApplyUserName { get; set; }

      public string  SettlementMode { get; set; }

      public string  LoadRemark { get; set; }

      public string  ControlWeb { get; set; }

      public string  smsToDriver { get; set; }

      public string  smsToCustom { get; set; }

      public string  SiteName { get; set; }

      public string  AreaName { get; set; }

      public string  CauseName { get; set; }

      public string  WebName { get; set; }

      public string  VehicleWidth { get; set; }

      public string  VehicleHeight { get; set; }

      public int  ? IsSendWbps { get; set; }

      public string  ControlRemark { get; set; }

      public string  UserCarDepart { get; set; }

      public string  Remarks { get; set; }

      public decimal  ? oliAmount { get; set; }

      public string  LoadingNo { get; set; }

      public string  vehicleHookName { get; set; }

      public string  carrNo { get; set; }

      public string  IsVehicleHook { get; set; }
 

    }
}
    //----------trunkPlanDelivery结束----------
    