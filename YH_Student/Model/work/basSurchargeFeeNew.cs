    //----------basSurchargeFeeNew开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basSurchargeFeeNew//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? SurchargeFeeID { get; set; }

      public string  ProjectType { get; set; }

      public string  JudgeColumn { get; set; }

      public string  JudgeType { get; set; }

      public decimal  ? ParcelWeight { get; set; }

      public decimal  ? ParcelVolume { get; set; }

      public decimal  ? ParcelPriceMin { get; set; }

      public decimal  ? ParcelPriceMax { get; set; }

      public decimal  ? FeeRate { get; set; }

      public string  FeeColumn { get; set; }

      public string  Unit { get; set; }

      public string  Remark { get; set; }

      public decimal  ? OutLowest { get; set; }

      public string  OutStandard { get; set; }

      public string  OutStandardRemark { get; set; }

      public decimal  ? InnerLowest { get; set; }

      public decimal  ? InnerStandard { get; set; }

      public string  InnerStandardRemark { get; set; }

      public string  companyid { get; set; }

      public DateTime  ? OptTime { get; set; }
 

    }
}
    //----------basSurchargeFeeNew结束----------
    