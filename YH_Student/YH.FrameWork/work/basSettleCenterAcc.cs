    //----------basSettleCenterAcc开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basSettleCenterAcc//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  AccountNO { get; set; }

      public string  AccountName { get; set; }

      public string  AccountType { get; set; }

      public decimal  ? AccountBalance { get; set; }

      public string  BankName { get; set; }

      public string  BankAccountName { get; set; }

      public string  BankAccountNO { get; set; }

      public decimal  ? AccountReserved { get; set; }

      public double  ? NegwarnValue { get; set; }

      public double  ? LoanWarnValue { get; set; }

      public double  ? CreditLimit { get; set; }

      public double  ? UsingCredit { get; set; }

      public double  ? LeftCredit { get; set; }

      public DateTime  ? StartTime { get; set; }

      public DateTime  ? EndTime { get; set; }

      public double  ? AdjustLimit { get; set; }

      public string  IsEnable { get; set; }

      public string  Accountelephone { get; set; }

      public string  companyid { get; set; }

      public decimal  ? UpPayRatio { get; set; }

      public decimal  ? ZXPayRatio { get; set; }

      public decimal  ? JCPayRatio { get; set; }

      public decimal  ? CCPayRatio { get; set; }

      public decimal  ? ChaChePayRatio { get; set; }

      public decimal  ? KHPayRatio { get; set; }

      public decimal  ? SendPayRatio { get; set; }

      public decimal  ? MiddlePayRatio { get; set; }

      public decimal  ? GiveBalance { get; set; }

      public decimal  ? SumBalance { get; set; }
 

    }
}
    //----------basSettleCenterAcc结束----------
    