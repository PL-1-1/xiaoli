    //----------billHandFeeByCar开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billHandFeeByCar//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  DepartureBatch { get; set; }

      public string  Type { get; set; }

      public decimal  ? HandFee { get; set; }

      public string  CreatelMan { get; set; }

      public DateTime  ? CreateTime { get; set; }

      public string  AduitMan { get; set; }

      public DateTime  ? AduitTime { get; set; }

      public int  ? AduitState { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public string  AreaName { get; set; }

      public string  CauseName { get; set; }

      public string  ReMark { get; set; }

      public string  HandMan { get; set; }

      public string  HandManPhone { get; set; }

      public decimal  ? HandFeeLeft { get; set; }

      public string  companyid { get; set; }

      public string  FeeType { get; set; }

      public string  ExceDepart { get; set; }
 

    }
}
    //----------billHandFeeByCar结束----------
    