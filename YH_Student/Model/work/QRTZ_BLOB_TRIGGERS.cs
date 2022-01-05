    //----------QRTZ_BLOB_TRIGGERS开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class QRTZ_BLOB_TRIGGERS//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SCHED_NAME { get; set; }

      public string  TRIGGER_NAME { get; set; }

      public string  TRIGGER_GROUP { get; set; }

      public byte[]  BLOB_DATA { get; set; }
 

    }
}
    //----------QRTZ_BLOB_TRIGGERS结束----------
    