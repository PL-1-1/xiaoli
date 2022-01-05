    //----------sysRoleDataInfoClone开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysRoleDataInfoClone//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? GUID { get; set; }

      public string  GRName { get; set; }

      public string  GRCode { get; set; }

      public string  Remark { get; set; }

      public DateTime  ? CreateDate { get; set; }

      public string  CreateBy { get; set; }

      public string  SiteNames { get; set; }

      public DateTime  ? UpdateDate { get; set; }

      public string  UpdateBy { get; set; }
 

    }
}
    //----------sysRoleDataInfoClone结束----------
    