    //----------basJobs开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basJobs//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  JobId { get; set; }

      public string  JobName { get; set; }

      public string  JobInstruc { get; set; }

      public string  JobRemark { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basJobs结束----------
    