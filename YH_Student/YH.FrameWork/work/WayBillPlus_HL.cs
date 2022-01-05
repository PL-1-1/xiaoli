    //----------WayBillPlus_HL开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class WayBillPlus_HL//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  BillNo_DK { get; set; }

      public string  DK_state { get; set; }

      public string  orderNo { get; set; }

      public string  deliveryNo { get; set; }

      public DateTime  ? deliveryAt { get; set; }

      public string  limitationDay { get; set; }

      public string  limitationHour { get; set; }

      public string  deliveryName { get; set; }

      public string  deliveryLxdh { get; set; }

      public string  deliveryProvince { get; set; }

      public string  deliveryCity { get; set; }

      public string  deliveryArea { get; set; }

      public string  deliveryStreet { get; set; }

      public string  deliveryAddress { get; set; }

      public string  receivingName { get; set; }

      public string  receivingLxdh { get; set; }

      public string  receivingProvince { get; set; }

      public string  receivingCity { get; set; }

      public string  receivingArea { get; set; }

      public string  receivingStreet { get; set; }

      public string  receivingAddress { get; set; }

      public string  gooods { get; set; }

      public decimal  ? actualWeight { get; set; }

      public decimal  ? volume { get; set; }

      public int  ? packNumber { get; set; }

      public string  signature { get; set; }

      public string  stamp { get; set; }

      public string  specimens { get; set; }

      public string  returnRequirement { get; set; }

      public string  toPayFee { get; set; }

      public string  oldPackType { get; set; }

      public DateTime  ? createDate { get; set; }

      public string  serviceType { get; set; }

      public string  isWaitnotice { get; set; }

      public string  isElecSupplier { get; set; }

      public string  isBatch { get; set; }

      public decimal  ? collection { get; set; }

      public string  handoverBatch { get; set; }

      public string  handoverNo { get; set; }

      public DateTime  ? handoverTime { get; set; }

      public int  ? handoverNumber { get; set; }

      public string  handoverType { get; set; }

      public string  remark { get; set; }

      public string  payWay { get; set; }

      public string  modifMan { get; set; }

      public DateTime  ? modifDate { get; set; }
 

    }
}
    //----------WayBillPlus_HL结束----------
    