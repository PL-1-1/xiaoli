    //----------BillPettypay开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillPettypay//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? PettypayId { get; set; }

      public string  BillNo { get; set; }

      public DateTime  ? baddate { get; set; }

      public string  badcontent { get; set; }

      public string  badcreateby { get; set; }

      public string  fangkuiwebid { get; set; }

      public string  fangkuiman { get; set; }

      public string  ExceType { get; set; }

      public string  ExceDepart { get; set; }

      public decimal  ? Pettypay { get; set; }

      public string  OaNo { get; set; }

      public string  OaStatus { get; set; }

      public int  ? ToOA { get; set; }

      public int  ID { get; set; }

      public int  ? ToOAAPP { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------BillPettypay结束----------
    