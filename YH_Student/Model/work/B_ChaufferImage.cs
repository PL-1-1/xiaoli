    //----------B_ChaufferImage开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class B_ChaufferImage//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  Id { get; set; }

      public int  chaufferno { get; set; }

      public string  chauffername { get; set; }

      public string  FilePath { get; set; }

      public string  OperMan { get; set; }

      public DateTime  OperDate { get; set; }

      public string  imagetype { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------B_ChaufferImage结束----------
    