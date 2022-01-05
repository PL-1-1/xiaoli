    //----------basTransferCode开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basTransferCode//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillNos { get; set; }

      public string  TransferCode { get; set; }

      public string  Remark { get; set; }

      public DateTime  CreateTime { get; set; }

      public int  CodeType { get; set; }

      public Guid  ID { get; set; }
 

    }
}
    //----------basTransferCode结束----------
    