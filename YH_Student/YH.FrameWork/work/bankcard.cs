    //----------bankcard开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class bankcard//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  userid { get; set; }

      public string  bankman { get; set; }

      public string  bankcode { get; set; }

      public string  bankname { get; set; }

      public string  bankid { get; set; }

      public string  cardid { get; set; }

      public string  phonenumber { get; set; }

      public string  bankimage { get; set; }

      public string  carPosimage { get; set; }

      public string  carRevimage { get; set; }
 

    }
}
    //----------bankcard结束----------
    