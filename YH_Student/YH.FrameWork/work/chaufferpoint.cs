    //----------chaufferpoint开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class chaufferpoint//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public DateTime  ? uploaddate { get; set; }

      public string  lng { get; set; }

      public string  lat { get; set; }

      public string  userid { get; set; }
 

    }
}
    //----------chaufferpoint结束----------
    