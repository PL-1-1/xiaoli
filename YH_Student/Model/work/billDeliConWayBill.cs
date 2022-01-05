    //----------billDeliConWayBill开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDeliConWayBill//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  DeliCBId { get; set; }

      public string  DeliCode { get; set; }

      public string  BillNo { get; set; }

      public double  ? ReceivFee { get; set; }

      public string  CustNo { get; set; }

      public int  ? Num { get; set; }

      public string  companyid { get; set; }

      public DateTime  ? FirstBillNoInDate { get; set; }
 

    }
}
    //----------billDeliConWayBill结束----------
    