    //----------ProvisionInfoManage开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ProvisionInfoManage//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? Id { get; set; }

      public string  CDCauseName { get; set; }

      public string  CDAreaName { get; set; }

      public string  CDWebName { get; set; }

      public string  ProvisionType { get; set; }

      public string  ProvisionSub { get; set; }

      public string  ReMark { get; set; }

      public decimal  ? ProvisionAmount { get; set; }

      public string  FlowId { get; set; }

      public DateTime  ? RegisDate { get; set; }

      public string  RegisMan { get; set; }

      public string  RegisDep { get; set; }

      public int  ? QRState { get; set; }

      public DateTime  ? QRDate { get; set; }

      public string  QRMan { get; set; }

      public string  QRDep { get; set; }

      public DateTime  ? QXDate { get; set; }

      public string  QXMan { get; set; }

      public string  QXDep { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------ProvisionInfoManage结束----------
    