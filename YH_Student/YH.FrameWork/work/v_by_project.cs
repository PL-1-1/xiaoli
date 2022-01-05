    //----------v_by_project开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class v_by_project//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  byprojectid { get; set; }

      public string  projectname { get; set; }

      public int  ? byjg { get; set; }

      public string  remark { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------v_by_project结束----------
    