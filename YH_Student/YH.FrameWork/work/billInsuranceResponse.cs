    //----------billInsuranceResponse开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billInsuranceResponse//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  InsuranceNO { get; set; }

      public string  BillNo { get; set; }

      public string  JsonText { get; set; }

      public string  State { get; set; }

      public DateTime  ? SendDate { get; set; }

      public DateTime  CreateDate { get; set; }

      public string  SequenceCode { get; set; }

      public string  ResponceState { get; set; }

      public string  ResponceContent { get; set; }

      public string  ResponcePolicyGuid { get; set; }

      public string  RequestURL { get; set; }

      public string  ResponseURL { get; set; }

      public string  RequestCount { get; set; }

      public DateTime  ? LastSendDate { get; set; }

      public DateTime  ? BillDate { get; set; }

      public string  Varieties { get; set; }

      public string  Package { get; set; }

      public int  ? num { get; set; }

      public decimal  ? FeeWeight { get; set; }

      public decimal  ? OperationWeight { get; set; }

      public decimal  ? FeeVolume { get; set; }

      public string  ReceivProvince { get; set; }

      public string  ReceivCity { get; set; }

      public string  ReceivArea { get; set; }

      public string  ReceivStreet { get; set; }

      public string  ReceivAddress { get; set; }

      public string  StartProvince { get; set; }

      public string  StartCity { get; set; }

      public string  StartAddress { get; set; }

      public decimal  ? DeclareValue { get; set; }

      public decimal  ? SupportValue { get; set; }

      public decimal  ? SupportValue_C { get; set; }

      public string  ConsignorCompany { get; set; }

      public string  ConsignorName { get; set; }

      public string  ConsignorCellPhone { get; set; }

      public string  ConsignorPhone { get; set; }

      public string  ConsigneeCompany { get; set; }

      public string  ConsigneeName { get; set; }

      public string  ConsigneeCellPhone { get; set; }

      public string  ConsigneePhone { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billInsuranceResponse结束----------
    