    //----------basModifyAcc开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basModifyAcc//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ModifyAccID { get; set; }

      public string  BillNO { get; set; }

      public string  SerialNumber { get; set; }

      public DateTime  ? ModifyDate { get; set; }

      public decimal  ? ModifyAcc { get; set; }

      public string  FeeType { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basModifyAcc结束----------
    