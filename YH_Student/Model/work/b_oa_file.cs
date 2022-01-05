    //----------b_oa_file开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class b_oa_file//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  fileid { get; set; }

      public DateTime  ? billdate { get; set; }

      public string  docname { get; set; }

      public string  filetype { get; set; }

      public int  ? length { get; set; }

      public string  createby { get; set; }

      public string  receiveusername { get; set; }

      public string  filedata { get; set; }

      public string  remark { get; set; }

      public string  bsite { get; set; }

      public string  webid { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------b_oa_file结束----------
    