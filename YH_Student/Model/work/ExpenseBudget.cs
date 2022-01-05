    //----------ExpenseBudget开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ExpenseBudget//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  RegisterMan { get; set; }

      public string  RegisterDept { get; set; }

      public DateTime  ? RegisteDate { get; set; }

      public string  BudgetCause { get; set; }

      public string  BudgetArea { get; set; }

      public string  BudgetWeb { get; set; }

      public string  FeeProject { get; set; }

      public string  FeeType { get; set; }

      public string  BelongMonth { get; set; }

      public decimal  ? BudgetMoney { get; set; }

      public decimal  ? BudgetBalance { get; set; }

      public string  ConfirmMan { get; set; }

      public DateTime  ? ConfirmDate { get; set; }

      public string  UnConfirmMan { get; set; }

      public string  UnConfirmDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------ExpenseBudget结束----------
    