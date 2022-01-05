    //----------ShortConnMonth开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ShortConnMonth//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SCId { get; set; }

      public string  SCBatchNo { get; set; }

      public DateTime  ? SCDate { get; set; }

      public string  SCSite { get; set; }

      public string  SCWeb { get; set; }

      public string  SCCarNo { get; set; }

      public string  SCDriver { get; set; }

      public string  SCDesSite { get; set; }

      public string  SCDesWeb { get; set; }

      public string  SCMan { get; set; }

      public double  ? SCFee { get; set; }

      public double  ? SCFeeBalance { get; set; }

      public int  ? SCVerifState { get; set; }

      public string  SCVerifMan { get; set; }

      public DateTime  ? SCVerifDate { get; set; }

      public string  SCAcceptMan { get; set; }

      public DateTime  ? SCAcceptTime { get; set; }

      public string  SCDriverPhone { get; set; }

      public string  SCState { get; set; }

      public string  Cooperation { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  ShortBargeType { get; set; }

      public string  SCAcceptGoodsMan { get; set; }

      public string  SCAcceptGoodsTime { get; set; }

      public string  SCGOODState { get; set; }

      public string  DeliCode { get; set; }

      public string  CarManageDep { get; set; }

      public int  ? BillToType { get; set; }

      public DateTime  ? DownGoodsTime { get; set; }

      public string  CarType { get; set; }

      public string  CarLength { get; set; }

      public string  CarWidth { get; set; }

      public string  CarHeight { get; set; }

      public decimal  ? NetWeight { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------ShortConnMonth结束----------
    