    //----------vehicleWithold开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class vehicleWithold//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  CarNo { get; set; }

      public string  DriverName { get; set; }

      public string  DriverPhone { get; set; }

      public string  WithholdType { get; set; }

      public decimal  ? WithholdMoney { get; set; }

      public string  CertificateNo { get; set; }

      public string  Remark { get; set; }

      public DateTime  ? OperDate { get; set; }

      public string  State { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public DateTime  ? VerificationDate { get; set; }

      public string  VerificationDept { get; set; }

      public DateTime  ? CancelVerificationDate { get; set; }

      public string  VerificationMan { get; set; }

      public string  CancelVerificationMan { get; set; }

      public string  CancelVerificationDept { get; set; }

      public DateTime  ? ConfirmDate { get; set; }

      public DateTime  ? CancelConfirmDate { get; set; }

      public string  ConfirmDept { get; set; }

      public string  ConfirmMan { get; set; }

      public string  CancelConfirmDept { get; set; }

      public string  CancelConfirmMan { get; set; }

      public string  RegisterMan { get; set; }

      public string  WebName { get; set; }

      public string  RefundAccountName { get; set; }

      public string  AccountNO { get; set; }

      public string  BankName { get; set; }

      public string  VehicleUse { get; set; }

      public DateTime  ? oilDate { get; set; }

      public string  belongMonth { get; set; }

      public decimal  ? verifyMoney { get; set; }

      public decimal  ? unVerifyMoney { get; set; }

      public string  useFee { get; set; }

      public string  Province { get; set; }

      public string  City { get; set; }

      public DateTime  ? BusinessDate { get; set; }
 

    }
}
    //----------vehicleWithold结束----------
    