    //----------basReceiveCust开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basReceiveCust//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  RCID { get; set; }

      public string  CusID { get; set; }

      public string  BelongSite { get; set; }

      public string  BelongArea { get; set; }

      public string  RCName { get; set; }

      public string  ContactMan { get; set; }

      public string  ContactPhone { get; set; }

      public string  ContactCellPhone { get; set; }

      public string  RecievAddProv { get; set; }

      public string  RecievAddCity { get; set; }

      public string  RecievAddArea { get; set; }

      public string  RecievAddStreet { get; set; }

      public string  RecievAddress { get; set; }

      public string  ArriveSite { get; set; }

      public string  MidSite { get; set; }

      public string  TransferMode { get; set; }

      public string  DestinationWeb { get; set; }

      public DateTime  ? CooperateDate { get; set; }

      public string  BelongWeb { get; set; }

      public int  ? IsDelete { get; set; }

      public DateTime  ? ModifyDate { get; set; }

      public string  Remark { get; set; }

      public string  companyid { get; set; }

      public string  CusRemarkInfo { get; set; }
 

    }
}
    //----------basReceiveCust结束----------
    