    //----------billSign开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billSign//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SignNO { get; set; }

      public string  BillNO { get; set; }

      public string  SignType { get; set; }

      public string  SignMan { get; set; }

      public string  SignManPhone { get; set; }

      public string  SignManCardID { get; set; }

      public string  AgentMan { get; set; }

      public string  AgentManPhone { get; set; }

      public string  AgentCardId { get; set; }

      public DateTime  ? SignDate { get; set; }

      public string  SignDesc { get; set; }

      public string  SignOperator { get; set; }

      public string  SignSite { get; set; }

      public string  SignWeb { get; set; }

      public string  SignContent { get; set; }

      public string  DepartureListNO { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billSign结束----------
    