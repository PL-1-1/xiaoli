    //----------Cargostatistics开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class Cargostatistics//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  id { get; set; }

      public string  OpertionType { get; set; }

      public string  waybill { get; set; }

      public string  Batchnumber { get; set; }

      public string  OpertingPoints { get; set; }

      public decimal  ? Operatingweight { get; set; }

      public int  ? Piece { get; set; }

      public decimal  ? Infieldofweight { get; set; }

      public int  ? Thequantityoffield { get; set; }

      public DateTime  ? Operationdate { get; set; }

      public decimal  ? Operatingweightpercapita { get; set; }

      public string  Stall { get; set; }

      public string  Operator { get; set; }

      public string  Operatingmanual { get; set; }

      public string  Registrant { get; set; }

      public string  Operatingclass { get; set; }
 

    }
}
    //----------Cargostatistics结束----------
    