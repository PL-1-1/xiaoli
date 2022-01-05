    //----------basTerminalOutFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basTerminalOutFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  basTerminalOutFeeID { get; set; }

      public string  FromSite { get; set; }

      public string  ToSite { get; set; }

      public string  CompanyName { get; set; }

      public string  OpName { get; set; }

      public string  CompanyAdd { get; set; }

      public string  phone { get; set; }

      public decimal  ? minPrice { get; set; }

      public decimal  ? price { get; set; }

      public decimal  ? SendFee { get; set; }

      public decimal  ? UpstairFee { get; set; }

      public string  isSign { get; set; }

      public decimal  ? AgentFee { get; set; }

      public string  evaluate { get; set; }

      public decimal  ? ArrivalFee { get; set; }

      public string  DepartureDate { get; set; }

      public string  ArrivalDate { get; set; }

      public string  Remark { get; set; }

      public decimal  ? RunTime { get; set; }

      public string  getFeeSpeed { get; set; }

      public decimal  ? weightPrice { get; set; }

      public decimal  ? volumePrice { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basTerminalOutFee结束----------
    