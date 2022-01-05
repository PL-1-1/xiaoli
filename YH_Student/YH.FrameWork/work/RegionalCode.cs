    //----------RegionalCode开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class RegionalCode//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  id { get; set; }

      public string  ECode { get; set; }

      public string  EName { get; set; }

      public string  ESupCode { get; set; }

      public int  ? ELevel { get; set; }

      public string  EFullName { get; set; }
 

    }
}
    //----------RegionalCode结束----------
    