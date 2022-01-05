    //----------tab_modify开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class tab_modify//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  name { get; set; }

      public string  remark { get; set; }

      public string  typename { get; set; }

      public string  oldvalue { get; set; }

      public string  newvalue { get; set; }

      public DateTime  modifydate { get; set; }

      public string  useraccount { get; set; }

      public string  username { get; set; }

      public string  tabname { get; set; }
 

    }
}
    //----------tab_modify结束----------
    