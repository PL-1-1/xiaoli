    //----------SmallProgramIDOrder开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class SmallProgramIDOrder//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  sprogramID { get; set; }

      public int  ? sprogramType { get; set; }

      public string  sendProvince { get; set; }

      public string  sendCity { get; set; }

      public string  sendArea { get; set; }

      public string  sendStreet { get; set; }

      public string  sendAddress { get; set; }

      public string  sendMan { get; set; }

      public string  sendPhone { get; set; }

      public string  receiveProvince { get; set; }

      public string  receiveCity { get; set; }

      public string  receiveArea { get; set; }

      public string  receiveStreet { get; set; }

      public string  receiveAddress { get; set; }

      public string  receiveMan { get; set; }

      public string  receivePhone { get; set; }

      public decimal  ? weight { get; set; }

      public decimal  ? volume { get; set; }

      public int  ? isFetch { get; set; }

      public int  ? isSend { get; set; }

      public DateTime  ? orderTime { get; set; }

      public int  ? qty { get; set; }

      public string  length { get; set; }

      public string  width { get; set; }

      public string  height { get; set; }

      public string  productName { get; set; }

      public string  packing { get; set; }

      public string  remarks { get; set; }

      public string  receiptInfo { get; set; }

      public decimal  ? receiptAmount { get; set; }

      public string  collectionCard { get; set; }

      public decimal  ? collectionAmount { get; set; }

      public string  accountName { get; set; }

      public string  otherServices { get; set; }

      public decimal  ? otherServicesAmount { get; set; }

      public int  ? orderState { get; set; }

      public string  orderSn { get; set; }

      public decimal  ? orderAmount { get; set; }

      public string  billSn { get; set; }

      public string  OptMan { get; set; }

      public DateTime  ? OptTime { get; set; }

      public DateTime  ? rdate { get; set; }

      public DateTime  ? sdate { get; set; }

      public string  isFname { get; set; }

      public int  ? payflag { get; set; }

      public decimal  ? payamount { get; set; }

      public string  delivery_address { get; set; }

      public decimal  ? deliveryPrice { get; set; }

      public decimal  ? getgoodsPrice { get; set; }

      public decimal  ? tlinePrice { get; set; }

      public string  companyid { get; set; }

      public string  BillState { get; set; }

      public string  billNo_DK { get; set; }

      public DateTime  ? createTime { get; set; }

      public string  userId { get; set; }

      public int  confirmType { get; set; }

      public DateTime  ? confirmTime { get; set; }

      public string  receivMode { get; set; }

      public string  sendCompany { get; set; }

      public string  receiveCompany { get; set; }

      public string  transitMode { get; set; }

      public string  storageLocation { get; set; }

      public string  team { get; set; }

      public string  areaName { get; set; }

      public string  causeName { get; set; }

      public string  depName { get; set; }

      public string  siteName { get; set; }

      public string  webName { get; set; }

      public string  userName { get; set; }

      public int  noticeState { get; set; }

      public int  IsInvoice { get; set; }

      public int  IsReceiptFee { get; set; }

      public int  IsSupportValue { get; set; }

      public int  IsAgentFee { get; set; }

      public int  IsPackagFee { get; set; }

      public int  IsOtherFee { get; set; }

      public int  IsHandleFee { get; set; }

      public int  IsStorageFee { get; set; }

      public int  IsWarehouseFee { get; set; }

      public int  IsForkliftFee { get; set; }

      public int  IsChangeFee { get; set; }

      public int  IsUpstairFee { get; set; }

      public int  IsCustomsFee { get; set; }

      public int  IsFrameFee { get; set; }
 

    }
}
    //----------SmallProgramIDOrder结束----------
    