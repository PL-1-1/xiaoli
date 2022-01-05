    //----------billUnusualRegister开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billUnusualRegister//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  Unid { get; set; }

      public string  RegisterMan { get; set; }

      public string  FeedBackDept { get; set; }

      public string  FeedBackMan { get; set; }

      public string  FeedBackContent { get; set; }

      public string  BadImgSrc1 { get; set; }

      public string  BadImgSrc2 { get; set; }

      public string  BillNO { get; set; }

      public DateTime  ? RegisterDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billUnusualRegister结束----------
    