    //----------QRTZ_JOB_DETAILS开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class QRTZ_JOB_DETAILS//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SCHED_NAME { get; set; }

      public string  JOB_NAME { get; set; }

      public string  JOB_GROUP { get; set; }

      public string  DESCRIPTION { get; set; }

      public string  JOB_CLASS_NAME { get; set; }

      public string  IS_DURABLE { get; set; }

      public string  IS_NONCONCURRENT { get; set; }

      public string  IS_UPDATE_DATA { get; set; }

      public string  REQUESTS_RECOVERY { get; set; }

      public byte[]  JOB_DATA { get; set; }
 

    }
}
    //----------QRTZ_JOB_DETAILS结束----------
    