    //----------OpinionInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class OpinionInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  userid { get; set; }

      public DateTime  ? opiniondate { get; set; }

      public string  opinioncontent { get; set; }
 

    }
}
    //----------OpinionInfo结束----------
    