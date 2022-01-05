    //----------badInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class badInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  badInfoID { get; set; }

      public int  ID { get; set; }

      public int  pID { get; set; }

      public string  title { get; set; }

      public decimal  ? money { get; set; }

      public decimal  ? FoundPersonMoney { get; set; }
 

    }
}
    //----------badInfo结束----------
    