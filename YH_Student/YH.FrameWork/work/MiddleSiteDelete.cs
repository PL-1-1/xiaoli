    //----------MiddleSiteDelete开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class MiddleSiteDelete//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  MiddleSiteId { get; set; }

      public string  ModilySiteName { get; set; }

      public string  ModilyWebName { get; set; }

      public string  ModilyMan { get; set; }

      public string  ModilyDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------MiddleSiteDelete结束----------
    