    //----------ReBuildIndexLog_20191128开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ReBuildIndexLog_20191128//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  DatabaseName { get; set; }

      public string  SchemaNam { get; set; }

      public string  TableName { get; set; }

      public string  IndexName { get; set; }

      public string  IndexType { get; set; }

      public string  IndexColums { get; set; }

      public int  ? DuringTime { get; set; }

      public decimal  ? Before_avg_fragmentation_in_percent { get; set; }

      public decimal  ? After_avg_fragmentation_in_percent { get; set; }
 

    }
}
    //----------ReBuildIndexLog_20191128结束----------
    