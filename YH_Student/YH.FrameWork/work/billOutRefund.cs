    //----------billOutRefund开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billOutRefund//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  billNo { get; set; }

      public string  batchNo { get; set; }

      public string  feeType { get; set; }

      public decimal  ? refundMoney { get; set; }

      public string  refundStatus { get; set; }

      public DateTime  ? refundDate { get; set; }

      public string  refundMan { get; set; }

      public int  ? AID { get; set; }

      public string  companyid { get; set; }

      public Guid  ? id { get; set; }
 

    }
}
    //----------billOutRefund结束----------
    