    //----------account_detail开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class account_detail//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public decimal  ? accfs { get; set; }

      public string  acctype { get; set; }

      public string  xmtype { get; set; }

      public string  remark { get; set; }

      public decimal  ? baccfs { get; set; }

      public decimal  ? eaccfs { get; set; }

      public string  userid { get; set; }

      public DateTime  ? billdate { get; set; }

      public int  ? isShow { get; set; }

      public decimal  ? AmountOfCash { get; set; }

      public decimal  ? SurplusAmount { get; set; }

      public decimal  ? accfsAmount { get; set; }

      public string  orderno { get; set; }

      public string  accfss { get; set; }

      public int  ? putforward { get; set; }

      public int  ? state { get; set; }

      public decimal  ? lastSurAmount { get; set; }
 

    }
}
    //----------account_detail结束----------
    