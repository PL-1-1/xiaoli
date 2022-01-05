    //----------basDepart开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basDepart//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  DepId { get; set; }

      public string  DepArea { get; set; }

      public string  DepName { get; set; }

      public string  DepCode { get; set; }

      public string  DepMan { get; set; }

      public string  DepPhone { get; set; }

      public string  DepRemark { get; set; }

      public string  DepRight { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basDepart结束----------
    