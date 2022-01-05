    //----------BillSendGoods_KMS开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillSendGoods_KMS//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? SendDate { get; set; }

      public DateTime  ? BespeakDate { get; set; }

      public string  SendBatch { get; set; }

      public string  SendWeb { get; set; }

      public string  SendToWeb { get; set; }

      public int  ? SendPCS { get; set; }

      public int  ? Num { get; set; }

      public int  ? RemainSendPCS { get; set; }

      public string  SendDriver { get; set; }

      public string  SendDriverPhone { get; set; }

      public string  SendNO { get; set; }

      public string  SendCarNO { get; set; }

      public string  SendSite { get; set; }

      public string  SendToSite { get; set; }

      public double  ? AccSend { get; set; }

      public string  SendOperator { get; set; }

      public string  SendDesc { get; set; }

      public string  WebSendTel { get; set; }

      public string  AcceptMan { get; set; }

      public DateTime  ? AcceptTime { get; set; }

      public string  AcceptManPhone { get; set; }

      public DateTime  ? BillDate { get; set; }
 

    }
}
    //----------BillSendGoods_KMS结束----------
    