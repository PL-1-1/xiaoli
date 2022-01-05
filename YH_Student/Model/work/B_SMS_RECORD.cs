    //----------B_SMS_RECORD开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class B_SMS_RECORD//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ? smsstate { get; set; }

      public string  fshipper { get; set; }

      public string  telephone { get; set; }

      public string  content { get; set; }

      public DateTime  ? senddate { get; set; }

      public string  createby { get; set; }

      public string  billno { get; set; }

      public string  bsite { get; set; }

      public string  webid { get; set; }

      public int  ? mbcount { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  companyid { get; set; }

      public string  smsAisle { get; set; }

      public string  smsNode { get; set; }
 

    }
}
    //----------B_SMS_RECORD结束----------
    