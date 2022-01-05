    //----------WayBillJmGxMonth开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillJmGxMonth//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillNo { get; set; }

      public int  ? NowPayState { get; set; }

      public decimal  ? NowPayLeft { get; set; }

      public int  ? FetchPayState { get; set; }

      public decimal  ? FetchPayLeft { get; set; }

      public int  ? MonthPayState { get; set; }

      public decimal  ? MonthPayLeft { get; set; }

      public int  ? DisTranVerifStateGX { get; set; }

      public string  DisTranVerifManGX { get; set; }

      public DateTime  ? DisTranVerifTimeGX { get; set; }

      public decimal  ? DisTranVerifBalanceGX { get; set; }

      public int  ? AccMiddlePayStateGX { get; set; }

      public decimal  ? AccMiddlePayLeftGX { get; set; }

      public int  ? SendVerifStateGX { get; set; }

      public string  SendVerifManGX { get; set; }

      public DateTime  ? SendVerifDateGX { get; set; }

      public decimal  ? AccSendLastGX { get; set; }

      public string  companyid { get; set; }

      public int  ? BefArrivalPayVerifState { get; set; }

      public string  BefArrivalPayVerifMan { get; set; }

      public DateTime  ? BefArrivalPayVerifTime { get; set; }

      public decimal  ? BefArrivalPayVerifBalance { get; set; }

      public int  ? OwePayVerifState { get; set; }

      public string  OwePayVerifMan { get; set; }

      public DateTime  ? OwePayVerifTime { get; set; }

      public decimal  ? OwePayVerifBalance { get; set; }

      public int  ? ReceiptPayVerifState { get; set; }

      public string  ReceiptPayVerifMan { get; set; }

      public DateTime  ? ReceiptPayVerifTime { get; set; }

      public decimal  ? ReceiptPayVerifBalance { get; set; }
 

    }
}
    //----------WayBillJmGxMonth结束----------
    