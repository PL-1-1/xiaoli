    //----------networkKilometers开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class networkKilometers//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  startsite { get; set; }

      public string  startweb { get; set; }

      public string  ReceivProvince { get; set; }

      public string  ReceivCity { get; set; }

      public string  ReceivArea { get; set; }

      public string  ReceivStreet { get; set; }

      public string  longitude { get; set; }

      public string  latitude { get; set; }

      public string  destinationPoint { get; set; }

      public string  Kilometers { get; set; }

      public DateTime  ? CreationTime { get; set; }

      public Guid  id { get; set; }
 

    }
}
    //----------networkKilometers结束----------
    