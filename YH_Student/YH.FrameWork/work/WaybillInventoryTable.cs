    //----------WaybillInventoryTable开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WaybillInventoryTable//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  BillNo { get; set; }

      public int  NumTotal { get; set; }

      public int  NumOperation { get; set; }

      public int  NumSurplus { get; set; }

      public int  BillState { get; set; }

      public int  CompanyId { get; set; }

      public int  NumUse { get; set; }
 

    }
}
    //----------WaybillInventoryTable结束----------
    