    //----------basWebName_Refund开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basWebName_Refund//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  WebName { get; set; }

      public string  BelongArea { get; set; }

      public string  BelongCause { get; set; }

      public string  TransferMode { get; set; }

      public decimal  ? RefundRatio_songhuo { get; set; }

      public decimal  ? RefundRatio_zhongzhuan { get; set; }

      public decimal  ? RefundRatio_fujia { get; set; }

      public int  AID { get; set; }
 

    }
}
    //----------basWebName_Refund结束----------
    