    //----------sysUser开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysUser//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  UserId { get; set; }

      public string  Username { get; set; }

      public string  Password { get; set; }

      public string  Salt { get; set; }

      public string  Email { get; set; }

      public string  Mobile { get; set; }

      public byte  ? Status { get; set; }

      public long  ? DeptId { get; set; }

      public DateTime  ? CreateTime { get; set; }
 

    }
}
    //----------sysUser结束----------
    