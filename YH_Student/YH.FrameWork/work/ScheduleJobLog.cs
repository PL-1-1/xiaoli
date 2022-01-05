    //----------ScheduleJobLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ScheduleJobLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  LogId { get; set; }

      public long  JobId { get; set; }

      public string  BeanName { get; set; }

      public string  Params { get; set; }

      public byte  Status { get; set; }

      public string  Error { get; set; }

      public int  Times { get; set; }

      public DateTime  ? CreateTime { get; set; }
 

    }
}
    //----------ScheduleJobLog结束----------
    