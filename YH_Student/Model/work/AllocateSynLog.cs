    //----------AllocateSynLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class AllocateSynLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  BillNo { get; set; }

      public string  Batch { get; set; }

      public string  ErrorNode { get; set; }

      public string  ExceptMessage { get; set; }

      public DateTime  ? ErrorTime { get; set; }

      public string  ErrorJson { get; set; }
 

    }
}
    //----------AllocateSynLog结束----------
    