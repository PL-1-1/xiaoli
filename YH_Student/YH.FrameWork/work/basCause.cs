    //----------basCause开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basCause//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  CauseID { get; set; }

      public string  CauseName { get; set; }

      public string  CauseCode { get; set; }

      public string  CauseMan { get; set; }

      public string  CausePhone { get; set; }

      public string  CauseRemark { get; set; }

      public int  ? CauseAccount { get; set; }

      public string  UserDB { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basCause结束----------
    