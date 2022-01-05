    //----------orderinfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class orderinfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  orderno { get; set; }

      public string  consignee { get; set; }

      public string  consigneemb { get; set; }

      public double  ? weight { get; set; }

      public double  ? volumn { get; set; }

      public string  product { get; set; }

      public int  ? qty { get; set; }

      public string  package { get; set; }

      public decimal  ? accarrived { get; set; }

      public decimal  ? accdaishou { get; set; }

      public int  ? orderstate { get; set; }

      public string  bsheng { get; set; }

      public string  bcity { get; set; }

      public string  barea { get; set; }

      public string  btown { get; set; }

      public string  baddress { get; set; }

      public string  esheng { get; set; }

      public string  ecity { get; set; }

      public string  earea { get; set; }

      public string  etown { get; set; }

      public string  eaddress { get; set; }

      public string  blng { get; set; }

      public string  blat { get; set; }

      public string  elng { get; set; }

      public string  elat { get; set; }

      public string  unit { get; set; }

      public string  qsman { get; set; }

      public string  qsmancode { get; set; }

      public DateTime  ? qsdate { get; set; }

      public DateTime  ? downdate { get; set; }

      public string  remark { get; set; }

      public decimal  ? account { get; set; }

      public double  ? gls { get; set; }

      public string  mainid { get; set; }

      public string  imagepid { get; set; }

      public int  ? rowid { get; set; }

      public string  gid { get; set; }

      public int  ? tmsqs { get; set; }

      public int  ? fktype { get; set; }

      public string  outcygs { get; set; }

      public string  outcyweb { get; set; }

      public string  backqty { get; set; }

      public string  unload { get; set; }

      public string  upstairs { get; set; }

      public string  urgent { get; set; }

      public string  ordersource { get; set; }

      public string  endsite { get; set; }

      public string  signtype { get; set; }

      public string  companyid { get; set; }

      public string  BillNoSource { get; set; }
 

    }
}
    //----------orderinfo结束----------
    