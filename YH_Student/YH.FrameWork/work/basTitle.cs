    //----------basTitle开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basTitle//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  TitId { get; set; }

      public string  TitName { get; set; }

      public string  TitInstruc { get; set; }

      public string  TitRemark { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basTitle结束----------
    