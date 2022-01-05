    //----------basEmployee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basEmployee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  EmpID { get; set; }

      public string  EmpName { get; set; }

      public string  EmpNO { get; set; }

      public string  EmpSite { get; set; }

      public string  EmpDept { get; set; }

      public string  EmpPosition { get; set; }

      public string  EmpPost { get; set; }

      public string  EmpArea { get; set; }

      public string  EmpCuase { get; set; }

      public string  EmpWeb { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basEmployee结束----------
    