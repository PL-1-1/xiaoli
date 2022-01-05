    //----------basBankAudit开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basBankAudit//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  Aid { get; set; }

      public DateTime  ? VerifyDate { get; set; }

      public string  VerifyMan { get; set; }

      public string  VerifyDep { get; set; }

      public string  VerifyBatch { get; set; }

      public string  BankMan { get; set; }

      public string  BankCode { get; set; }

      public string  BankName { get; set; }

      public string  BanKid { get; set; }

      public string  Province { get; set; }

      public string  City { get; set; }

      public string  FeeType { get; set; }

      public decimal  ? Money { get; set; }

      public string  Project { get; set; }

      public string  VerifyState { get; set; }

      public string  Remark { get; set; }

      public DateTime  ? ConfirmDate { get; set; }

      public string  BelongCause { get; set; }

      public string  BelongArea { get; set; }

      public string  WebName { get; set; }

      public DateTime  ? appdate { get; set; }

      public string  SerialNumber { get; set; }
 

    }
}
    //----------basBankAudit结束----------
    