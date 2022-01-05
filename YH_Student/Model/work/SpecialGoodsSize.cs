    //----------SpecialGoodsSize开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SpecialGoodsSize//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  BillNo { get; set; }

      public decimal  ? Length { get; set; }

      public decimal  ? Width { get; set; }

      public decimal  ? Height { get; set; }

      public string  Varieties { get; set; }

      public string  Package { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------SpecialGoodsSize结束----------
    