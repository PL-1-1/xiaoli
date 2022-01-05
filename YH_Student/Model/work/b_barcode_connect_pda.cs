    //----------b_barcode_connect_pda开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_barcode_connect_pda//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  billno { get; set; }

      public int  ? qty1 { get; set; }

      public int  ? qty2 { get; set; }

      public DateTime  ? billdate { get; set; }

      public string  dbman2 { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------b_barcode_connect_pda结束----------
    