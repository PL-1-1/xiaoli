    //----------QRTZ_FIRED_TRIGGERS开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class QRTZ_FIRED_TRIGGERS//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SCHED_NAME { get; set; }

      public string  ENTRY_ID { get; set; }

      public string  TRIGGER_NAME { get; set; }

      public string  TRIGGER_GROUP { get; set; }

      public string  INSTANCE_NAME { get; set; }

      public long  FIRED_TIME { get; set; }

      public long  SCHED_TIME { get; set; }

      public int  PRIORITY { get; set; }

      public string  STATE { get; set; }

      public string  JOB_NAME { get; set; }

      public string  JOB_GROUP { get; set; }

      public string  IS_NONCONCURRENT { get; set; }

      public string  REQUESTS_RECOVERY { get; set; }
 

    }
}
    //----------QRTZ_FIRED_TRIGGERS结束----------
    