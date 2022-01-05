    //----------basFinancialAudit开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basFinancialAudit//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  AID { get; set; }

      public DateTime  ? BbusinessDate { get; set; }

      public string  DepartureBatch { get; set; }

      public string  CarNO { get; set; }

      public string  DriverName { get; set; }

      public string  LineName { get; set; }

      public string  StartSite { get; set; }

      public string  DestinationSite { get; set; }

      public decimal  ? ActWeight { get; set; }

      public string  LoadingType { get; set; }

      public decimal  ? ActVolume { get; set; }

      public decimal  ? money { get; set; }

      public string  FeeType { get; set; }

      public string  ConfirmMan { get; set; }

      public DateTime  ? ConfirmDate { get; set; }

      public string  ConfirmState { get; set; }

      public string  Remark { get; set; }

      public DateTime  ? VerifyDate { get; set; }

      public string  VerifyMan { get; set; }

      public string  BankMan { get; set; }

      public string  BankCode { get; set; }

      public string  BankName { get; set; }

      public string  BanKid { get; set; }

      public string  Province { get; set; }

      public string  City { get; set; }

      public string  AccType { get; set; }

      public string  DeclareBatch { get; set; }

      public string  GasStation { get; set; }

      public DateTime  ? PayDate { get; set; }

      public string  LoadWeb { get; set; }

      public decimal  ? AccLine { get; set; }

      public decimal  ? AccBigCarFecth { get; set; }

      public decimal  ? AccBigCarSend { get; set; }

      public decimal  ? AccBigcarOther { get; set; }

      public decimal  ? AccBigcarTotal { get; set; }

      public decimal  ? DriverTakePay { get; set; }

      public decimal  ? ZJBigCarFecthFee { get; set; }

      public decimal  ? ZJBigCarSendFee { get; set; }

      public decimal  ? ZJLandingFee { get; set; }

      public decimal  ? ZJOverWeightFee { get; set; }

      public decimal  ? ZJPressNightFee { get; set; }

      public decimal  ? ZJDeclareFee { get; set; }

      public decimal  ? ZJOtherFee { get; set; }

      public string  Provider { get; set; }

      public string  BelongCause { get; set; }

      public string  BelongArea { get; set; }

      public string  WebName { get; set; }

      public decimal  ? NowPay { get; set; }

      public decimal  ? FuelCard { get; set; }

      public decimal  ? BackPay { get; set; }

      public decimal  ? TakePay { get; set; }

      public decimal  ? RewardPunish { get; set; }

      public decimal  ? OilFee { get; set; }

      public decimal  ? DKFee { get; set; }

      public decimal  ? ZJFee { get; set; }

      public decimal  ? YuDa { get; set; }

      public decimal  ? DaPing { get; set; }

      public decimal  ? TingCheChang { get; set; }

      public decimal  ? WuHan { get; set; }

      public decimal  ? QingDao { get; set; }

      public decimal  ? NingBo { get; set; }

      public DateTime  ? appdate { get; set; }

      public string  oilCardNo { get; set; }

      public string  SerialNumber { get; set; }

      public decimal  ? leftMone { get; set; }
 

    }
}
    //----------basFinancialAudit结束----------
    