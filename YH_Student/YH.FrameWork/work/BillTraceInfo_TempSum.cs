    //----------BillTraceInfo_TempSum开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillTraceInfo_TempSum//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  billno { get; set; }

      public string  tracetype { get; set; }

      public string  optwebname { get; set; }

      public string  content { get; set; }

      public DateTime  ? createdate { get; set; }

      public DateTime  tracedate { get; set; }

      public int  ? num { get; set; }

      public long  Id { get; set; }

      public int  ? sendali { get; set; }
 

    }
}
    //----------BillTraceInfo_TempSum结束----------
    