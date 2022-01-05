    //----------CustomerInformation开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class CustomerInformation//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? id { get; set; }

      public string  ShortName { get; set; }

      public DateTime  ? BillDate { get; set; }

      public int  ? CreditDays { get; set; }

      public int  ? qkdays { get; set; }

      public int  ? surplusDays { get; set; }

      public string  MonthWebName { get; set; }

      public decimal  ? LeftCredit { get; set; }

      public int  ? MonthlyDelayDays { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------CustomerInformation结束----------
    