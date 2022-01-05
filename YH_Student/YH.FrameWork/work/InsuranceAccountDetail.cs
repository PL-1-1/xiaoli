    //----------InsuranceAccountDetail开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class InsuranceAccountDetail//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  GSQC { get; set; }

      public string  GSJC { get; set; }

      public int  ? AccountID { get; set; }

      public string  BegWeb { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? BillDate { get; set; }

      public decimal  ? DeclareValue { get; set; }

      public decimal  ? Money { get; set; }

      public DateTime  ? ChangeDate { get; set; }

      public decimal  ? BeforeBalance { get; set; }

      public decimal  ? AfterBalance { get; set; }

      public string  Type { get; set; }

      public string  FeeType { get; set; }

      public string  DeductionMan { get; set; }

      public string  merOrderId { get; set; }

      public int  ? ApplyState { get; set; }

      public string  AuditMan { get; set; }

      public DateTime  ? AuditDate { get; set; }
 

    }
}
    //----------InsuranceAccountDetail结束----------
    