    //----------basSenderFreightPrice开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basSenderFreightPrice//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  PID { get; set; }

      public string  PSite { get; set; }

      public string  PName { get; set; }

      public decimal  ? PriceVolume { get; set; }

      public decimal  ? PriceWeight { get; set; }

      public decimal  ? PricePiece { get; set; }

      public string  CustNo { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basSenderFreightPrice结束----------
    