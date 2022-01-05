    //----------sysdiagrams开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysdiagrams//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public object  name { get; set; }

      public int  principal_id { get; set; }

      public int  diagram_id { get; set; }

      public int  ? version { get; set; }

      public byte[]  definition { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------sysdiagrams结束----------
    