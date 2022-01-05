    //----------basGridViewCol开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basGridViewCol//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  GridViewID { get; set; }

      public string  ColName { get; set; }

      public Guid  ? ColGuid { get; set; }

      public string  ColCaption { get; set; }

      public int  ? AllowEdit { get; set; }

      public int  ? Visible { get; set; }

      public int  ? AllowSummary { get; set; }

      public string  GirdViewRemark { get; set; }

      public string  FromProc { get; set; }

      public DateTime  LastUpdate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basGridViewCol结束----------
    