    //----------BillOtherFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillOtherFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  OID { get; set; }

      public string  BillNo { get; set; }

      public string  OtherState { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public DateTime  ? SignDate { get; set; }

      public string  SignMan { get; set; }

      public DateTime  ? AuditDate { get; set; }

      public string  AuditMan { get; set; }

      public string  Project { get; set; }

      public decimal  ? Amount { get; set; }

      public decimal  ? AmountBalance { get; set; }

      public string  Discharger { get; set; }

      public string  DischargerPhone { get; set; }

      public string  ReMark { get; set; }

      public int  ? AuditState { get; set; }

      public int  ? HandNum { get; set; }

      public string  TSendBatch { get; set; }

      public string  companyid { get; set; }

      public string  CarNo { get; set; }

      public string  DriverName { get; set; }

      public string  DriverPhone { get; set; }
 

    }
}
    //----------BillOtherFee结束----------
    