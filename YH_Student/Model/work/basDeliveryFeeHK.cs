    //----------basDeliveryFeeHK开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basDeliveryFeeHK//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  DeliveryFeeID { get; set; }

      public string  Province { get; set; }

      public string  City { get; set; }

      public string  Area { get; set; }

      public string  Street { get; set; }

      public string  Remark { get; set; }

      public string  ExpressionName { get; set; }

      public decimal  ? Additional { get; set; }

      public string  kilometre { get; set; }

      public string  companyid { get; set; }

      public string  LowestPrice { get; set; }
 

    }
}
    //----------basDeliveryFeeHK结束----------
    