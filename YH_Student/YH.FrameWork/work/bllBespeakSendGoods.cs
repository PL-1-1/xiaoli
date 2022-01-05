    //----------bllBespeakSendGoods开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class bllBespeakSendGoods//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  BespeakID { get; set; }

      public DateTime  ? BespeakDate { get; set; }

      public string  BespeakRequir { get; set; }

      public string  Operator { get; set; }

      public string  BespeakDept { get; set; }

      public string  BillNO { get; set; }

      public DateTime  ? SendGoodsDate { get; set; }

      public string  ISOK { get; set; }

      public string  BespeakRemark { get; set; }

      public DateTime  ? Operdate { get; set; }

      public int  id { get; set; }

      public DateTime  ? customStartDate { get; set; }

      public DateTime  ? customEndDate { get; set; }

      public string  CarTypeRequir { get; set; }

      public string  BringManRequir { get; set; }

      public string  OperRequir { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------bllBespeakSendGoods结束----------
    