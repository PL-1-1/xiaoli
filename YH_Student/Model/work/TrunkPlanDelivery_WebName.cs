    //----------TrunkPlanDelivery_WebName开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class TrunkPlanDelivery_WebName//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  DeliCode { get; set; }

      public string  ToWeb { get; set; }

      public string  ReceivProvince { get; set; }

      public string  ReceivCity { get; set; }

      public string  ReceivArea { get; set; }

      public string  ReceivStreet { get; set; }

      public string  ReceivAddress { get; set; }

      public string  ReceivPhone { get; set; }

      public DateTime  ? LoadSendCarDate { get; set; }

      public string  OptionType { get; set; }

      public int  ? Sn { get; set; }

      public string  ConPeople { get; set; }

      public string  StationNo { get; set; }

      public int  DeliId { get; set; }
 

    }
}
    //----------TrunkPlanDelivery_WebName结束----------
    