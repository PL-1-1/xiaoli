    //----------p_bill_Treasury开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class p_bill_Treasury//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  tId { get; set; }

      public string  tBatch { get; set; }

      public string  tProcurement { get; set; }

      public string  tBillType { get; set; }

      public DateTime  ? tPtime { get; set; }

      public decimal  ? tPrice { get; set; }

      public decimal  ? tTotal { get; set; }

      public string  tCreateBy { get; set; }

      public DateTime  ? tEntryTime { get; set; }

      public string  tRecord { get; set; }

      public string  tRemark { get; set; }

      public string  tBnum { get; set; }

      public string  tEnum { get; set; }

      public int  ? tBundle { get; set; }

      public int  ? tPage { get; set; }

      public string  companyid { get; set; }

      public string  tProvince { get; set; }
 

    }
}
    //----------p_bill_Treasury结束----------
    