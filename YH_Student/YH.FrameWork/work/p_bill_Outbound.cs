    //----------p_bill_Outbound开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class p_bill_Outbound//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  oId { get; set; }

      public string  oBatch { get; set; }

      public string  oBillType { get; set; }

      public string  oBBno { get; set; }

      public string  oBEno { get; set; }

      public int  ? oBundle { get; set; }

      public string  oCreateBy { get; set; }

      public DateTime  ? oTime { get; set; }

      public string  oRecord { get; set; }

      public string  oRemark { get; set; }

      public string  webid { get; set; }

      public string  lingdangren { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------p_bill_Outbound结束----------
    