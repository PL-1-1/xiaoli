    //----------billdamage开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billdamage//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  billno { get; set; }

      public string  batchno { get; set; }

      public string  opttype { get; set; }

      public string  optid { get; set; }

      public string  damagesite { get; set; }

      public string  damageweb { get; set; }

      public int  ? num { get; set; }

      public int  ? damagenum { get; set; }

      public string  damagereason { get; set; }

      public string  optman { get; set; }

      public DateTime  ? optdate { get; set; }

      public string  optsite { get; set; }

      public string  optweb { get; set; }

      public string  kctype { get; set; }

      public string  OptState { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billdamage结束----------
    