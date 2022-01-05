    //----------DriverImagesInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class DriverImagesInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  Id { get; set; }

      public Guid  DriverID { get; set; }

      public string  DriverPhoto { get; set; }

      public string  DriverLicense { get; set; }

      public string  Driverjiashi { get; set; }

      public string  DriverIdCard { get; set; }

      public string  OperMan { get; set; }

      public DateTime  OperDate { get; set; }

      public string  companyid { get; set; }
 

    }
}
    //----------DriverImagesInfo结束----------
    