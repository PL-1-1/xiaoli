    //----------BasCustomerSms开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class BasCustomerSms//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  mProject { get; set; }

      public string  mSex { get; set; }

      public string  mBirthday { get; set; }

      public double  ? mCellphone { get; set; }

      public string  mTelephone { get; set; }

      public string  mAddress { get; set; }

      public string  mCompanyName { get; set; }

      public string  mType { get; set; }

      public string  mHobby { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------BasCustomerSms结束----------
    