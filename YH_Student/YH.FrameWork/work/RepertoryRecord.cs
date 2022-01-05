    //----------RepertoryRecord开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class RepertoryRecord//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  BillNo { get; set; }

      public string  FromWeb { get; set; }

      public string  ToWeb { get; set; }

      public int  ? OptNum { get; set; }

      public DateTime  ? OptDate { get; set; }

      public string  OptMan { get; set; }

      public string  OptWeb { get; set; }

      public string  OptType { get; set; }

      public string  RepertoryType { get; set; }
 

    }
}
    //----------RepertoryRecord结束----------
    