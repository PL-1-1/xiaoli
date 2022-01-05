    //----------TransferWhite开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class TransferWhite//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  rcompanycode { get; set; }

      public string  rcompanyname { get; set; }

      public string  raccountname { get; set; }

      public string  rbankaccount { get; set; }

      public DateTime  updatedate { get; set; }

      public string  updateman { get; set; }
 

    }
}
    //----------TransferWhite结束----------
    