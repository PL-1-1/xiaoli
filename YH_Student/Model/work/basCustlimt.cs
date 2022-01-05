    //----------basCustlimt开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basCustlimt//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  CustNo { get; set; }

      public string  CustName { get; set; }

      public string  CustType { get; set; }

      public string  CustTag { get; set; }

      public string  ContactMan { get; set; }

      public string  ContactPhone { get; set; }

      public string  ContactCellPhone { get; set; }

      public string  BelongSite { get; set; }

      public string  BelongWeb { get; set; }

      public string  BelongCause { get; set; }

      public string  BelongArea { get; set; }

      public string  opetWeb { get; set; }

      public string  opetMan { get; set; }

      public DateTime  ? opetData { get; set; }

      public Guid  ? basCustlimtID { get; set; }
 

    }
}
    //----------basCustlimt结束----------
    