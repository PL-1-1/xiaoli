    //----------qt_income开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class qt_income//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public DateTime  Senddate { get; set; }

      public string  entryname { get; set; }

      //public string  abstract { get; set; }

      public decimal  Amount { get; set; }

      public string  Remarks { get; set; }

      public string  Registrant { get; set; }

      public string  Redepartment { get; set; }

      public DateTime  Redate { get; set; }

      public string  auditstatus { get; set; }

      public string  Auditor { get; set; }

      public DateTime  ? Auditdate { get; set; }

      public Guid  id { get; set; }

      public decimal  ? PayVerif { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  WebName { get; set; }

      public string  FSWeb { get; set; }
 

    }
}
    //----------qt_income结束----------
    