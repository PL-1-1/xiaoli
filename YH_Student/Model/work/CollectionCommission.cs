    //----------CollectionCommission开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class CollectionCommission//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ID { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  WebName { get; set; }

      public DateTime  ? RegistrationDate { get; set; }

      public string  month { get; set; }

      public string  Revenue { get; set; }

      public string  CostType { get; set; }

      public int  ? Amount { get; set; }

      public string  Registrant { get; set; }

      public string  ConfirmingPerson { get; set; }

      public DateTime  ? ConfirmationDate { get; set; }

      public string  Auditor { get; set; }

      public DateTime  ? AuditorDate { get; set; }

      public string  DataDepartment { get; set; }

      //  public string abstract { get; set; }

      //public string  states { get; set; }

      //public string  VetoPerson { get; set; }

      //public DateTime  ? VetoTime { get; set; }

      //public string  Executor { get; set; }

      //public DateTime  ? executiontime { get; set; }

      //public string  TotalType { get; set; }

      //public string  BillNo { get; set; }

      //public string  companyid { get; set; }
 

    }
}
    //----------CollectionCommission结束----------
    