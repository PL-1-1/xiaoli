    //----------billInventory开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billInventory//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  invBatchNo { get; set; }

      public DateTime  ? invDate { get; set; }

      public DateTime  ? invEndDate { get; set; }

      public string  invRequire { get; set; }

      public string  invRemark { get; set; }

      public string  webname { get; set; }

      public string  sitename { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DepName { get; set; }

      public string  optuser { get; set; }

      public string  invstatus { get; set; }

      public string  invfinopt { get; set; }

      public string  invfinweb { get; set; }

      public string  invfinsite { get; set; }

      public DateTime  ? invfindate { get; set; }

      public DateTime  ? invshdate { get; set; }

      public string  invshopt { get; set; }

      public string  invshweb { get; set; }

      public string  invshsite { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billInventory结束----------
    