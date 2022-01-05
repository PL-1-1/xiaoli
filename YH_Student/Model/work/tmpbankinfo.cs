    //----------tmpbankinfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class tmpbankinfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  id { get; set; }

      public string  bankman { get; set; }

      public string  bankcode { get; set; }

      public string  bankname { get; set; }

      public string  sheng { get; set; }

      public string  city { get; set; }

      public string  bankchild { get; set; }

      public string  outtype { get; set; }

      public string  opertype { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------tmpbankinfo结束----------
    