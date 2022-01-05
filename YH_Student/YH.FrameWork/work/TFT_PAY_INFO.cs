    //----------TFT_PAY_INFO开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class TFT_PAY_INFO//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public DateTime  ? paySysDate { get; set; }

      public string  serialNum { get; set; }

      public string  merNo { get; set; }

      public string  merOrderId { get; set; }

      public string  merOrderName { get; set; }

      public string  merShortName { get; set; }

      public decimal  ? price { get; set; }

      public decimal  ? merOrderAmt { get; set; }

      public int  ? merOrderCount { get; set; }

      public int  ? payType { get; set; }

      public string  salePayAcct { get; set; }

      public string  custPayAcct { get; set; }

      public string  merOrderStatus { get; set; }

      public string  payUrl { get; set; }

      public string  Errorcode { get; set; }

      public string  returnMessage { get; set; }

      public string  signval { get; set; }

      public DateTime  ? optdate { get; set; }

      public string  accountNo { get; set; }

      public string  accountName { get; set; }

      public string  payMode { get; set; }

      public string  inKey { get; set; }

      public DateTime  ? indate { get; set; }

      public string  custPhone { get; set; }

      public int  ? paystatus { get; set; }

      public decimal  ? charge { get; set; }

      public string  companyid { get; set; }

      public string  account_number { get; set; }
 

    }
}
    //----------TFT_PAY_INFO结束----------
    