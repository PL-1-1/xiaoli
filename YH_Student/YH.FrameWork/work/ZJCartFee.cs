    //----------ZJCartFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ZJCartFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  ZJBatchNo { get; set; }

      public decimal  ? ZJLineFee { get; set; }

      public decimal  ? ZJBigCarFecthFee { get; set; }

      public decimal  ? ZJBigCarSendFee { get; set; }

      public decimal  ? ZJLandingFee { get; set; }

      public decimal  ? ZJOverWeightFee { get; set; }

      public decimal  ? ZJPressNightFee { get; set; }

      public decimal  ? ZJDeclareFee { get; set; }

      public decimal  ? ZJOtherFee { get; set; }

      public decimal  ? ZJDriverTakePay { get; set; }

      public decimal  ? ZJSumCarFee { get; set; }

      public decimal  ? ZJSumFee { get; set; }

      public string  ZJDeliverySite { get; set; }

      public string  ZJDeliveryNo { get; set; }

      public string  ZJSendGoodsNo { get; set; }

      public string  ZJSendGoodsSite { get; set; }

      public string  ZJLandingSite { get; set; }

      public decimal  ? ZJOverWeightNum { get; set; }

      public string  ZJMark { get; set; }

      public string  ZJDeclareBillNo { get; set; }

      public string  ZJBearDep { get; set; }

      public string  ZJOtherFeeMark { get; set; }

      public string  ZJSendGoodsFeeNo { get; set; }

      public int  ? ZJConfirmState { get; set; }

      public string  ZJVerifyMan { get; set; }

      public DateTime  ? ZJVerifyDate { get; set; }

      public int  ? ZJVerifyState { get; set; }

      public decimal  ? ZJVerifyBalance { get; set; }

      public int  ? ZJFeeConfirmState { get; set; }

      public string  ZJFeeConfirmMan { get; set; }

      public DateTime  ? ZJFeeConfirmDate { get; set; }

      public decimal  ? ZJFeeConfirmLeft { get; set; }
 

    }
}
    //----------ZJCartFee结束----------
    