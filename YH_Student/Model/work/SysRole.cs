    //----------SysRole开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysRole//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  RoleId { get; set; }

      public string  RoleName { get; set; }

      public string  Remark { get; set; }

      public long  ? DeptId { get; set; }

      public DateTime  ? CreateTime { get; set; }
 

    }
}
    //----------SysRole结束----------
    