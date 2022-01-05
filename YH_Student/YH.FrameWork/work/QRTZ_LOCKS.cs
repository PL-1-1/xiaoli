    //----------QRTZ_LOCKS开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class QRTZ_LOCKS//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SCHED_NAME { get; set; }

      public string  LOCK_NAME { get; set; }
 

    }
}
    //----------QRTZ_LOCKS结束----------
    