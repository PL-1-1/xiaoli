    //----------SysRoleDept开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SysRoleDept//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  Id { get; set; }

      public long  ? RoleId { get; set; }

      public long  ? deptId { get; set; }
 

    }
}
    //----------SysRoleDept结束----------
    