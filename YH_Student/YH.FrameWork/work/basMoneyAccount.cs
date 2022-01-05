    //----------basMoneyAccount开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basMoneyAccount//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ? ID { get; set; }

      public string  AccountName { get; set; }

      public string  BankAccount { get; set; }

      public string  BankName { get; set; }

      public string  SubjectID { get; set; }

      public string  SubjectName { get; set; }

      public int  ? isStop { get; set; }

      public string  Remark { get; set; }

      public string  AccountType { get; set; }

      public string  CreateMan { get; set; }

      public DateTime  ? CreateDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------basMoneyAccount结束----------
    