    //----------billSendGoods_pda开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billSendGoods_pda//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SendId { get; set; }

      public string  SendNO { get; set; }

      public string  BillNO { get; set; }

      public string  SendBatch { get; set; }

      public string  SendCarNO { get; set; }

      public string  SendDriver { get; set; }

      public string  SendDriverPhone { get; set; }

      public string  SendDesc { get; set; }

      public int  ? SendPCS { get; set; }

      public DateTime  ? SendDate { get; set; }

      public int  ? SendNUM { get; set; }

      public string  SendSite { get; set; }

      public string  SendWeb { get; set; }

      public string  SendToSite { get; set; }

      public string  SendToWeb { get; set; }

      public string  SendOperator { get; set; }

      public double  ? AccSend { get; set; }

      public int  ? SendVerifState { get; set; }

      public double  ? AccSendLast { get; set; }

      public string  VerifMan { get; set; }

      public DateTime  ? VerifDate { get; set; }

      public int  ? IsOut { get; set; }

      public string  SendDepartureListNo { get; set; }

      public int  ? BillState { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  AcceptMan { get; set; }

      public DateTime  ? AcceptTime { get; set; }

      public int  ? IsSigned { get; set; }

      public string  BegCauseName { get; set; }

      public string  BegAreaName { get; set; }

      public int  ? RemainSendPCS { get; set; }

      public int  id { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billSendGoods_pda结束----------
    