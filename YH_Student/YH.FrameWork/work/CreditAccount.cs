    //----------CreditAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class CreditAccount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  CreditAccountID { get; set; }

      public string  AccountNo { get; set; }

      public string  AccountName { get; set; }

      public string  AccountType { get; set; }

      public int  ? CreditLimit { get; set; }

      public DateTime  ? StartTime { get; set; }

      public DateTime  ? EndTime { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------CreditAccount结束----------
    