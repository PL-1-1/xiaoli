    //----------billCustQuerrylog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billCustQuerrylog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  Qid { get; set; }

      public DateTime  ? QDate { get; set; }

      public string  QCustCompany { get; set; }

      public string  QCustPhone { get; set; }

      public string  QType { get; set; }

      public string  QResult { get; set; }

      public string  QContent { get; set; }

      public string  QAnswerContent { get; set; }

      public string  QCustServiceMan { get; set; }

      public string  BillNO { get; set; }

      public string  ComplainDep { get; set; }

      public string  ComplainType { get; set; }

      public string  DealMan { get; set; }

      public string  ResponWeb1 { get; set; }

      public string  ResponMan1 { get; set; }

      public decimal  ? Fines1 { get; set; }

      public string  ResponWeb2 { get; set; }

      public string  ResponMan2 { get; set; }

      public decimal  ? Fines2 { get; set; }

      public string  ResponWeb3 { get; set; }

      public string  ResponMan3 { get; set; }

      public decimal  ? Fines3 { get; set; }

      public string  ResponDivideMan { get; set; }

      public string  ResponDivideDate { get; set; }

      public string  ComplainLevel { get; set; }

      public string  ComplainArea { get; set; }

      public string  ComplainCause { get; set; }

      public string  IsQCust { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billCustQuerrylog结束----------
    