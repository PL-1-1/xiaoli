    //----------ShortDeparture_Asy开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ShortDeparture_Asy//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public long  Face_ID { get; set; }

      public string  FutionName { get; set; }

      public string  FaceUrl { get; set; }

      public string  FaceJson { get; set; }

      public string  ResultMessage { get; set; }

      public string  OperMan { get; set; }

      public string  OperWeb { get; set; }

      public DateTime  ? OperDate { get; set; }

      public int  ? SendCount { get; set; }

      public string  Batch { get; set; }

      public string  FaceState { get; set; }

      public string  BillNo { get; set; }

      public string  companyid { get; set; }

      public int  ? RequestState { get; set; }

      public int  ? RequestCount { get; set; }

      public string  NodeName { get; set; }
 

    }
}
    //----------ShortDeparture_Asy结束----------
    