    //----------TransferFeeBackDetail开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class TransferFeeBackDetail//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? BillDate { get; set; }

      public string  StartSite { get; set; }

      public string  TransferSite { get; set; }

      public string  DestinationSite { get; set; }

      public string  BegWeb { get; set; }

      public string  TransferMode { get; set; }

      public string  OutCause { get; set; }

      public string  OutArea { get; set; }

      public string  OutWeb { get; set; }

      public DateTime  ? OutDate { get; set; }

      public decimal  ? TransferFee { get; set; }

      public string  ArrivedCause { get; set; }

      public string  ArrivedArea { get; set; }

      public string  ArrivedWeb { get; set; }

      public string  TransferFeeBackState { get; set; }

      public DateTime  ? TransferFeeBackDate { get; set; }

      public decimal  ? AcceptWebFee { get; set; }

      public decimal  ? SignWebFee { get; set; }

      public decimal  ? MiddlePayRatio { get; set; }

      public decimal  ? OperationWeight { get; set; }

      public DateTime  ? SignDate { get; set; }

      public string  SignMan { get; set; }
 

    }
}
    //----------TransferFeeBackDetail结束----------
    