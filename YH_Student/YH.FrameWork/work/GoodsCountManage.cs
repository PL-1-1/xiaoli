    //----------GoodsCountManage开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class GoodsCountManage//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  OperType { get; set; }

      public string  BillNo { get; set; }

      public decimal  OperWeight { get; set; }

      public int  Num { get; set; }

      public decimal  ActualOperWeight { get; set; }

      public int  ActualOperNum { get; set; }

      public DateTime  OperDate { get; set; }

      public string  OperMan { get; set; }

      public decimal  PerAvgOperWeight { get; set; }

      public string  CarLoding { get; set; }

      public string  BatchNo { get; set; }

      public string  operWebName { get; set; }

      public string  register { get; set; }

      public Guid  ? Id { get; set; }

      public string  OptCategory { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------GoodsCountManage结束----------
    