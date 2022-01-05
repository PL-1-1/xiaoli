    //----------billDepartureList2018开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDepartureList2018//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  DepartureListNO { get; set; }

      public string  DepartureBatch { get; set; }

      public string  CarNO { get; set; }

      public string  BillNO { get; set; }

      public string  DriverName { get; set; }

      public DateTime  WebDate { get; set; }

      public int  ? WebPCS { get; set; }

      public int  ? WebState { get; set; }

      public string  BSite { get; set; }

      public string  ToSite { get; set; }

      public string  MiddleSite { get; set; }

      public DateTime  ? ToDate { get; set; }

      public int  ? WebCount { get; set; }

      public int  ? IsNotice { get; set; }

      public string  AcceptSiteName { get; set; }

      public string  AcceptWebName { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DepName { get; set; }

      public int  ? IsOut { get; set; }

      public string  AcceptBillMan { get; set; }

      public DateTime  ? AcceptBillDate { get; set; }

      public string  SCBatchNo { get; set; }

      public int  ? RemainWebPCS { get; set; }

      public int  id { get; set; }

      public int  ? IsAdd { get; set; }

      public int  ? OperType { get; set; }

      public DateTime  ? Operdate { get; set; }

      public string  AddMan { get; set; }

      public DateTime  ? DownGoodsTime { get; set; }

      public string  AddReason { get; set; }

      public string  AcceptReason { get; set; }

      public int  ? RemainPreSendPCS { get; set; }

      public int  ? ScanQty { get; set; }

      public string  companyid { get; set; }

      public decimal  ? ActualWeight { get; set; }

      public decimal  ? ActualVolume { get; set; }

      public string  SendDepartureListNo { get; set; }

      public int  ? UnloadScannerNo { get; set; }

      public int  ? UnloadScannerTicketNo { get; set; }

      public string  Descompanyid { get; set; }

      public int  ? BeforeBillState { get; set; }
 

    }
}
    //----------billDepartureList2018结束----------
    