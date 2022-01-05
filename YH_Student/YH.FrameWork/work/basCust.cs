    //----------basCust开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basCust//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  CustID { get; set; }

      public string  CustNo { get; set; }

      public string  CusName { get; set; }

      public string  CusType { get; set; }

      public string  CusTag { get; set; }

      public string  ContactMan { get; set; }

      public string  ContactPhone { get; set; }

      public string  ContactCellPhone { get; set; }

      public string  CusEmail { get; set; }

      public string  CusAddress { get; set; }

      public string  PayWay { get; set; }

      public DateTime  ? CooperateDate { get; set; }

      public string  BankName { get; set; }

      public string  BankUserName { get; set; }

      public string  BankAdd { get; set; }

      public string  BankAccount { get; set; }

      public string  BelongSite { get; set; }

      public string  BelongWeb { get; set; }

      public string  BelongDep { get; set; }

      public string  BelongCause { get; set; }

      public string  BelongArea { get; set; }

      public string  AlwaysSend { get; set; }

      public string  GoodsPackag { get; set; }

      public string  LoadRequir { get; set; }

      public string  SendRequir { get; set; }

      public string  MidRequir { get; set; }

      public string  Salesman { get; set; }

      public string  CusRemark { get; set; }

      public string  CusFeeType { get; set; }

      public string  CusDiscount { get; set; }

      public int  ? IsDelete { get; set; }

      public DateTime  ? ModifyDate { get; set; }

      public string  companyid { get; set; }

      public string  CusIdName { get; set; }

      public string  CusIdNum { get; set; }

      public string  CusRemarkInfo { get; set; }
 

    }
}
    //----------basCust结束----------
    