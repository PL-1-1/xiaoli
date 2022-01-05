    //----------basArea开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basArea//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  AreaID { get; set; }

      public string  AreaCause { get; set; }

      public string  AreaName { get; set; }

      public string  AreaCode { get; set; }

      public string  AreaMan { get; set; }

      public string  AreaPhone { get; set; }

      public string  AreaRemark { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basArea结束----------
    