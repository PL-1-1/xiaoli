    //----------QRTZ_SIMPROP_TRIGGERS开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class QRTZ_SIMPROP_TRIGGERS//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SCHED_NAME { get; set; }

      public string  TRIGGER_NAME { get; set; }

      public string  TRIGGER_GROUP { get; set; }

      public string  STR_PROP_1 { get; set; }

      public string  STR_PROP_2 { get; set; }

      public string  STR_PROP_3 { get; set; }

      public int  ? INT_PROP_1 { get; set; }

      public int  ? INT_PROP_2 { get; set; }

      public long  ? LONG_PROP_1 { get; set; }

      public long  ? LONG_PROP_2 { get; set; }

      public decimal  ? DEC_PROP_1 { get; set; }

      public decimal  ? DEC_PROP_2 { get; set; }

      public string  BOOL_PROP_1 { get; set; }

      public string  BOOL_PROP_2 { get; set; }
 

    }
}
    //----------QRTZ_SIMPROP_TRIGGERS结束----------
    