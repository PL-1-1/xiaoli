    //----------BillRepertory开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BillRepertory//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  ID { get; set; }

      public string  BillNo { get; set; }

      public string  RepertoryWeb { get; set; }

      public string  OptWeb { get; set; }

      public int  Num { get; set; }

      public int  state { get; set; }

      public int  ? RepertoryType { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------BillRepertory结束----------
    