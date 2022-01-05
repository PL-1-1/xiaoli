    //----------PrescriptionTable开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class PrescriptionTable//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillNo { get; set; }

      public DateTime  BegDate { get; set; }

      public DateTime  ? EndDate { get; set; }

      public string  BegWeb { get; set; }

      public string  EndWeb { get; set; }

      public DateTime  ? LatestDepartTime { get; set; }

      public DateTime  ? DepartTime { get; set; }

      public string  DepartTWeb { get; set; }

      public string  DispWeb { get; set; }

      public DateTime  ? SignTime { get; set; }

      public string  ReceivProvince { get; set; }

      public string  ReceivCity { get; set; }

      public string  ReceivArea { get; set; }

      public string  ReceivStreet { get; set; }

      public string  TransferMode { get; set; }

      public string  PickGoodsSite { get; set; }

      public string  TransitMode { get; set; }

      public string  ConsignorCompany { get; set; }

      public string  ConsignorName { get; set; }

      public string  ConsignorCellPhone { get; set; }

      public string  ConsignorPhone { get; set; }

      public string  ConsigneeCompany { get; set; }

      public string  ConsigneeName { get; set; }

      public string  ConsigneeCellPhone { get; set; }

      public string  Varieties { get; set; }

      public string  Package { get; set; }

      public decimal  ? FeeWeight { get; set; }

      public decimal  ? FeeVolume { get; set; }

      public int  ? Num { get; set; }

      public string  ConsigneePhone { get; set; }

      public string  BegWeb_New { get; set; }

      public int  ? IsSign { get; set; }

      public string  StartSite { get; set; }

      public string  TransferSite { get; set; }

      public DateTime  ? AcceptBillDate { get; set; }

      public DateTime  ? MiddleDate { get; set; }

      public string  AcceptWebName { get; set; }

      public string  SCAcceptWeb { get; set; }

      public DateTime  ? SCAcceptTime { get; set; }

      public DateTime  ? AcceptTime { get; set; }

      public string  SendToWeb { get; set; }

      public string  SendGoodsWeb { get; set; }

      public DateTime  ? SendGoodsTime { get; set; }

      public DateTime  ? SignUpDate { get; set; }

      public DateTime  ? MiddleSignDate { get; set; }

      public int  ? BillState { get; set; }

      public string  ISCustomerProblem { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  MiddleWebName { get; set; }

      public string  SynRemark { get; set; }

      public DateTime  ? SendDate { get; set; }

      public string  FromWebName { get; set; }

      public DateTime  ? AcceptDate { get; set; }

      public string  AcceptWebNamebranch { get; set; }

      public string  ReceiptCondition { get; set; }

      public string  SendCarShift { get; set; }

      public DateTime  ? SendDateTwo { get; set; }

      public DateTime  ? AcceptDateTwo { get; set; }

      public string  AcceptWebNamebranchTwo { get; set; }

      public string  FromWebNameTwo { get; set; }

      public string  CompanyId { get; set; }

      public int  ? IsViewTrace { get; set; }

      public int  ? MarketSuper { get; set; }

      public int  ? IsStorageFee { get; set; }

      public int  ? IsHandleFee { get; set; }

      public int  ? IsSortFee { get; set; }

      public int  ? IsAgentFee { get; set; }

      public string  OperBespeakContent { get; set; }
 

    }
}
    //----------PrescriptionTable结束----------
    