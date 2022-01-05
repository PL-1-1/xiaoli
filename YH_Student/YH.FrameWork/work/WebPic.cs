    //----------WebPic开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WebPic//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  FileID { get; set; }

      public string  FileName { get; set; }

      public string  FileMD5 { get; set; }

      public DateTime  UpdateDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------WebPic结束----------
    