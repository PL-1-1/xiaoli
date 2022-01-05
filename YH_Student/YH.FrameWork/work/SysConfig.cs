    //----------SysConfig开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysConfig//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  Id { get; set; }

      public string  paramKey { get; set; }

      public string  ParamValue { get; set; }

      public byte  ? Status { get; set; }

      public string  Remark { get; set; }
 

    }
}
    //----------SysConfig结束----------
    