    //----------RPofdrivers开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class RPofdrivers//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  DepartureBatch { get; set; }

      public DateTime  WebDate { get; set; }

      public string  BSite { get; set; }

      public string  ToSite { get; set; }

      public string  DriverName { get; set; }

      public string  CarNO { get; set; }

      public decimal  Amount { get; set; }

      public Guid  RPofdriverID { get; set; }

      public string  RPContent { get; set; }

      public string  cbMoneyType { get; set; }

      public DateTime  ? RegisterDate { get; set; }

      public string  RegisterMan { get; set; }

      public string  ConfirmState { get; set; }

      public string  ConfirmMan { get; set; }

      public DateTime  ? ConfirmDate { get; set; }
 

    }
}
    //----------RPofdrivers结束----------
    