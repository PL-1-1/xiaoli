    //----------WayBillFile开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillFile//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? FileGuid { get; set; }

      public string  BillNo { get; set; }

      public string  FilePath { get; set; }

      public string  FileName { get; set; }

      public string  UpFileMan { get; set; }

      public DateTime  ? UpFileDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------WayBillFile结束----------
    