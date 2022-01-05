    //----------reportorder开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class reportorder//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  orderid { get; set; }

      public string  userid { get; set; }

      public string  lng { get; set; }

      public string  lat { get; set; }

      public DateTime  ? reporttime { get; set; }

      public string  location { get; set; }

      public string  orderinfoid { get; set; }

      public int  ? reporttypeid { get; set; }

      public string  gid { get; set; }
 

    }
}
    //----------reportorder结束----------
    