    //----------DirectDriverFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class DirectDriverFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? DirectDriverID { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public string  Lng { get; set; }

      public string  Lat { get; set; }

      public double  ? KmPrice { get; set; }

      public double  ? LowPrice { get; set; }

      public string  Remark { get; set; }

      public string  DirAddress { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------DirectDriverFee结束----------
    