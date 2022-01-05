    //----------basRightGroupTreeZQ开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basRightGroupTreeZQ//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  MGuid { get; set; }

      public int  ID { get; set; }

      public int  ParentID { get; set; }

      public string  MenuName { get; set; }

      public string  MenuTag { get; set; }

      public int  ? ComeFrom { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basRightGroupTreeZQ结束----------
    