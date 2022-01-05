    //----------b_app_update开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_app_update//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  VersionName { get; set; }

      public int  ? VersionCode { get; set; }

      public string  remark { get; set; }

      public DateTime  ? createTime { get; set; }

      public string  appName { get; set; }
 

    }
}
    //----------b_app_update结束----------
    