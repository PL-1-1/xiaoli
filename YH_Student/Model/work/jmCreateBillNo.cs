    //----------jmCreateBillNo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class jmCreateBillNo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  Companyid { get; set; }

      public string  MaxBillNo { get; set; }
 

    }
}
    //----------jmCreateBillNo结束----------
    