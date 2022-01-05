    //----------BillWithdrawCashApply开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillWithdrawCashApply//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public DateTime  ? ApplyDate { get; set; }

      public string  SerialNO { get; set; }

      public string  AccountNO { get; set; }

      public string  AccountName { get; set; }

      public decimal  ? AccountBalance { get; set; }

      public decimal  ? AccountReserved { get; set; }

      public decimal  ? CanCashQuota { get; set; }

      public decimal  ? ApplyQuota { get; set; }

      public string  BankName { get; set; }

      public string  BankAccount { get; set; }

      public string  BankSubbranch { get; set; }

      public string  BankAccountName { get; set; }

      public string  Remark { get; set; }

      public string  ApplyState { get; set; }

      public string  ApplyMan { get; set; }

      public string  VetoMan { get; set; }

      public DateTime  ? VetoDate { get; set; }

      public string  AuditingMan { get; set; }

      public DateTime  ? AuditingDate { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  WebName { get; set; }

      public string  SiteName { get; set; }

      public string  ExecuteMan { get; set; }

      public DateTime  ? ExecuteDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------BillWithdrawCashApply结束----------
    