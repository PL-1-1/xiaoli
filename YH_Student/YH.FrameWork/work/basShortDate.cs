    //----------basShortDate开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basShortDate//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ShortId { get; set; }

      public string  ShortSite { get; set; }

      public string  ShortWeb { get; set; }

      public double  ? ShortTime { get; set; }

      public string  ShortEsite { get; set; }

      public string  ShortEweb { get; set; }

      public string  ShortModels { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basShortDate结束----------
    