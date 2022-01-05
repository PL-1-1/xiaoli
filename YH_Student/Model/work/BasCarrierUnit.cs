    //----------BasCarrierUnit开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BasCarrierUnit//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  CUId { get; set; }

      public string  CompanyName { get; set; }

      public string  CUSite { get; set; }

      public string  CUWeb { get; set; }

      public string  Mainline { get; set; }

      public string  CUArriveSite { get; set; }

      public string  MinimumBill { get; set; }

      public double  ? HeavyPrice { get; set; }

      public double  ? LightPrice { get; set; }

      public double  ? DeliFee { get; set; }

      public string  AriiveMan { get; set; }

      public string  ArrivePhone { get; set; }

      public string  ArriveCellPhone { get; set; }

      public string  ArriveAddress { get; set; }

      public string  Salesman { get; set; }

      public string  SalesPhone { get; set; }

      public string  SalesCellPhone { get; set; }

      public string  SalesAddress { get; set; }

      public string  CreditLevel { get; set; }

      public string  IsSigned { get; set; }

      public string  LegalPerson { get; set; }

      public double  ? Deposit { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------BasCarrierUnit结束----------
    