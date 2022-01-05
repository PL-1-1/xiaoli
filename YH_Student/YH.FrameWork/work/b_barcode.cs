    //----------b_barcode开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_barcode//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  billno { get; set; }

      public int  ? sn { get; set; }

      public int  ? state { get; set; }

      public string  man { get; set; }

      public DateTime  ? billdate { get; set; }

      public int  ? type { get; set; }

      public int  ? unit { get; set; }

      public int  ? state1 { get; set; }

      public string  man1 { get; set; }

      public DateTime  ? date1 { get; set; }

      public int  ? type1 { get; set; }

      public int  ? dbstate1 { get; set; }

      public string  dbman1 { get; set; }

      public DateTime  ? dbdate1 { get; set; }

      public int  ? dbtype1 { get; set; }

      public int  ? dbstate2 { get; set; }

      public string  dbman2 { get; set; }

      public DateTime  ? dbdate2 { get; set; }

      public int  ? dbtype2 { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------b_barcode结束----------
    