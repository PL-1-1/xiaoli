    //----------save_PDAProcLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class save_PDAProcLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  startTime { get; set; }

      public string  endTime { get; set; }

      public string  procName { get; set; }
 

    }
}
    //----------save_PDAProcLog结束----------
    