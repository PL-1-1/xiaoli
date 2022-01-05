    //----------BI_GroupSummary_Company开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BI_GroupSummary_Company//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ? billcount { get; set; }

      public decimal  ? PaymentAmout { get; set; }

      public string  CompanyName { get; set; }
 

    }
}
    //----------BI_GroupSummary_Company结束----------
    