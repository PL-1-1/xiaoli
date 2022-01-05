    //----------billApply开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billApply//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ApplyID { get; set; }

      public string  BillNO { get; set; }

      public string  GoodsNo { get; set; }

      public DateTime  ? BillingDate { get; set; }

      public string  ApplyContent { get; set; }

      public DateTime  ? ApplyDate { get; set; }

      public string  BeginSite { get; set; }

      public string  EndSite { get; set; }

      public string  BillingWeb { get; set; }

      public string  ApplyWeb { get; set; }

      public string  ApplyMan { get; set; }

      public string  ApplyType { get; set; }

      public string  LastState { get; set; }

      public DateTime  ? AuditingDate { get; set; }

      public string  AuditingMan { get; set; }

      public string  AuditingRemark { get; set; }

      public int  ? AuditingState { get; set; }

      public string  ApprovalMan { get; set; }

      public DateTime  ? ApprovalDate { get; set; }

      public string  ApprovalRemark { get; set; }

      public int  ? ApprovalState { get; set; }

      public DateTime  ? ExcuteDate { get; set; }

      public string  ExcuteMan { get; set; }

      public string  ExcuteRemark { get; set; }

      public int  ? ExcuteState { get; set; }

      public string  CancelMan { get; set; }

      public DateTime  ? CancelDate { get; set; }

      public string  VetoMan { get; set; }

      public DateTime  ? VetoDate { get; set; }

      public string  VetoRemark { get; set; }

      public string  ApplyObj { get; set; }

      public string  SendGoodsMan { get; set; }

      public string  SqlStr { get; set; }

      public string  BillApply { get; set; }

      public string  ToMonthPayMan { get; set; }

      public DateTime  ? ToMonthPayDate { get; set; }

      public string  RecWeb { get; set; }

      public string  ExcuVetoSite { get; set; }

      public string  ExcuVetoWeb { get; set; }

      public decimal  ? ChangeMoney { get; set; }

      public decimal  ? AmountMoney { get; set; }

      public string  SerialNumber { get; set; }

      public string  ChangePlusObj { get; set; }

      public decimal  ? unFetchCharge { get; set; }

      public string  companyid { get; set; }

      public string  PlatformReviewMan { get; set; }

      public DateTime  ? PlatformReviewDate { get; set; }

      public string  PlatformReviewWebName { get; set; }

      public string  PlatformReviewStatu { get; set; }

      public int  ? ModifyType { get; set; }
 

    }
}
    //----------billApply结束----------
    