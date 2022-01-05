    //----------ScheduleJob开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ScheduleJob//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  JobId { get; set; }

      public string  BeanName { get; set; }

      //public string  params { get; set; }

      public string  CronExpression { get; set; }

      public byte  ? Status { get; set; }

      public string  Remark { get; set; }

      public DateTime  ? CreateTime { get; set; }
 

    }
}
    //----------ScheduleJob结束----------
    