    //----------basSmsTel开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basSmsTel//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  InfoId { get; set; }

      public string  site { get; set; }

      public string  project { get; set; }

      public string  telephone { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basSmsTel结束----------
    