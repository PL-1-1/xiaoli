    //----------SyncData开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SyncData//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  syncid { get; set; }

      public long  sqlnum { get; set; }

      public string  sqltext { get; set; }

      public int  sqlstatus { get; set; }

      public string  sqlerrer { get; set; }

      public string  billno { get; set; }

      public int  execType { get; set; }
 

    }
}
    //----------SyncData结束----------
    