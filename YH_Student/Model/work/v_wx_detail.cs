    //----------v_wx_detail开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class v_wx_detail//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  wxunit { get; set; }

      public string  pjname { get; set; }

      public int  ? count { get; set; }

      public decimal  ? price { get; set; }

      public decimal  ? money { get; set; }
 

    }
}
    //----------v_wx_detail结束----------
    