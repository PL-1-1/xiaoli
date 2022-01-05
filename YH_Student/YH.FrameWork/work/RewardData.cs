    //----------RewardData开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class RewardData//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ID { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DJWeb { get; set; }

      public DateTime  ? DJTime { get; set; }

      public string  TheMonth { get; set; }

      public string  Type { get; set; }

      public string  ResponsibilityWeb { get; set; }

      public string  ResponsibilityMan { get; set; }

      public decimal  ? Money { get; set; }

      public string  Abstract { get; set; }

      public string  RegisterMan { get; set; }

      public string  Billno { get; set; }

      public string  ResponsDepartNature { get; set; }

      public string  WithdrawingIssuDepart { get; set; }

      public string  Filenumber { get; set; }

      public string  isAudit { get; set; }

      public string  executeDepart { get; set; }

      public string  executeMan { get; set; }

      public DateTime  ? executeDate { get; set; }

      public string  CancelExecuteDepart { get; set; }

      public string  CancelExecuteMan { get; set; }

      public DateTime  ? CancelExecuteDate { get; set; }

      public string  companyid { get; set; }

      public string  BelongCenter { get; set; }

      public string  DJMan { get; set; }
 

    }
}
    //----------RewardData结束----------
    