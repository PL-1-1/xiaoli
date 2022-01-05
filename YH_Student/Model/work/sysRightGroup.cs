    //----------sysRightGroup开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysRightGroup//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  GRId { get; set; }

      public string  GRName { get; set; }

      public string  GRCode { get; set; }

      public int  MenuID { get; set; }

      public string  GRTag { get; set; }

      public int  GRFlag { get; set; }

      public string  GRRemark { get; set; }

      public DateTime  ? UpdateDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------sysRightGroup结束----------
    