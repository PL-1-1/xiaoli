    //----------billMiddleTrace开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billMiddleTrace//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  TraceId { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? TraceDate { get; set; }

      public string  TraceContent { get; set; }

      public string  TraceMan { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billMiddleTrace结束----------
    