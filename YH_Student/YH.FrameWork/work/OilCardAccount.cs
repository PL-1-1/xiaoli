    //----------OilCardAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class OilCardAccount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public int  OilCardId { get; set; }

      public decimal  Acc { get; set; }

      public string  OperMan { get; set; }

      public DateTime  OperDate { get; set; }

      public string  checkweb { get; set; }

      public int  ? ToOA { get; set; }

      public int  ? ToOAAPP { get; set; }

      public int  ? ToOAAPPOA { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------OilCardAccount结束----------
    