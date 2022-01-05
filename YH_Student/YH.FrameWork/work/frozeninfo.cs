    //----------frozeninfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class frozeninfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  userid { get; set; }

      public string  orderno { get; set; }

      public string  unit { get; set; }

      public DateTime  ? frozendate { get; set; }

      public double  ? frozenacc { get; set; }

      public int  ? state { get; set; }

      public string  orderid { get; set; }

      public string  opertype { get; set; }

      public DateTime  ? thawingdate { get; set; }
 

    }
}
    //----------frozeninfo结束----------
    