    //----------billSendGoods2018开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billSendGoods2018//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SendId { get; set; }

      public string  SendNO { get; set; }

      public string  BillNO { get; set; }

      public string  SendBatch { get; set; }

      public string  SendCarNO { get; set; }

      public string  SendDriver { get; set; }

      public string  SendDriverPhone { get; set; }

      public string  SendDesc { get; set; }

      public int  ? SendPCS { get; set; }

      public DateTime  ? SendDate { get; set; }

      public int  ? SendNUM { get; set; }

      public string  SendSite { get; set; }

      public string  SendWeb { get; set; }

      public string  SendToSite { get; set; }

      public string  SendToWeb { get; set; }

      public string  SendOperator { get; set; }

      public double  ? AccSend { get; set; }

      public int  ? SendVerifState { get; set; }

      public double  ? AccSendLast { get; set; }

      public string  VerifMan { get; set; }

      public DateTime  ? VerifDate { get; set; }

      public int  ? IsOut { get; set; }

      public string  SendDepartureListNo { get; set; }

      public int  ? BillState { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  AcceptMan { get; set; }

      public DateTime  ? AcceptTime { get; set; }

      public int  ? IsSigned { get; set; }

      public string  BegCauseName { get; set; }

      public string  BegAreaName { get; set; }

      public int  ? RemainSendPCS { get; set; }

      public int  id { get; set; }

      public int  ? RemainPreSendPCS { get; set; }

      public DateTime  ? PrintDate { get; set; }

      public string  SendToProvince { get; set; }

      public string  SendToCity { get; set; }

      public string  SendToArea { get; set; }

      public string  SendToStreet { get; set; }

      public int  ? SendToType { get; set; }

      public decimal  ? DeliveryFee_S { get; set; }

      public int  ? ScanQty { get; set; }

      public string  companyid { get; set; }

      public string  SendCarStyle { get; set; }

      public int  ? IsSyn { get; set; }

      public decimal  ? sendFeeStandard { get; set; }

      public decimal  ? CarLength { get; set; }

      public decimal  ? SettleAmount { get; set; }

      public string  ConnBatchs { get; set; }

      public decimal  ? DispatchMoney { get; set; }

      public string  LossMoneyReason { get; set; }

      public decimal  ? DispatchMoneyLast { get; set; }

      public string  DispatchMoneyState { get; set; }

      public string  ddVerifMan { get; set; }

      public DateTime  ? ddVerifDate { get; set; }

      public string  CarType { get; set; }

      public string  IsRepairOut { get; set; }

      public DateTime  ? StartTime { get; set; }

      public DateTime  ? ArriveOperTime { get; set; }

      public int  ? ScannerTicketNo { get; set; }

      public int  ? ScannerNo { get; set; }

      public int  ? thingNo { get; set; }

      public int  ? UnLoadScannerTicketNo { get; set; }

      public int  ? UnLoadScannerNo { get; set; }

      public int  ? ClaimState { get; set; }

      public string  ClaimMan { get; set; }

      public string  Descompanyid { get; set; }

      public int  ? SendAduitState { get; set; }
 

    }
}
    //----------billSendGoods2018结束----------
    