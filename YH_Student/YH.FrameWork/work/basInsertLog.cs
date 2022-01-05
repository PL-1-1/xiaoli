    //----------basInsertLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basInsertLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  MenuName { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  WebName { get; set; }

      public string  OptMan { get; set; }

      public DateTime  ? OptTime { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basInsertLog结束----------
    