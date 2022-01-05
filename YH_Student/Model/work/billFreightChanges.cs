    //----------billFreightChanges开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billFreightChanges//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  BillNO { get; set; }

      public string  ChangeTransfType { get; set; }

      public decimal  ? ChangePlusFee { get; set; }

      public string  ChangePlusObj { get; set; }

      public string  PlusFeePayer { get; set; }

      public string  CancelSite { get; set; }

      public string  ChangeBecuase { get; set; }

      public DateTime  ? ChangeDate { get; set; }

      public string  ChangeMan { get; set; }

      public string  ChangeCause { get; set; }

      public string  ChangeArea { get; set; }

      public string  ChangeWeb { get; set; }

      public int  ? ChangeState { get; set; }

      public int  ? BillToType { get; set; }

      public decimal  ? AduitAmount { get; set; }

      public string  AduitType { get; set; }

      public DateTime  ? FAduitTime { get; set; }

      public string  FAduitMan { get; set; }

      public string  FAduitWeb { get; set; }

      public DateTime  ? FExecDate { get; set; }

      public string  companyid { get; set; }

      public string  OneSubject { get; set; }

      public string  TwoSubject { get; set; }

      public string  ThreeSubject { get; set; }

      public string  Summary { get; set; }

      public string  OptCancelMan { get; set; }

      public DateTime  ? OptCancelTime { get; set; }

      public string  VoucherNo { get; set; }

      public string  Verifydirection { get; set; }

      public decimal  ? VirefBalance { get; set; }

      public decimal  ? VirefCurrent { get; set; }
 

    }
}
    //----------billFreightChanges结束----------
    