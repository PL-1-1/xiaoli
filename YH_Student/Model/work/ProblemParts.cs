    //----------ProblemParts开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ProblemParts//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  Billno { get; set; }

      public string  EntryState { get; set; }

      public string  IsCustomerProblem { get; set; }

      public string  CustomerRequirement { get; set; }

      public string  ZXORGJ { get; set; }

      public string  EntryDepartment { get; set; }

      public string  EntryMan { get; set; }

      public string  ProblemDescription { get; set; }

      public string  ReceivingDepartment { get; set; }

      public string  ReceivingMan { get; set; }

      public string  IsKnown { get; set; }

      public string  FollowUp { get; set; }

      public string  FollowUpPerson { get; set; }

      public string  ProblemType { get; set; }

      public DateTime  ? EntryTime { get; set; }

      public DateTime  ? ReceivingTime { get; set; }

      public DateTime  ? FollowUpTime { get; set; }

      public DateTime  ? TurnCustomerTime { get; set; }

      public string  TurnCustomerMan { get; set; }

      public string  PartTimeProblemPart { get; set; }

      public string  CompanyId { get; set; }
 

    }
}
    //----------ProblemParts结束----------
    