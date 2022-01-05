    //----------billArrMessageRecord开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class billArrMessageRecord//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public string  BillNo { get; set; }

      public string  ConsignorName { get; set; }

      public string  ConsignorCellPhone { get; set; }

      public string  ConsignorPhone { get; set; }

      public string  ConsignorCompany { get; set; }

      public DateTime  ? LastSendTime { get; set; }

      public int  ? SendTimes { get; set; }

      public string  BegWeb { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------billArrMessageRecord结束----------
    