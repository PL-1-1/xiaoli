    //----------NoticeInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class NoticeInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  noticetitle { get; set; }

      public DateTime  ? noticedate { get; set; }

      public string  noticeimg { get; set; }

      public string  noticecontent { get; set; }

      public string  noticeurl { get; set; }
 

    }
}
    //----------NoticeInfo结束----------
    