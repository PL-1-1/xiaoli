    //----------BI_GroupSummary_typecount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BI_GroupSummary_typecount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ? billcount { get; set; }

      public decimal  ? ActualFreight { get; set; }

      public decimal  ? FeeWeight { get; set; }

      public decimal  ? FeeVolume { get; set; }

      public decimal  ? OperationWeight { get; set; }

      public string  TransitMode { get; set; }

      public DateTime  ? optdate { get; set; }

      public DateTime  ? daytitle { get; set; }

      public string  monthtitle { get; set; }

      public string  yeartitle { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  BegWeb { get; set; }

      public string  webtype { get; set; }

      public string  webmodel { get; set; }
 

    }
}
    //----------BI_GroupSummary_typecount结束----------
    