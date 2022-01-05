    //----------v_fy_project开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class v_fy_project//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  fyprojectid { get; set; }

      public string  projectname { get; set; }

      public int  ? type { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------v_fy_project结束----------
    