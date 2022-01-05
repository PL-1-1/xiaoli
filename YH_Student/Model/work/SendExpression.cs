    //----------SendExpression开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SendExpression//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ExpressionId { get; set; }

      public decimal  ? w1 { get; set; }

      public decimal  ? w2 { get; set; }

      public string  Expression { get; set; }

      public string  ExpressionName { get; set; }

      public string  FeeType { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------SendExpression结束----------
    