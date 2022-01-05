    //----------basSite开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basSite//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SiteId { get; set; }

      public string  SiteCode { get; set; }

      public string  SiteName { get; set; }

      public string  LineCode { get; set; }

      public string  SiteProvince { get; set; }

      public string  SiteCity { get; set; }

      public string  SiteAddress { get; set; }

      public string  SiteRemark { get; set; }

      public int  SiteStatus { get; set; }

      public string  ControlWeb { get; set; }

      public string  EndSiteRang { get; set; }

      public string  companyid { get; set; }

      public string  AllocateCompanyID { get; set; }

      public string  BelongToCompany { get; set; }
 

    }
}
    //----------basSite结束----------
    