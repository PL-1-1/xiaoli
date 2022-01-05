    //----------SharedConsumption开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SharedConsumption//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SID { get; set; }

      public string  BillNo { get; set; }

      public string  WebName { get; set; }

      public string  Principal { get; set; }

      public string  PrincipalPhone { get; set; }

      public decimal  ? Amount { get; set; }

      public int  ? VerificationCode { get; set; }

      public string  OperMan { get; set; }

      public DateTime  ? OptTime { get; set; }

      public string  companyId { get; set; }
 

    }
}
    //----------SharedConsumption结束----------
    