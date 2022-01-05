    //----------v_pj_guige开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class v_pj_guige//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  pjid { get; set; }

      public string  pjname { get; set; }

      public string  units { get; set; }

      public decimal  ? jhprice { get; set; }

      public int  ? nowcount { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------v_pj_guige结束----------
    