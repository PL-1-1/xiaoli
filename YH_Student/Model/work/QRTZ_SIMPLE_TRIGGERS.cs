    //----------QRTZ_SIMPLE_TRIGGERS开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class QRTZ_SIMPLE_TRIGGERS//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SCHED_NAME { get; set; }

      public string  TRIGGER_NAME { get; set; }

      public string  TRIGGER_GROUP { get; set; }

      public long  REPEAT_COUNT { get; set; }

      public long  REPEAT_INTERVAL { get; set; }

      public long  TIMES_TRIGGERED { get; set; }
 

    }
}
    //----------QRTZ_SIMPLE_TRIGGERS结束----------
    