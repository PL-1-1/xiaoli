    //----------WayBill_Field开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBill_Field//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ID { get; set; }

      public string  FieldName { get; set; }

      public string  Field { get; set; }
 

    }
}
    //----------WayBill_Field结束----------
    