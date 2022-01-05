    //----------OperLog开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class OperLog//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  Id { get; set; }

      public string  Batch { get; set; }

      public string  BillNo { get; set; }

      public decimal  ? Account { get; set; }

      public DateTime  ? OperDate { get; set; }

      public string  OperMan { get; set; }

      public string  OperType { get; set; }

      public string  Content { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------OperLog结束----------
    