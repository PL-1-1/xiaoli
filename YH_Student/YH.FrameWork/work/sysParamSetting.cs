    //----------sysParamSetting开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysParamSetting//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ParamID { get; set; }

      public string  ParamType { get; set; }

      public string  ParamValue { get; set; }

      public string  LastEditor { get; set; }

      public DateTime  ? LastEditeTime { get; set; }

      public string  ParamDescription { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------sysParamSetting结束----------
    