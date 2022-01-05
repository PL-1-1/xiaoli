    //----------v_chauffer_note开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class v_chauffer_note//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public DateTime  ? inputtime { get; set; }

      public string  remark { get; set; }

      public decimal  ? score { get; set; }

      public string  createby { get; set; }

      public int  ? chaufferid { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------v_chauffer_note结束----------
    