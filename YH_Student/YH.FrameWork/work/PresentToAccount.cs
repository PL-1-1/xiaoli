    //----------PresentToAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class PresentToAccount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  AID { get; set; }

      public string  BillNO { get; set; }

      public DateTime  ? ChangeDate { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  PayToSite { get; set; }

      public string  FeeType { get; set; }

      public string  INOROUT { get; set; }

      public decimal  ? Money { get; set; }

      public string  OptMan { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------PresentToAccount结束----------
    