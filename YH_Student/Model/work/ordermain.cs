    //----------ordermain开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ordermain//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  orderno { get; set; }

      public DateTime  ? orderdate { get; set; }

      public DateTime  ? fetchdate { get; set; }

      public string  hzid { get; set; }

      public decimal  ? account { get; set; }

      public int  ? ordertype { get; set; }

      public int  ? tydtype { get; set; }

      public int  ? zftype { get; set; }

      public int  ? mainstate { get; set; }

      public string  cancelman { get; set; }

      public string  cancelremark { get; set; }

      public DateTime  ? canceldate { get; set; }

      public string  address { get; set; }

      public string  lng { get; set; }

      public string  lat { get; set; }

      public string  sjid { get; set; }

      public string  remark { get; set; }

      public double  ? weight { get; set; }

      public double  ? volumn { get; set; }

      public string  hzmb { get; set; }

      public string  vehicletype { get; set; }

      public string  lxr { get; set; }

      public DateTime  ? zcdate { get; set; }

      public string  sjname { get; set; }

      public string  vehicleno { get; set; }

      public string  sjmb { get; set; }

      public DateTime  ? okdate { get; set; }

      public DateTime  ? begindate { get; set; }

      public double  ? glstotal { get; set; }

      public string  zdsjid { get; set; }

      public string  pdtype { get; set; }

      public string  acctype { get; set; }

      public DateTime  ? psdate { get; set; }

      public string  pstime { get; set; }

      public string  gid { get; set; }

      public string  hdnum { get; set; }

      public string  detailnum { get; set; }

      public DateTime  ? departuretime { get; set; }

      public DateTime  ? arrivaltime { get; set; }

      public int  ? Invalidated { get; set; }
 

    }
}
    //----------ordermain结束----------
    