    //----------basAccDetail_1开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basAccDetail_1//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  AID { get; set; }

      public string  BillNO { get; set; }

      public DateTime  ? ChangeDate { get; set; }

      public string  PayAccount { get; set; }

      public string  PaySite { get; set; }

      public string  PayToAccount { get; set; }

      public string  PayToSite { get; set; }

      public string  FeeType { get; set; }

      public string  INOROUT { get; set; }

      public decimal  ? BfMoney { get; set; }

      public decimal  ? Money { get; set; }

      public decimal  ? BhMoney { get; set; }

      public string  SerialNumber { get; set; }

      public DateTime  ? BillDate { get; set; }

      public DateTime  ? StateMentDate { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  SettlementAcc { get; set; }

      public string  TotalType { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basAccDetail_1结束----------
    