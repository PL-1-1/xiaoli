    //----------SysMenu开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysMenu//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  MenuId { get; set; }

      public long  ? ParentId { get; set; }

      public string  Name { get; set; }

      public string  Url { get; set; }

      public string  Perms { get; set; }

      public int  ? Type { get; set; }

      public string  Icon { get; set; }

      public int  ? OrderNum { get; set; }
 

    }
}
    //----------SysMenu结束----------
    