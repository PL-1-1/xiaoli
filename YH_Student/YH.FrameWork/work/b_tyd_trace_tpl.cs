    //----------b_tyd_trace_tpl开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_tyd_trace_tpl//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public DateTime  ? dtsenddate { get; set; }

      public string  dtvehicleno { get; set; }

      public string  dtchauffer { get; set; }

      public string  dtmadeby { get; set; }

      public string  dtinoneflag { get; set; }

      public string  dttosite { get; set; }

      public string  dttowebid { get; set; }

      public string  unit { get; set; }
 

    }
}
    //----------b_tyd_trace_tpl结束----------
    