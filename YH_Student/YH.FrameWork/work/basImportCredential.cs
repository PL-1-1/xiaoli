    //----------basImportCredential开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basImportCredential//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ImportCredentialID { get; set; }

      public string  SourceNo { get; set; }

      public string  BusinessProject { get; set; }

      public string  BillNo { get; set; }

      public string  CredentialFont { get; set; }

      public DateTime  ? CredentialDate { get; set; }

      public string  SubjectID { get; set; }

      public string  SubjectName { get; set; }

      public decimal  ? BorrowMoney { get; set; }

      public decimal  ? CreditMoney { get; set; }

      public string  AccountProjectNo { get; set; }

      public string  AccountProjectName { get; set; }

      public string  AccountWebNo { get; set; }

      public string  CredentialWebName { get; set; }

      public string  Abstract { get; set; }

      public string  AuditMan { get; set; }

      public DateTime  ? AuditDate { get; set; }

      public string  ImportMan { get; set; }

      public DateTime  ? ImportDate { get; set; }

      public string  JDCredential { get; set; }

      public string  companyid { get; set; }

      public DateTime  ? GenerateDate { get; set; }
 

    }
}
    //----------basImportCredential结束----------
    