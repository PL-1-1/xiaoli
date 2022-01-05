    //----------StartMiddleSendRoute开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class StartMiddleSendRoute//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  Id { get; set; }

      public string  UseCauseName { get; set; }

      public string  UseAreaName { get; set; }

      public string  UseSiteName { get; set; }

      public string  UseWebName { get; set; }

      public string  BeginSite { get; set; }

      public string  EndSite { get; set; }

      public DateTime  ? CreateDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------StartMiddleSendRoute结束----------
    