    //----------sysLocalCacheTable开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysLocalCacheTable//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  TableName { get; set; }

      public DateTime  ModifyDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------sysLocalCacheTable结束----------
    