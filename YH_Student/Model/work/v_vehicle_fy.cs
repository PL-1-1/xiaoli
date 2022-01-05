    //----------v_vehicle_fy开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class v_vehicle_fy//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  unit { get; set; }

      public DateTime  ? bldate { get; set; }

      public string  vehicleno { get; set; }

      public string  fyproject { get; set; }

      public decimal  ? money { get; set; }

      public string  zfaccount { get; set; }

      public string  madeby { get; set; }

      public string  checkman { get; set; }

      public string  remark { get; set; }

      public string  updateman { get; set; }

      public DateTime  ? updatedate { get; set; }

      public string  blankoutman { get; set; }

      public DateTime  ? blankoutdate { get; set; }

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
    //----------v_vehicle_fy结束----------
    