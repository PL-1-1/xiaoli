    //----------basLongDate开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basLongDate//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  LongId { get; set; }

      public string  LongSite { get; set; }

      public double  ? LongTime { get; set; }

      public string  LongEsite { get; set; }

      public string  LongModels { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basLongDate结束----------
    