    //----------WithHolding开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WithHolding//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillNo { get; set; }

      public DateTime  ? RecordDate { get; set; }

      public string  SignMan { get; set; }

      public string  Item { get; set; }

      public string  FeeType { get; set; }

      public string  FeeMonth { get; set; }

      public string  Remark { get; set; }

      public decimal  ? Money { get; set; }

      public string  ResponsibleDepartment { get; set; }

      public string  RevenueDepartement { get; set; }

      public string  Auditor { get; set; }

      public DateTime  ? AuditTime { get; set; }

      public string  Status { get; set; }

      public string  Executor { get; set; }

      public DateTime  ? ExecutorTime { get; set; }

      public string  VetoPerson { get; set; }

      public DateTime  ? VetoTime { get; set; }

      public string  DJDepartment { get; set; }

      public Guid  ID { get; set; }

      public string  UnAuditMan { get; set; }

      public DateTime  ? UnAuditDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------WithHolding结束----------
    