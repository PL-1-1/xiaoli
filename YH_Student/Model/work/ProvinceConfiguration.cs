    //----------ProvinceConfiguration开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ProvinceConfiguration//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  SubCompanyid { get; set; }

      public string  OperMan { get; set; }

      public string  OperWeb { get; set; }

      public DateTime  ? OperDate { get; set; }

      public string  MainCompanyname { get; set; }

      public string  SubCompanyname { get; set; }

      public int  id { get; set; }
 

    }
}
    //----------ProvinceConfiguration结束----------
    