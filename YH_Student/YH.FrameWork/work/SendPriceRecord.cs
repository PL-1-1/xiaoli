    //----------SendPriceRecord开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SendPriceRecord//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? SignDate { get; set; }

      public string  SignAddress { get; set; }

      public decimal  ? Price { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------SendPriceRecord结束----------
    