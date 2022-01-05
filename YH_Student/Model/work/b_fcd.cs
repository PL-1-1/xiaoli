    //----------b_fcd开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_fcd//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  unit { get; set; }

      public string  inonevehicleflag { get; set; }

      public int  ? qty { get; set; }

      public int  ? state { get; set; }

      public string  esite { get; set; }

      public string  MiddleSite { get; set; }

      public DateTime  ? arriveddate { get; set; }

      public DateTime  billdate { get; set; }

      public int  ? sendtimes { get; set; }

      public DateTime  senddate { get; set; }

      public string  vehicleno { get; set; }

      public string  BSite { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DepName { get; set; }

      public string  chauffer { get; set; }

      public int  ? RemainWebPCS { get; set; }

      public int  ? OperType { get; set; }

      public string  AddMan { get; set; }

      public int  ? IsAdd { get; set; }

      public int  ? RemainPreSendPCS { get; set; }
 

    }
}
    //----------b_fcd结束----------
    