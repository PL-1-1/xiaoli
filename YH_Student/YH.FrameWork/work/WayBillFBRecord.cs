    //----------WayBillFBRecord开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillFBRecord//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  BillNo { get; set; }

      public int  BillState { get; set; }

      public int  ? LeftNum { get; set; }

      public string  AllocateBatch { get; set; }
 

    }
}
    //----------WayBillFBRecord结束----------
    