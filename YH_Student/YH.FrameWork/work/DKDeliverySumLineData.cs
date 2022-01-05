    //----------DKDeliverySumLineData开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class DKDeliverySumLineData//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  StartSite { get; set; }

      public string  TransferSite { get; set; }

      public decimal  ? DeliveryFreight { get; set; }

      public string  yeartype { get; set; }

      public string  monthtype { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------DKDeliverySumLineData结束----------
    