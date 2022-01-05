    //----------VerifyOffAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class VerifyOffAccount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  VerifyOffAccountID { get; set; }

      public string  BillNo { get; set; }

      public string  BatchNo { get; set; }

      public string  VoucherNo { get; set; }

      public string  OneSubject { get; set; }

      public string  TwoSubject { get; set; }

      public string  ThreeSubject { get; set; }

      public string  Summary { get; set; }

      public string  VerifyOffType { get; set; }

      public decimal  ? Money { get; set; }

      public string  InOutType { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  WebName { get; set; }

      public string  VerifyStatus { get; set; }

      public string  OptMan { get; set; }

      public DateTime  ? OptTime { get; set; }

      public string  OptCancelMan { get; set; }

      public DateTime  ? OptCancelTime { get; set; }

      public int  ? ToOA { get; set; }

      public int  ? ToOAAPP { get; set; }

      public int  id { get; set; }

      public string  companyid { get; set; }

      public string  BillType { get; set; }

      public DateTime  ? credentialsTime { get; set; }

      public string  AccountType { get; set; }

      public string  MoneyAccount { get; set; }

      public Guid  ? CorrelationID { get; set; }

      public DateTime  ? AccDate { get; set; }

      public string  VerifMan { get; set; }
 

    }
}
    //----------VerifyOffAccount结束----------
    