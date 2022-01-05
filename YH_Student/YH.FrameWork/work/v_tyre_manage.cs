    //----------v_tyre_manage开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class v_tyre_manage//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  tyreno { get; set; }

      public string  tyreguige { get; set; }

      public string  azlocation { get; set; }

      public string  manufacturer { get; set; }

      public string  vehicleno { get; set; }

      public string  gyname { get; set; }

      public DateTime  ? buydate { get; set; }

      public decimal  ? buymoney { get; set; }

      public DateTime  ? usedate { get; set; }

      public DateTime  ? rejectdate { get; set; }

      public int  ? tyrestate { get; set; }

      public string  remark { get; set; }

      public string  updateman { get; set; }

      public DateTime  ? updatedate { get; set; }

      public string  blankoutman { get; set; }

      public DateTime  ? blankoutdate { get; set; }

      public string  checkman { get; set; }

      public DateTime  ? checkdate { get; set; }

      public int  ? state { get; set; }

      public string  checkweb { get; set; }

      public int  id { get; set; }

      public int  ? ToOA { get; set; }

      public int  ? ToOAAPP { get; set; }

      public int  ? ToOAAPPOA { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------v_tyre_manage结束----------
    