    //----------record_of_withdrawals开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class record_of_withdrawals//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ? id { get; set; }

      public string  orderno { get; set; }

      public decimal  ? totalAmount { get; set; }

      public decimal  ? AmountOfCash { get; set; }

      public DateTime  ? operationDate { get; set; }
 

    }
}
    //----------record_of_withdrawals结束----------
    