    //----------b_updater_barcode开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_updater_barcode//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ? version { get; set; }

      public byte[]  app { get; set; }

      public string  filename { get; set; }

      public DateTime  ? lastupdate { get; set; }

      public string  updateman { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------b_updater_barcode结束----------
    