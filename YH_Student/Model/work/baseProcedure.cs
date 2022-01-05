    //----------baseProcedure开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class baseProcedure//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ProcID { get; set; }

      public string  ProcName { get; set; }

      public string  ProcSql { get; set; }

      public string  ProcReamrk { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------baseProcedure结束----------
    