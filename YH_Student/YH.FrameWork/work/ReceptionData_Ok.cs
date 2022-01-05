    //----------ReceptionData_Ok开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ReceptionData_Ok//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  jsondata { get; set; }

      public DateTime  createtime { get; set; }

      public int  type { get; set; }

      public int  flag { get; set; }

      public int  hanldnum { get; set; }

      public DateTime  hanldtime { get; set; }

      public string  fromsys { get; set; }

      public string  fromcompany { get; set; }

      public string  excepleinfo { get; set; }
 

    }
}
    //----------ReceptionData_Ok结束----------
    