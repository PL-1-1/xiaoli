    //----------sysUserInfo开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class sysUserInfo//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  UserId { get; set; }

      public string  UserAccount { get; set; }

      public string  UserPsw { get; set; }

      public string  UserName { get; set; }

      public string  SiteName { get; set; }

      public string  WebName { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  DepartName { get; set; }

      public string  GRCode { get; set; }

      public string  GRName { get; set; }

      public int  ? UserState { get; set; }

      public DateTime  ? lastLogTime { get; set; }

      public string  LastLogLANIp { get; set; }

      public string  LastLogWANIp { get; set; }

      public string  UserCupName { get; set; }

      public string  LoginSiteCode { get; set; }

      public string  LoginWebCode { get; set; }

      public string  EmpNO { get; set; }

      public string  Position { get; set; }

      public string  UserRight { get; set; }

      public int  ? IsRestart { get; set; }

      public decimal  ? Discount { get; set; }

      public string  Authorize { get; set; }

      public string  PDApwd { get; set; }

      public int  ? isLoginApp { get; set; }

      public string  ValidationInfo { get; set; }

      public int  ? EnableValidate { get; set; }

      public int  ? IsLoginEnable { get; set; }

      public string  companyid { get; set; }

      public string  gmsfhm { get; set; }

      public string  sjhm { get; set; }
 

    }
}
    //----------sysUserInfo结束----------
    