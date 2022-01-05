    //----------basSubject开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basSubject//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public int  SubjectID { get; set; }

      public string  SubjectName { get; set; }

      public string  SiteName { get; set; }

      public int  ? SubLevel { get; set; }

      public int  ? ParentId { get; set; }

      public string  companyid { get; set; }

      public string  subjectType { get; set; }

      public string  Remake { get; set; }

      public int  ? isStop { get; set; }
 

    }
}
    //----------basSubject结束----------
    