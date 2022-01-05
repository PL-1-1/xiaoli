    //----------basFeeType开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basFeeType//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public int  FeeID { get; set; }

      public int  ? ParentID { get; set; }

      public string  TypeName { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basFeeType结束----------
    