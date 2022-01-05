    //----------basCompany开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class basCompany//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  gsqc { get; set; }

      public string  gsjc { get; set; }

      public string  companyid { get; set; }

      public string  gstype { get; set; }

      public string  gscause { get; set; }

      public string  gsfr { get; set; }

      public string  frtel { get; set; }

      public string  gstel { get; set; }

      public string  email { get; set; }

      public string  gsaddr { get; set; }

      public int  ? gsState { get; set; }

      public string  gslabel { get; set; }

      public string  gsenvelope { get; set; }

      public string  companyright { get; set; }

      public int  ? gsControl { get; set; }

      public string  Transprotocol { get; set; }

      public string  DepartList { get; set; }

      public string  LoadList { get; set; }

      public string  ShortConList { get; set; }

      public string  BookNote { get; set; }

      public string  FeeSubNode { get; set; }

      public string  Sitenames { get; set; }

      public string  MiddleList { get; set; }

      public string  IsAutomaticFangHuo { get; set; }

      public int  ? IsAutomaticGaiDan { get; set; }

      public int  ? gsNotStreet { get; set; }

      public int  ? IsTerminalArtery { get; set; }

      public int  ? isFB { get; set; }

      public int  ? IsAutomaticzhixing { get; set; }

      public int  ? gsDenominatedFee { get; set; }

      public DateTime  ? optDate { get; set; }

      public string  companyCode { get; set; }

      public string  token { get; set; }

      public string  Property { get; set; }

      public string  IsPlatform { get; set; }

      public string  PlatformName { get; set; }

      public int  ? IsAutomaticGaiDanSP { get; set; }

      public int  ? IsAutomaticGaiDanZX { get; set; }

      public int  ? IsGsNotStreet_self { get; set; }

      public int  ? IsGsNotStreet_send { get; set; }

      public int  ? IsReceiptPayChecked { get; set; }
 

    }
}
    //----------basCompany结束----------
    