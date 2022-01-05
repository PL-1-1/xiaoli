    //----------basWebEq开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basWebEq//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? WebId { get; set; }

      public string  WebCode { get; set; }

      public string  WebName { get; set; }

      public string  EquipCode { get; set; }

      public string  EquipName { get; set; }

      public decimal  ? EqPrice { get; set; }

      public string  EqManufacturer { get; set; }

      public string  EqOpeter { get; set; }

      public DateTime  ? EqOpetDate { get; set; }

      public string  SKCause { get; set; }

      public string  SKArea { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basWebEq结束----------
    