    //----------B_WEB_ORDER开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class B_WEB_ORDER//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  logisticCompanyID { get; set; }

      public string  logisticID { get; set; }

      public string  aliUID { get; set; }

      public string  memberType { get; set; }

      public string  businessNetworkNo { get; set; }

      public string  toNetworkNo { get; set; }

      public string  sender_companyName { get; set; }

      public string  sender_name { get; set; }

      public string  sender_postCode { get; set; }

      public string  sender_phone { get; set; }

      public string  sender_mobile { get; set; }

      public string  sender_province { get; set; }

      public string  sender_city { get; set; }

      public string  sender_county { get; set; }

      public string  sender_address { get; set; }

      public string  receiver_companyName { get; set; }

      public string  receiver_name { get; set; }

      public string  receiver_postCode { get; set; }

      public string  receiver_phone { get; set; }

      public string  receiver_mobile { get; set; }

      public string  receiver_province { get; set; }

      public string  receiver_city { get; set; }

      public string  receiver_county { get; set; }

      public string  receiver_address { get; set; }

      public DateTime  ? gmtCommit { get; set; }

      public string  cargoName { get; set; }

      public double  ? totalWeight { get; set; }

      public double  ? totalVolume { get; set; }

      public double  ? totalNumber { get; set; }

      public double  ? totalPrice { get; set; }

      public double  ? transportPrice { get; set; }

      public double  ? weightRate { get; set; }

      public double  ? volumeRate { get; set; }

      public double  ? leastExpenses { get; set; }

      public string  transportType { get; set; }

      public string  insuranceValue { get; set; }

      public string  insurancePrice { get; set; }

      public string  codType { get; set; }

      public double  ? codValue { get; set; }

      public double  ? codPrice { get; set; }

      public string  vistReceive { get; set; }

      public string  vistReceivePrice { get; set; }

      public string  deliveryType { get; set; }

      public string  deliveryPrice { get; set; }

      public string  backSignBill { get; set; }

      public string  backSignBillPrice { get; set; }

      public string  packageService { get; set; }

      public string  packageServicePrice { get; set; }

      public string  waitNotifySend { get; set; }

      public string  waitNotifySendPrice { get; set; }

      public string  smsNotify { get; set; }

      public string  smsNotifyPrice { get; set; }

      public string  fuelSurcharge { get; set; }

      public string  fuelSurchargePrice { get; set; }

      public string  materialCost { get; set; }

      public string  materialCostPrice { get; set; }

      public string  otherPrice { get; set; }

      public string  remark { get; set; }

      public string  promotion { get; set; }

      public string  gmtCancel { get; set; }

      public string  mailNo { get; set; }

      public string  statusType { get; set; }

      public string  payType { get; set; }

      public int  id { get; set; }

      public string  companyid { get; set; }

      public string  shouliman { get; set; }

      public DateTime  ? shoulidate { get; set; }

      public string  lanshouman { get; set; }

      public DateTime  ? lanshoudate { get; set; }

      public string  qianshouman { get; set; }

      public DateTime  ? qianshoudate { get; set; }
 

    }
}
    //----------B_WEB_ORDER结束----------
    