    //----------InternalTransactionList开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class InternalTransactionList//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  SerialNumber { get; set; }

      public string  ReportNumber { get; set; }

      public string  BearSubject { get; set; }

      public string  BearDep { get; set; }

      public string  BenefitSubject { get; set; }

      public string  BenefitDep { get; set; }

      public string  Period { get; set; }

      public decimal  ? Amount { get; set; }

      public string  InsideType { get; set; }

      public string  UploadMen { get; set; }

      public DateTime  ? UploadDate { get; set; }

      public string  BearSubjectAuditDep { get; set; }

      public string  BearSubjectAuditMen { get; set; }

      public DateTime  ? BearSubjectAuditDate { get; set; }

      public string  BenefitSubjectAuditDep { get; set; }

      public string  BenefitSubjectAuditMen { get; set; }

      public DateTime  ? BenefitSubjectAuditDate { get; set; }

      public string  SuperCounterDep { get; set; }

      public string  SuperCounterAuditor { get; set; }

      public DateTime  ? SuperCounterDate { get; set; }

      public string  AuditStatus { get; set; }

      public string  Remark { get; set; }

      public int  ? CompanyId { get; set; }
 

    }
}
    //----------InternalTransactionList结束----------
    