    //----------FindGoodsImage开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class FindGoodsImage//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  Id { get; set; }

      public Guid  GoodsId { get; set; }

      public string  FilePath { get; set; }

      public string  FileThPath { get; set; }

      public string  OperMan { get; set; }

      public DateTime  OperDate { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DepName { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public string  companyid { get; set; }

      public string  ImageID { get; set; }
 

    }
}
    //----------FindGoodsImage结束----------
    