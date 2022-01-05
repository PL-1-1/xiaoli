    //----------baseRegion开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class baseRegion//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  RegionGuid { get; set; }

      public int  RegionID { get; set; }

      public string  RegionName { get; set; }

      public int  ParentID { get; set; }

      public string  ParentName { get; set; }

      public int  ? RegionState { get; set; }

      public int  ? RegionLevel { get; set; }

      public string  RegionRemark { get; set; }

      public decimal  ? lon { get; set; }

      public decimal  ? lat { get; set; }

      public string  RegionShortName { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------baseRegion结束----------
    