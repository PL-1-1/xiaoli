    //----------b_tyd开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_tyd//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public DateTime  ? billdate { get; set; }

      public string  unit { get; set; }

      public string  billno { get; set; }

      public string  bsite { get; set; }

      public string  webid { get; set; }

      public string  esite { get; set; }

      public string  middlesite { get; set; }

      public string  consignee { get; set; }

      public int  ? remainqty { get; set; }

      public decimal  ? weight_c { get; set; }

      public decimal  ? volumn_c { get; set; }

      public int  state { get; set; }

      public int  ? qty { get; set; }

      public decimal  ? accnow { get; set; }

      public decimal  ? accarrived { get; set; }

      public int  accback { get; set; }

      public decimal  ? accmonth { get; set; }

      public int  acchuokuankou { get; set; }

      public decimal  ? acchuikou { get; set; }

      public string  tydcompanyid { get; set; }

      public string  dttosite { get; set; }

      public string  dttowebid { get; set; }

      public int  ? BillToType { get; set; }
 

    }
}
    //----------b_tyd结束----------
    