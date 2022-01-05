    //----------QRTZ_TRIGGERS开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class QRTZ_TRIGGERS//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SCHED_NAME { get; set; }

      public string  TRIGGER_NAME { get; set; }

      public string  TRIGGER_GROUP { get; set; }

      public string  JOB_NAME { get; set; }

      public string  JOB_GROUP { get; set; }

      public string  DESCRIPTION { get; set; }

      public long  ? NEXT_FIRE_TIME { get; set; }

      public long  ? PREV_FIRE_TIME { get; set; }

      public int  ? PRIORITY { get; set; }

      public string  TRIGGER_STATE { get; set; }

      public string  TRIGGER_TYPE { get; set; }

      public long  START_TIME { get; set; }

      public long  ? END_TIME { get; set; }

      public string  CALENDAR_NAME { get; set; }

      public short  ? MISFIRE_INSTR { get; set; }

      public byte[]  JOB_DATA { get; set; }
 

    }
}
    //----------QRTZ_TRIGGERS结束----------
    