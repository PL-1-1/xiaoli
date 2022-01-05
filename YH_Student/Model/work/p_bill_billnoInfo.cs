    //----------p_bill_billnoInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class p_bill_billnoInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public int  ? state { get; set; }

      public string  unit { get; set; }

      public string  billno { get; set; }

      public string  webid { get; set; }

      public string  billtype { get; set; }

      public int  ? hxstate { get; set; }

      public DateTime  ? hxdate { get; set; }

      public string  hxcreateby { get; set; }

      public string  companyid { get; set; }

      public string  tProvince { get; set; }
 

    }
}
    //----------p_bill_billnoInfo结束----------
    