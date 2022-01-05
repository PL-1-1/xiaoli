    //----------BillVehicleStar开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillVehicleStar//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  Type { get; set; }

      public string  BatchNO { get; set; }

      public string  VehicleNO { get; set; }

      public string  Driver { get; set; }

      public string  DriverPhone { get; set; }

      public DateTime  ? StartTime { get; set; }

      public string  StartSite { get; set; }

      public string  StartWeb { get; set; }

      public string  ArriveSite { get; set; }

      public string  ArriveWeb { get; set; }

      public string  BillMan { get; set; }

      public DateTime  ? EstArriveTime { get; set; }

      public DateTime  ? LastStartTime { get; set; }

      public string  ISArrived { get; set; }

      public string  ArriveOperMan { get; set; }

      public string  ArriveOperTime { get; set; }

      public string  ArriveOperWeb { get; set; }

      public int  ? IsCancel { get; set; }

      public string  vehiclestarMan { get; set; }

      public string  CarStartType { get; set; }

      public string  companyid { get; set; }

      public string  DelayCause { get; set; }

      public string  StartResource { get; set; }

      public string  SendCarPhone { get; set; }

      public string  SendCarShift { get; set; }

      public DateTime  ? AppCardTime { get; set; }

      public string  endLongitude { get; set; }

      public string  endLatitude { get; set; }
 

    }
}
    //----------BillVehicleStar结束----------
    