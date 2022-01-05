    //----------tmpbasAccTatol开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class tmpbasAccTatol//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  Id { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  WebName { get; set; }

      public string  InoneFlag { get; set; }

      public string  InOutType { get; set; }

      public double  ? FeeAcc { get; set; }

      public double  ? FeeAccLeft { get; set; }

      public DateTime  ? TotalDate { get; set; }

      public string  ProjectType { get; set; }

      public string  OptMan { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------tmpbasAccTatol结束----------
    