    //----------ExpenseAudit开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ExpenseAudit//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ID { get; set; }

      public string  BankMan { get; set; }

      public string  BankAccount { get; set; }

      public string  BankName { get; set; }

      public string  BankSubbranch { get; set; }

      public string  BankProvince { get; set; }

      public string  BankCity { get; set; }

      public string  TransferType { get; set; }

      public string  ExpendType { get; set; }

      public DateTime  ? PayDate { get; set; }

      public string  BankRemark { get; set; }

      public decimal  ? ApplyMoney { get; set; }

      public decimal  ? ExpendMoney { get; set; }

      public string  PayType { get; set; }

      public int  ? AuditState { get; set; }

      public string  AuditMan { get; set; }

      public DateTime  ? AuditDate { get; set; }

      public string  UnAuditMan { get; set; }

      public DateTime  ? UnAuditDate { get; set; }

      public string  FeeType { get; set; }

      public string  Batch { get; set; }

      public string  ApplyCause { get; set; }

      public string  ApplyArea { get; set; }

      public DateTime  ? ConfirmDate { get; set; }

      public string  ApplyDept { get; set; }

      public string  AcceptMan { get; set; }

      public DateTime  ? AcceptDate { get; set; }

      public string  AcceptState { get; set; }

      public string  PushMan { get; set; }

      public DateTime  ? PushDate { get; set; }

      public string  UnPushMan { get; set; }

      public DateTime  ? UnPushDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------ExpenseAudit结束----------
    