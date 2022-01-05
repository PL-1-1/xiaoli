    //----------s_vehicletype开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class s_vehicletype//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public double  ? volumn { get; set; }

      public double  ? weight { get; set; }

      public double  ? lenth { get; set; }

      public double  ? width { get; set; }

      public double  ? height { get; set; }

      public string  vehicletype { get; set; }

      public string  vehiclemodel { get; set; }
 

    }
}
    //----------s_vehicletype结束----------
    