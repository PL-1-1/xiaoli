    //----------OilCardAllot开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class OilCardAllot//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  OilCardNo { get; set; }

      public decimal  Account { get; set; }

      public string  Chauffer { get; set; }

      public string  ChaufferTel { get; set; }

      public string  VehicleNo { get; set; }

      public decimal  ? Reimbursement { get; set; }

      public string  OperMan { get; set; }

      public DateTime  OperDate { get; set; }

      public int  ? VerifyState { get; set; }

      public string  VerifyMan { get; set; }

      public DateTime  ? VerifyDate { get; set; }

      public string  Company { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------OilCardAllot结束----------
    