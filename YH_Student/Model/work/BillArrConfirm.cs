    //----------BillArrConfirm开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillArrConfirm//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ArrConfirmID { get; set; }

      public string  ArrConfirmMan { get; set; }

      public DateTime  ? ArrConfirmDate { get; set; }

      public string  ArrConfirmWeb { get; set; }

      public string  ArrConfirmSite { get; set; }

      public string  ArrConfirmArea { get; set; }

      public string  ArrConfirmCause { get; set; }

      public string  BillNo { get; set; }

      public decimal  ? ArrConfirmFee { get; set; }

      public string  ArrConfirmAduitMan { get; set; }

      public string  ArrConfirmAduitTime { get; set; }

      public string  ArrConfirmAduitWeb { get; set; }

      public string  ArrConfirmAduitSite { get; set; }

      public string  ArrConfirmAduitArea { get; set; }

      public string  ArrConfirmAduitCause { get; set; }

      public decimal  ? ArrConfirmAduitFee { get; set; }

      public string  Exception { get; set; }

      public string  ExceptionMAN { get; set; }

      public string  ExceptionWeb { get; set; }

      public string  ExceptionOutMAN { get; set; }

      public string  ExceptionOutWeb { get; set; }

      public DateTime  ? ExceptionTime { get; set; }

      public DateTime  ? ExceptionOutTime { get; set; }

      public string  ArrConfirmCancelMan { get; set; }

      public DateTime  ? ArrConfirmCancelTime { get; set; }

      public string  ArrConfirmCancelWeb { get; set; }

      public string  ArrConfirmCancelSite { get; set; }

      public string  ArrConfirmCancelArea { get; set; }

      public string  ArrConfirmCancelCause { get; set; }

      public string  BackRemark { get; set; }

      public string  BackAduitMan { get; set; }

      public string  BackAduitArea { get; set; }

      public string  BackAduitCause { get; set; }

      public string  BackAduitWeb { get; set; }

      public string  BackAduitSite { get; set; }

      public DateTime  ? BackAduitDate { get; set; }

      public DateTime  ? ConfirmOperDate { get; set; }

      public string  companyid { get; set; }

      public string  unCheckMan { get; set; }

      public DateTime  ? unCheckTime { get; set; }
 

    }
}
    //----------BillArrConfirm结束----------
    