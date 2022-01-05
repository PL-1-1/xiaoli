    //----------SZBargaining开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SZBargaining//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? priceId { get; set; }

      public string  BillNo { get; set; }

      public string  BillSite { get; set; }

      public string  BillWeb { get; set; }

      public decimal  ? mainLineFee { get; set; }

      public decimal  ? mainLinePer { get; set; }

      public decimal  ? newMainLinefee { get; set; }

      public DateTime  ? operDate { get; set; }

      public string  confirmState { get; set; }

      public string  BillState { get; set; }

      public string  Varieties { get; set; }

      public int  ? Num { get; set; }

      public string  TransferSite { get; set; }

      public string  TransitMode { get; set; }

      public string  TransitLines { get; set; }

      public decimal  ? ActualFreight { get; set; }

      public string  ApplyMan { get; set; }

      public DateTime  ? ApplyDate { get; set; }

      public string  ApplyWebName { get; set; }

      public string  ConfirmMan { get; set; }

      public DateTime  ? ConfirmDate { get; set; }

      public string  ConfirmWebName { get; set; }

      public string  CancelMan { get; set; }

      public DateTime  ? CancelDate { get; set; }

      public string  CancelWebName { get; set; }

      public decimal  ? OperationWeight { get; set; }

      public string  BargainingMark { get; set; }

      public string  foujueyuanyin { get; set; }

      public string  companyid { get; set; }

      public decimal  ? DeliveryFee { get; set; }

      public decimal  ? NewDeliveryFee { get; set; }

      public decimal  ? DeliveryFeePer { get; set; }

      public string  ExcuteMan { get; set; }

      public DateTime  ? ExcuteDate { get; set; }

      public string  ExcuteWebName { get; set; }

      public string  AcceptCompany { get; set; }

      public string  inputSerialNumber { get; set; }
 

    }
}
    //----------SZBargaining结束----------
    