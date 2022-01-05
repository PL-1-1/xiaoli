    //----------WhiteList开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WhiteList//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  CompanyCode { get; set; }

      public string  CompanyName { get; set; }

      public string  IP { get; set; }

      public string  SubnetMask { get; set; }

      public string  IPRange { get; set; }

      public string  LinkMan { get; set; }

      public string  LinkPhone { get; set; }

      public string  CompanyAddress { get; set; }

      public string  Email { get; set; }

      public string  BusPrincipal { get; set; }

      public string  DevelopLanguage { get; set; }
 

    }
}
    //----------WhiteList结束----------
    