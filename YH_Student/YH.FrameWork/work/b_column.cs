    //----------b_column开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_column//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ColGuid { get; set; }

      public string  TableName { get; set; }

      public string  ColName { get; set; }

      public string  ColCaption { get; set; }

      public DateTime  ? OperDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------b_column结束----------
    