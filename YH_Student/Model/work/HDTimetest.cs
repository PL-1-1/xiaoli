    //----------HDTimetest开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class HDTimetest//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  billno { get; set; }

      public string  SendOperator { get; set; }

      public DateTime  ? SendOperateTime { get; set; }

      public string  SendOperateWeb { get; set; }

      public string  SendOperateSite { get; set; }

      public string  SendOperateState { get; set; }

      public string  BackOperator { get; set; }

      public DateTime  ? BackOperateTime { get; set; }

      public string  BackOperateSite { get; set; }

      public string  BackOperateWeb { get; set; }

      public string  BackOperateState { get; set; }

      public string  ToFactoryOperator { get; set; }

      public DateTime  ? ToFactoryOperateTime { get; set; }

      public string  ToFactoryOperateSite { get; set; }

      public string  ToFactoryOperateWeb { get; set; }

      public string  ToFactoryOperateState { get; set; }
 

    }
}
    //----------HDTimetest结束----------
    