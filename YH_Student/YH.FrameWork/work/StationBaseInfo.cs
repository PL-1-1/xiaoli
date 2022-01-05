    //----------StationBaseInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class StationBaseInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  StationName { get; set; }

      public decimal  ? StationArea { get; set; }

      public decimal  ? StationMonthRent { get; set; }

      public int  ? WorkManNum { get; set; }

      public decimal  ? WorkManMonthPay { get; set; }

      public int  ? ForkliftNum { get; set; }

      public decimal  ? ForkliftMonthRent { get; set; }

      public decimal  ? ForkliftMonthOil { get; set; }

      public int  ? eForkliftNum { get; set; }

      public decimal  ? eForkliftMonthRent { get; set; }

      public decimal  ? MonthWaterElectric { get; set; }

      public decimal  ? StationSumCost { get; set; }

      public DateTime  ? OptDate { get; set; }

      public string  Year { get; set; }

      public string  Month { get; set; }

      public string  companyid { get; set; }

      public string  Day { get; set; }
 

    }
}
    //----------StationBaseInfo结束----------
    