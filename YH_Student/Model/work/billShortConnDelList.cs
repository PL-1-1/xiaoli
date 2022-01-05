    //----------billShortConnDelList开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billShortConnDelList//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  billno { get; set; }

      public string  shortBatch { get; set; }

      public string  scdState { get; set; }

      public string  cancelMan { get; set; }

      public DateTime  ? cancelDate { get; set; }

      public string  cancelSite { get; set; }

      public string  cancelWeb { get; set; }

      public string  cancelCause { get; set; }

      public string  cancelArea { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billShortConnDelList结束----------
    