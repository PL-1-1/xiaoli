    //----------basmenu_for_insert开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basmenu_for_insert//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  MGuid { get; set; }

      public int  MenuEnable { get; set; }

      public int  ID { get; set; }

      public int  ParentID { get; set; }

      public int  LevelID { get; set; }

      public int  MenuOrder { get; set; }

      public string  MenuName { get; set; }

      public string  DllPath { get; set; }

      public string  DllName { get; set; }

      public string  FormNameSpace { get; set; }

      public string  FormClass { get; set; }

      public string  Paras { get; set; }

      public int  ParasTransferMode { get; set; }

      public int  ShowType { get; set; }

      public string  IconName { get; set; }

      public DateTime  UpdateDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basmenu_for_insert结束----------
    