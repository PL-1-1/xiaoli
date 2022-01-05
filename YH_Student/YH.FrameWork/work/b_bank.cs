    //----------b_bank开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_bank//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  bankman { get; set; }

      public string  bankcode { get; set; }

      public string  bankname { get; set; }

      public string  sheng { get; set; }

      public string  city { get; set; }

      public string  opertype { get; set; }

      public double  ? accout { get; set; }

      public double  ? accin { get; set; }

      public DateTime  ? billdate { get; set; }

      public string  outtype { get; set; }

      public string  remark { get; set; }

      public string  createby { get; set; }

      public string  bsite { get; set; }

      public string  webid { get; set; }

      public string  appby { get; set; }

      public DateTime  ? appdate { get; set; }

      public DateTime  ? operdate { get; set; }

      public string  bankchild { get; set; }

      public string  companyid { get; set; }

      public string  FeeBatch { get; set; }

      public string  reportnetwork { get; set; }

      public string  project { get; set; }

      public string  phone { get; set; }

      public string  claimNo { get; set; }

      public string  ClaimBatch { get; set; }
 

    }
}
    //----------b_bank结束----------
    