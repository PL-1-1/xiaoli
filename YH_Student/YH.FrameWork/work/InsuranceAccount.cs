    //----------InsuranceAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class InsuranceAccount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  InsuranceID { get; set; }

      public string  GSQC { get; set; }

      public string  GSJC { get; set; }

      public int  ? AccountID { get; set; }

      public decimal  ? InsuranceBalance { get; set; }

      public string  State { get; set; }
 

    }
}
    //----------InsuranceAccount结束----------
    