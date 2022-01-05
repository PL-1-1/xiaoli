    //----------GoodsCountManagedetail开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class GoodsCountManagedetail//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  billno { get; set; }

      public string  opertype { get; set; }

      public string  operman { get; set; }

      public string  OperWeb { get; set; }

      public Guid  ? detailID { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------GoodsCountManagedetail结束----------
    