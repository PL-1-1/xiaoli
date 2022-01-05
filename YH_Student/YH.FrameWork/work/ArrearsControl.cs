    //----------ArrearsControl开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ArrearsControl//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ArrearsControlId { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public string  WebResponsiblePerson { get; set; }

      public int  ? BefArrivalPayState { get; set; }

      public int  ? OwePayState { get; set; }

      public int  ? ReceiptPayState { get; set; }

      public int  ? OpenState { get; set; }

      public decimal  ? ArrearsAmount { get; set; }

      public int  ? ArrearsControlDate { get; set; }
 

    }
}
    //----------ArrearsControl结束----------
    