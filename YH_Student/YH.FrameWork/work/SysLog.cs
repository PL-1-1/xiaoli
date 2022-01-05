    //----------SysLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  Id { get; set; }

      public string  Username { get; set; }

      public string  Operation { get; set; }

      public string  Method { get; set; }

      public string  Params { get; set; }

      public long  Time { get; set; }

      public string  Ip { get; set; }

      public DateTime  ? CreateDate { get; set; }
 

    }
}
    //----------SysLog结束----------
    