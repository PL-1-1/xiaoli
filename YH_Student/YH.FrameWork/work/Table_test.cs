    //----------Table_test开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class Table_test//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? sfguid { get; set; }

      public int  ? sfid { get; set; }

      public string  sfname { get; set; }

      public Guid  ? shiguid { get; set; }

      public int  ? shiid { get; set; }

      public string  shiname { get; set; }

      public Guid  ? xuanguid { get; set; }

      public int  ? xuanid { get; set; }

      public string  xuanname { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------Table_test结束----------
    