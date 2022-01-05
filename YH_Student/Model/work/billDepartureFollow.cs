    //----------billDepartureFollow开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billDepartureFollow//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  WebFollowNO { get; set; }

      public string  DepartureBatch { get; set; }

      public string  FollowContent { get; set; }

      public DateTime  ? FollowDate { get; set; }

      public string  companyid { get; set; }

      public string  TrackerName { get; set; }

      public string  SendSource { get; set; }
 

    }
}
    //----------billDepartureFollow结束----------
    