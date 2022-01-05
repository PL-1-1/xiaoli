    //----------ShortConnDetail2018开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ShortConnDetail2018//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  SCDId { get; set; }

      public string  BillNo { get; set; }

      public string  SCBatchNo { get; set; }

      public DateTime  ? SCDate { get; set; }

      public string  SCSite { get; set; }

      public string  SCWeb { get; set; }

      public string  SCCarNo { get; set; }

      public string  SCDriver { get; set; }

      public string  SCDesSite { get; set; }

      public string  SCDesWeb { get; set; }

      public string  SCDContolMan { get; set; }

      public string  SCAcceptMan { get; set; }

      public DateTime  ? SCAcceptTime { get; set; }

      public string  AcceptBillMan { get; set; }

      public DateTime  ? AcceptBillDate { get; set; }

      public string  SCDState { get; set; }

      public int  ? ShortToType { get; set; }

      public int  id { get; set; }

      public int  ? ShortWebCount { get; set; }

      public int  ? ScanQty { get; set; }

      public string  companyid { get; set; }

      public string  Descompanyid { get; set; }
 

    }
}
    //----------ShortConnDetail2018结束----------
    