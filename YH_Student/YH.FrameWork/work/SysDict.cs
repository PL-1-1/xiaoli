    //----------SysDict开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysDict//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  Id { get; set; }

      public string  Name { get; set; }

      public string  Type { get; set; }

      public string  Code { get; set; }

      public string  Value { get; set; }

      public int  ? OrderNum { get; set; }

      public string  Remark { get; set; }

      public byte  ? DelFlag { get; set; }
 

    }
}
    //----------SysDict结束----------
    