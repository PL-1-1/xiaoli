    //----------QRTZ_SCHEDULER_STATE开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class QRTZ_SCHEDULER_STATE//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SCHED_NAME { get; set; }

      public string  INSTANCE_NAME { get; set; }

      public long  LAST_CHECKIN_TIME { get; set; }

      public long  CHECKIN_INTERVAL { get; set; }
 

    }
}
    //----------QRTZ_SCHEDULER_STATE结束----------
    