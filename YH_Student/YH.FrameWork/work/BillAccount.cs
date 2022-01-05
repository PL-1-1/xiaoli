    //----------BillAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillAccount//可以在这里加上基类等
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

      public decimal  Money { get; set; }

      public string  InOutType { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  WebName { get; set; }

      public string  VerifyStatus { get; set; }

      public string  OptMan { get; set; }

      public DateTime  OptTime { get; set; }

      public string  OptCancelMan { get; set; }

      public DateTime  ? OptCancelTime { get; set; }

      public int  ? ToOA { get; set; }

      public int  ? ToOAAPP { get; set; }

      public int  id { get; set; }

      public string  companyid { get; set; }

      public string  BillType { get; set; }

      public string  sjno { get; set; }

      public string  fpno { get; set; }

      public string  zpno { get; set; }

      public string  sgpz { get; set; }

      public string  SiteName { get; set; }

      public string  TheBillType { get; set; }

      public string  comefrom { get; set; }

      public string  optState { get; set; }

      public string  auditMan { get; set; }

      public DateTime  ? auditTime { get; set; }

      public string  theAuditMan { get; set; }

      public DateTime  ? theAuditTime { get; set; }

      public int  ? registrationState { get; set; }

      public DateTime  ? credentialsTime { get; set; }

      public string  OilCardNo { get; set; }

      public string  Remarks { get; set; }

      public string  AccountType { get; set; }

      public string  MoneyAccount { get; set; }

      public string  VerifyWeb { get; set; }

      public string  SterilisationNo { get; set; }

      public string  SubjectID { get; set; }

      public string  SubjectName { get; set; }

      public string  hm { get; set; }

      public string  zh { get; set; }

      public string  khh { get; set; }

      public string  szs { get; set; }

      public string  szshi { get; set; }

      public string  zzlx { get; set; }

      public string  aduitStateStr { get; set; }

      public string  CnAduitMan { get; set; }

      public DateTime  ? CnAduitTime { get; set; }

      public string  theCnAduitMan { get; set; }

      public DateTime  ? theCnAduitTime { get; set; }

      public DateTime  ? AccDate { get; set; }

      public string  VerifMan { get; set; }
 

    }
}
    //----------BillAccount结束----------
    