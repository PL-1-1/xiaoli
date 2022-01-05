    //----------WebContrast开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WebContrast//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  BeginWeb { get; set; }

      public string  EndWeb { get; set; }

      public string  companyid { get; set; }

      public string  OperMan { get; set; }

      public string  OperWeb { get; set; }

      public DateTime  ? OperDate { get; set; }
 

    }
}
    //----------WebContrast结束----------
    