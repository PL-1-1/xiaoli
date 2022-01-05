    //----------B_chauffer开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class B_chauffer//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  chaufferno { get; set; }

      public string  chauffername { get; set; }

      public int  ? sex { get; set; }

      public int  ? age { get; set; }

      public string  shenfenzheng { get; set; }

      public string  jiashizheng { get; set; }

      public int  ? jiashiyuanjibie { get; set; }

      public string  phone { get; set; }

      public string  mobilephone { get; set; }

      public string  address { get; set; }

      public int  ? jialin { get; set; }

      public string  jiazhengjibie { get; set; }

      public DateTime  ? jiazhengqixian { get; set; }

      public string  baoxianxinxi { get; set; }

      public DateTime  ? baoxianqixian { get; set; }

      public int  ? kaoping { get; set; }

      public int  ? state { get; set; }

      public DateTime  ? ruzhiTime { get; set; }

      public string  vehicleno { get; set; }

      public DateTime  ? businessterm { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------B_chauffer结束----------
    