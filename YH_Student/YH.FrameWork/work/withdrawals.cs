    //----------withdrawals开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class withdrawals//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  userid { get; set; }

      public DateTime  ? billdate { get; set; }

      public string  bankman { get; set; }

      public string  bankcode { get; set; }

      public string  bankname { get; set; }

      public string  bankid { get; set; }

      public double  ? acc { get; set; }

      public string  remark { get; set; }

      public string  applyman { get; set; }

      public DateTime  ? applydate { get; set; }

      public int  ? applystate { get; set; }

      public string  province { get; set; }

      public string  city { get; set; }

      public string  accType { get; set; }

      public string  orderno { get; set; }

      public string  accfss { get; set; }

      public string  vehicleno { get; set; }
 

    }
}
    //----------withdrawals结束----------
    