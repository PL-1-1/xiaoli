    //----------Receipt_test开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class Receipt_test//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  RecId { get; set; }

      public string  BillNO { get; set; }

      public string  OperateType { get; set; }

      public string  Operator { get; set; }

      public DateTime  ? OperateTime { get; set; }

      public string  OperateRemark { get; set; }

      public string  OperateSite { get; set; }

      public string  OperateWeb { get; set; }

      public string  ToSite { get; set; }

      public string  ToWeb { get; set; }

      public string  RecBatch { get; set; }

      public string  SendNum { get; set; }

      public string  OperateState { get; set; }

      public string  LinkTel { get; set; }

      public int  id { get; set; }

      public string  companyid { get; set; }

      public int  ? ReceiptType { get; set; }

      public string  courierFirm { get; set; }

      public string  trackingNo { get; set; }

      public string  MailingType { get; set; }

      public string  express { get; set; }

      public string  CourierNumber { get; set; }

      public string  LicensePlate { get; set; }

      public string  HDDriverName { get; set; }

      public string  HDPCH { get; set; }

      public string  HDBillNo { get; set; }
 

    }
}
    //----------Receipt_test结束----------
    