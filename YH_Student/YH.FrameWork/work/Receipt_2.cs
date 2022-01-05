    //----------Receipt_2开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class Receipt_2//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  RecId { get; set; }

      public string  BillNO { get; set; }

      public string  OperateType { get; set; }

      public string  Operator { get; set; }

      public DateTime  ? OperateTime { get; set; }

      public string  OperateRemark { get; set; }

      public string  OperateSite { get; set; }

      public string  OperateWeb { get; set; }

      public string  ToSite { get; set; }

      public string  ToWeb { get; set; }

      public string  RecBatch { get; set; }

      public string  SendNum { get; set; }

      public string  OperateState { get; set; }

      public string  LinkTel { get; set; }

      public int  id { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------Receipt_2结束----------
    