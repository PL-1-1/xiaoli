    //----------FB_Setting开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class FB_Setting//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  CompanyId { get; set; }

      public string  AcceptCompanyId { get; set; }

      public string  AcceptSite { get; set; }

      public string  AcceptWebName { get; set; }

      public DateTime  ? OptDate { get; set; }

      public int  ? sf { get; set; }

      public int  ? zd { get; set; }
 

    }
}
    //----------FB_Setting结束----------
    