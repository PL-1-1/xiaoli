    //----------basCustContract开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basCustContract//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  basCustContractID { get; set; }

      public string  ShortName { get; set; }

      public string  FullName { get; set; }

      public string  CpyLegalPerson { get; set; }

      public string  RegistCapital { get; set; }

      public string  RegistAdd { get; set; }

      public string  RunAdd { get; set; }

      public string  CustLinkName { get; set; }

      public string  SendCustTel { get; set; }

      public string  SendCustMobile { get; set; }

      public string  CheckBillLinkName { get; set; }

      public string  CheckBillTel { get; set; }

      public string  ContractNo { get; set; }

      public DateTime  ? BeginDate { get; set; }

      public DateTime  ? EndDate { get; set; }

      public DateTime  ? ContractDate { get; set; }

      public DateTime  ? crDate { get; set; }

      public string  ApplyName { get; set; }

      public string  UnitDeptName { get; set; }

      public int  ? CreditDays { get; set; }

      public decimal  ? CreditLimit { get; set; }

      public string  PayCycle { get; set; }

      public int  ? MonthlyDelayDays { get; set; }

      public decimal  ? MonthlyDelayLimit { get; set; }

      public int  ? ReturnBillDelayDays { get; set; }

      public string  Operator { get; set; }

      public string  CustTypeValue { get; set; }

      public string  MonthSiteName { get; set; }

      public string  MonthWebName { get; set; }

      public string  custpwd { get; set; }

      public string  GatheringMan { get; set; }

      public DateTime  ? modifiedDate { get; set; }

      public string  companyid { get; set; }

      public string  AttriWeb { get; set; }

      public string  Attribution { get; set; }

      public string  AttriPhone { get; set; }

      public string  TaxNo { get; set; }

      public string  UserBack { get; set; }

      public string  UserAccount { get; set; }

      public int  ? FetchToOwe { get; set; }

      public string  PaymentMethod { get; set; }

      public string  Salesman { get; set; }
 

    }
}
    //----------basCustContract结束----------
    