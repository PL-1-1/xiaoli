    //----------OilplantsRegister开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class OilplantsRegister//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  carNo { get; set; }

      public string  gasStation { get; set; }

      public string  gasType { get; set; }

      public string  oilCardNo { get; set; }

      public DateTime  ? oilDate { get; set; }

      public string  webName { get; set; }

      public decimal  ? oilVolume { get; set; }

      public decimal  ? oilPrice { get; set; }

      public decimal  ? sumAccount { get; set; }

      public string  operMan { get; set; }

      public string  Mark { get; set; }

      public Guid  ? oilId { get; set; }

      public string  Batchno { get; set; }

      public string  companyid { get; set; }

      public DateTime  ? verifyDate { get; set; }

      public string  verifyPerson { get; set; }

      public string  verifyDept { get; set; }

      public string  oilstate_check { get; set; }

      public string  estates { get; set; }
 

    }
}
    //----------OilplantsRegister结束----------
    