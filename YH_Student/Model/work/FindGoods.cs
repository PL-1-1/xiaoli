    //----------FindGoods开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class FindGoods//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  Id { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DepName { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public DateTime  ? OperDate { get; set; }

      public string  OperMan { get; set; }

      public string  FindMan { get; set; }

      public DateTime  ? FindDate { get; set; }

      public string  Remark { get; set; }

      public DateTime  ? ClaimDate { get; set; }

      public string  ClaimMan { get; set; }

      public string  ClaimCauseName { get; set; }

      public string  ClaimAreaName { get; set; }

      public string  ClaimDepName { get; set; }

      public string  ClaimSiteName { get; set; }

      public string  ClaimWebName { get; set; }

      public string  BillNo { get; set; }

      public string  Varieties { get; set; }

      public string  Package { get; set; }

      public int  ? Num { get; set; }

      public string  Describe { get; set; }

      public string  FromCause { get; set; }

      public string  FromArea { get; set; }

      public string  FromWeb { get; set; }

      public string  DealMan { get; set; }

      public DateTime  ? DealDate { get; set; }

      public string  Chauffer { get; set; }

      public string  VehicleNo { get; set; }

      public string  companyid { get; set; }

      public string  EnterPortNo { get; set; }

      public string  ImageID { get; set; }

      public string  Remark1 { get; set; }
 

    }
}
    //----------FindGoods结束----------
    