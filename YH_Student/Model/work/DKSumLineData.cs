    //----------DKSumLineData开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class DKSumLineData//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  StartSite { get; set; }

      public string  TransferSite { get; set; }

      public decimal  ? jmOperationWeight { get; set; }

      public decimal  ? zyOperationWeight { get; set; }

      public decimal  ? jmPaymentAmout { get; set; }

      public decimal  ? zyPaymentAmout { get; set; }

      public decimal  ? jmMiddleFreight { get; set; }

      public decimal  ? zyMiddleFreight { get; set; }

      public int  ? NumTotal { get; set; }

      public string  yeartype { get; set; }

      public string  monthtype { get; set; }

      public string  linetype { get; set; }

      public string  DKDeliverySumLineData { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------DKSumLineData结束----------
    