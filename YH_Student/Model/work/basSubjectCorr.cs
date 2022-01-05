    //----------basSubjectCorr开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basSubjectCorr//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ID { get; set; }

      public string  xm { get; set; }

      public string  km1 { get; set; }

      public string  km2 { get; set; }

      public string  km3 { get; set; }

      public string  km4 { get; set; }

      public string  companyid { get; set; }

      public string  BusinessModule { get; set; }

      public string  BusinessProject { get; set; }

      public string  CredentialFont { get; set; }

      public string  BorrowSubjectID { get; set; }

      public string  BorrowSubjectName { get; set; }

      public string  BorrowAccountProject { get; set; }

      public string  BorrowAccountProjectSay { get; set; }

      public string  BorrowRemark { get; set; }

      public string  CreditSubjectID { get; set; }

      public string  CreditSubjectName { get; set; }

      public string  CreditAccountProject { get; set; }

      public string  CreditAccountProjectSay { get; set; }

      public string  CreditRemark { get; set; }
 

    }
}
    //----------basSubjectCorr结束----------
    