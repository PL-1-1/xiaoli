    //----------WaybillInventoryOperation开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WaybillInventoryOperation//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  ID { get; set; }

      public string  BillNo { get; set; }

      public int  NumOperation { get; set; }

      public string  OperationType { get; set; }

      public string  OperationWeb { get; set; }

      public DateTime  OperationTime { get; set; }

      public string  InventoryType { get; set; }

      public string  OperationMan { get; set; }

      public string  EndWeb { get; set; }

      public string  CompanyId { get; set; }
 

    }
}
    //----------WaybillInventoryOperation结束----------
    