    //----------MonthlyCustIndex开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class MonthlyCustIndex//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  cyear { get; set; }

      public string  cmonth { get; set; }

      public int  ? ccount { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------MonthlyCustIndex结束----------
    