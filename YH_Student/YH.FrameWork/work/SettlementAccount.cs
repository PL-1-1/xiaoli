    //----------SettlementAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SettlementAccount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SettlementID { get; set; }

      public int  ? CauseAccount { get; set; }

      public string  CauseName { get; set; }

      public string  BankName { get; set; }

      public string  BankAccount { get; set; }

      public string  BankAccountName { get; set; }

      public string  BankAddress { get; set; }

      public double  ? SettlementBalance { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------SettlementAccount结束----------
    