    //----------BuKou开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BuKou//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  Project { get; set; }

      public string  FeeType { get; set; }

      public string  FromMan { get; set; }

      public DateTime  ? OperDate { get; set; }

      public string  OperMan { get; set; }

      public decimal  ? Account { get; set; }

      public string  ToMan { get; set; }

      public string  Remark { get; set; }

      public string  BillNo { get; set; }

      public string  ApplyState { get; set; }

      public string  ApplyMan { get; set; }

      public DateTime  ? ApplyDate { get; set; }

      public Guid  ? TjId { get; set; }

      public string  TjNo { get; set; }

      public string  AreaName { get; set; }

      public string  InOrOut { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------BuKou结束----------
    