    //----------image_path开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class image_path//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  gid { get; set; }

      public int  ? imagetypeid { get; set; }

      public string  imagepath { get; set; }

      public string  pid { get; set; }

      public DateTime  ? uploaddate { get; set; }

      public string  imagetype { get; set; }
 

    }
}
    //----------image_path结束----------
    