    //----------suozhuang开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class suozhuang//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  发站省份 { get; set; }

      public string  发站城市 { get; set; }

      public string  到站省份 { get; set; }

      public string  到站城市 { get; set; }

      public string  到站区县 { get; set; }

      public string  中转城市 { get; set; }

      public double  ? 最低一票 { get; set; }

      public double  ? 重量单价 { get; set; }

      public double  ? 体积单价 { get; set; }

      public string  产品 { get; set; }

      public string  时效 { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------suozhuang结束----------
    