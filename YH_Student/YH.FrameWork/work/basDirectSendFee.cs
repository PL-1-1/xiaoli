    //----------basDirectSendFee开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basDirectSendFee//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  DirectSendID { get; set; }

      public string  CenterName { get; set; }

      public string  DeliveryAddress { get; set; }

      public string  GPSLng { get; set; }

      public string  GPSLat { get; set; }

      public double  ? Price { get; set; }

      public string  TransferMode { get; set; }

      public string  Remark { get; set; }

      public string  SiteName { get; set; }

      public decimal  ? OperationWeight { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basDirectSendFee结束----------
    