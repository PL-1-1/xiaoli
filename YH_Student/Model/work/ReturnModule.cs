    //----------ReturnModule开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ReturnModule//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  Billno { get; set; }

      public int  ? BillState { get; set; }

      public DateTime  ? Billdate { get; set; }

      public string  ApplicationContent { get; set; }

      public DateTime  ? ApplicationDate { get; set; }

      public string  EndSite { get; set; }

      public string  BegWeb { get; set; }

      public string  Applicant { get; set; }

      public string  CauseOfReturn { get; set; }

      public string  ReturnType { get; set; }

      public string  ReturnNo { get; set; }

      public string  StartSite { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  PickGoodsSite { get; set; }

      public DateTime  ? AuditDate { get; set; }

      public string  AuditMan { get; set; }

      public string  Approver { get; set; }

      public DateTime  ? ApproverDate { get; set; }

      public string  ApprovalNote { get; set; }

      public DateTime  ? ExecutionDate { get; set; }

      public string  ExecutionMan { get; set; }

      public string  ExecutionNote { get; set; }

      public string  Cancelling { get; set; }

      public DateTime  ? CancellationDate { get; set; }

      public string  Vetoed { get; set; }

      public DateTime  ? VetoedDate { get; set; }

      public string  VetoedNote { get; set; }

      public string  State { get; set; }

      public string  ConsignorName { get; set; }

      public string  ConsignorCellPhone { get; set; }

      public string  ConsignorCompany { get; set; }

      public string  PaymentMode { get; set; }

      public decimal  ? PaymentAmout { get; set; }

      public string  ApplicationWeb { get; set; }

      public string  CauseType { get; set; }

      public string  ReceivingDepartment { get; set; }

      public string  companyid { get; set; }

      public string  ReturnDirection { get; set; }
 

    }
}
    //----------ReturnModule结束----------
    