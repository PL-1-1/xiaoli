    //----------ExportDataApply开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ExportDataApply//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  exportApplyID { get; set; }

      public string  modularName { get; set; }

      public string  screenCondition { get; set; }

      public string  enclosure { get; set; }

      public string  remarks { get; set; }

      public DateTime  ? applyDate { get; set; }

      public int  ? executionTimes { get; set; }

      public string  applyMan { get; set; }

      public string  companyid { get; set; }

      public string  applyState { get; set; }

      public string  Annex { get; set; }

      public string  strsql { get; set; }

      public DateTime  ? t1 { get; set; }

      public DateTime  ? t2 { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  StartSite { get; set; }

      public string  TransferSite { get; set; }

      public string  BegWeb { get; set; }

      public string  BillMan { get; set; }
 

    }
}
    //----------ExportDataApply结束----------
    