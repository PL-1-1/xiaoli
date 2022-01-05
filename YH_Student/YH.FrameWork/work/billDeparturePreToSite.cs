    //----------billDeparturePreToSite开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDeparturePreToSite//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ToSiteNO { get; set; }

      public string  DepartureBatch { get; set; }

      public string  ToSite { get; set; }

      public decimal  ? AccToPay { get; set; }

      public decimal  ? AccUnload { get; set; }

      public string  UnloadAccSite { get; set; }

      public string  UnloadAccDept { get; set; }

      public DateTime  ? UnloadDate { get; set; }

      public string  UnloadMan { get; set; }

      public string  UnloaderPhone { get; set; }

      public string  UnloadDesc { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billDeparturePreToSite结束----------
    