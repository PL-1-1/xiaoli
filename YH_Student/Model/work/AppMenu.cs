    //----------AppMenu开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class AppMenu//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public int  ? Code { get; set; }

      public string  MenuName { get; set; }

      public string  IconName { get; set; }

      public string  GRCode { get; set; }
 

    }
}
    //----------AppMenu结束----------
    