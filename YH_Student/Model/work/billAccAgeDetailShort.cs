    //----------billAccAgeDetailShort开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billAccAgeDetailShort//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillNo { get; set; }

      public string  TransferSite { get; set; }

      public string  StartSite { get; set; }

      public string  DestinationSite { get; set; }

      public string  ConsigneeName { get; set; }

      public DateTime  ? BillDate { get; set; }

      public int  BillState { get; set; }

      public string  BegWeb { get; set; }

      public string  AreaName { get; set; }

      public string  CauseName { get; set; }

      public string  ConsignorCompany { get; set; }

      public string  ConsignorName { get; set; }

      public string  ConsignorPhone { get; set; }

      public string  ConsignorCellPhone { get; set; }

      public string  CusNo { get; set; }

      public string  CusType { get; set; }

      public string  PayMode { get; set; }

      public string  PaymentMode { get; set; }

      public decimal  ? NowPay { get; set; }

      public decimal  ? FetchPay { get; set; }

      public decimal  ? BefArrivalPay { get; set; }

      public decimal  ? MonthPay { get; set; }

      public int  AccountsPayable { get; set; }

      public decimal  UnpaidAccounts { get; set; }

      public int  PrepaidAccounts { get; set; }

      public string  ReceiptCondition { get; set; }

      public string  Varieties { get; set; }

      public decimal  ? FeeWeight { get; set; }

      public decimal  ? Weight { get; set; }

      public decimal  ? FeeVolume { get; set; }

      public decimal  ? Volume { get; set; }

      public string  TheMonth { get; set; }

      public int  ? ArrConfirmMan { get; set; }

      public int  ? VerifyDate { get; set; }

      public int  ? Num { get; set; }

      public decimal  ? ArrComfirmBalance { get; set; }

      public string  BillRemark { get; set; }

      public string  ModifyRemark { get; set; }

      public string  AttriWeb { get; set; }

      public string  Attribution { get; set; }

      public string  AttriPhone { get; set; }

      public string  PayCycle { get; set; }

      public string  companyid { get; set; }

      public decimal  ? AuditedAmount { get; set; }
 

    }
}
    //----------billAccAgeDetailShort结束----------
    