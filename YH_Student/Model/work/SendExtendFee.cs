    //----------SendExtendFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SendExtendFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  SendSite { get; set; }

      public string  SendWeb { get; set; }

      public string  Cooperation { get; set; }

      public decimal  ? CarLength { get; set; }

      public decimal  ? Price { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------SendExtendFee结束----------
    