    //----------basPlatAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basPlatAccount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  StartSite { get; set; }

      public string  ToMiddle { get; set; }

      public string  AccountName { get; set; }

      public string  CompanyID { get; set; }

      public string  OptMan { get; set; }

      public DateTime  ? OptTime { get; set; }

      public string  OptWeb { get; set; }

      public string  AccountNo { get; set; }

      public string  UserAccount { get; set; }

      public string  UserName { get; set; }

      public string  IsSettleFeeSub { get; set; }

      public string  IsEnable { get; set; }

      public string  IsPlatform { get; set; }

      public string  DBName { get; set; }

      public string  DBInfo { get; set; }
 

    }
}
    //----------basPlatAccount结束----------
    