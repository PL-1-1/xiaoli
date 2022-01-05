    //----------SMS_Distribution开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SMS_Distribution//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  Companyid { get; set; }

      public string  CompanyName { get; set; }

      public decimal  ? ChargeMoney { get; set; }

      public DateTime  ? ChargeTime { get; set; }

      public decimal  ? ActualMoney { get; set; }

      public decimal  ? HandlingFee { get; set; }

      public int  ? ActualNum { get; set; }

      public int  ? ChargeNum { get; set; }

      public string  ChargeMan { get; set; }

      public string  ModifyMan { get; set; }

      public string  Remark { get; set; }

      public Guid  SID { get; set; }

      public int  ? chargeLeftMum { get; set; }
 

    }
}
    //----------SMS_Distribution结束----------
    