    //----------PublicNumberMember开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class PublicNumberMember//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  openid { get; set; }

      public string  mobile { get; set; }

      public string  nickname { get; set; }

      public string  avatar { get; set; }

      public string  province { get; set; }

      public string  city { get; set; }

      public DateTime  ? bindingtime { get; set; }

      public DateTime  createtime { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------PublicNumberMember结束----------
    