    //----------B_VEHICLE_HT开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class B_VEHICLE_HT//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  vehicleno { get; set; }

      public string  inonevehicleflag { get; set; }

      public string  billno { get; set; }

      public DateTime  ? senddate { get; set; }

      public string  bsite { get; set; }

      public string  esite { get; set; }

      public DateTime  ? billdate { get; set; }

      public string  chauffer { get; set; }

      public string  chauffermb { get; set; }

      public string  madeby { get; set; }

      public string  createby { get; set; }

      public int  ? isover { get; set; }

      public decimal  ? accfirst { get; set; }

      public decimal  ? accarrived { get; set; }

      public decimal  ? accback { get; set; }

      public decimal  ? accdaishou { get; set; }

      public decimal  ? acctotal { get; set; }

      public decimal  ? accupdown { get; set; }

      public decimal  ? accqita { get; set; }

      public decimal  ? accfetch { get; set; }

      public string  LoadSite { get; set; }

      public string  LoadWeb { get; set; }

      public string  LoadBusiDept { get; set; }

      public string  LoadArea { get; set; }

      public string  LoadDept { get; set; }

      public string  LoadingType { get; set; }

      public decimal  ? AccTakeCar { get; set; }

      public decimal  ? AccCollectPremium { get; set; }
 

    }
}
    //----------B_VEHICLE_HT结束----------
    