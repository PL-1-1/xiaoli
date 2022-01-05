    //----------DataStatisticsRignt开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class DataStatisticsRignt//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  Account { get; set; }

      public string  UserName { get; set; }

      public string  companyid { get; set; }

      public string  CompanyName { get; set; }

      public string  companyidRange { get; set; }

      public string  CompanyNameRange { get; set; }

      public DateTime  ? AlterDate { get; set; }

      public string  AlterMan { get; set; }

      public string  Remark { get; set; }
 

    }
}
    //----------DataStatisticsRignt结束----------
    