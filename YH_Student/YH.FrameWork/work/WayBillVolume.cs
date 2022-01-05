    //----------WayBillVolume开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillVolume//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  VolId { get; set; }

      public string  BillNo { get; set; }

      public decimal  ? Length { get; set; }

      public decimal  ? Width { get; set; }

      public decimal  ? Height { get; set; }

      public int  ? Num { get; set; }

      public string  Packag { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------WayBillVolume结束----------
    