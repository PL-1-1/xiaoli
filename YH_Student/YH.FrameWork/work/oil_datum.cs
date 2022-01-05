    //----------oil_datum开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class oil_datum//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  serialnumber { get; set; }

      public DateTime  ? gktime { get; set; }

      public string  vehicleno { get; set; }

      public decimal  ? nowmoney { get; set; }

      public DateTime  ? updatedate { get; set; }

      public string  updateman { get; set; }

      public DateTime  ? blankoutdate { get; set; }

      public string  blankoutman { get; set; }

      public int  ? state { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------oil_datum结束----------
    