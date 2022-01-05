    //----------ReturnStock开始----------
    
using System;
namespace Blog.Core.FrameWork.Entity
{    
    /// <summary>
    /// 
    /// </summary>    
    public class ReturnStock//可以在这里加上基类等
    {
    //将该表下的字段都遍历出来，可以自定义获取数据描述等信息

      public Guid  ID { get; set; }

      public string  BillNo { get; set; }

      public string  CauseName { get; set; }

      public string  AreaName { get; set; }

      public string  BegWeb { get; set; }

      public string  ReturnDepartment { get; set; }

      public string  ReceiptCondition { get; set; }

      public string  SCBatchNo { get; set; }

      public DateTime  ? SCDate { get; set; }

      public string  SCWeb { get; set; }

      public string  SCMan { get; set; }

      public string  SCAcceptWeb { get; set; }

      public DateTime  ? SCAcceptTime { get; set; }

      public string  SCAcceptMan { get; set; }

      public string  DepartureBatch { get; set; }

      public DateTime  ? DepartureDate { get; set; }

      public string  LoadPeoples { get; set; }

      public string  LoadWeb { get; set; }

      public DateTime  ? AcceptBillDate { get; set; }

      public string  AcceptBillMan { get; set; }

      public string  AcceptWebName { get; set; }

      public string  SendBatch { get; set; }

      public string  SendWeb { get; set; }

      public DateTime  ? SendDate { get; set; }

      public string  SendOperator { get; set; }

      public string  AcceptMan { get; set; }

      public DateTime  ? AcceptTime { get; set; }

      public string  AcceptWeb { get; set; }

      public DateTime  ? billdate { get; set; }

      public string  PickGoodsSite { get; set; }

      public string  HDBillNo { get; set; }

      public string  HDPCH { get; set; }

      public string  HDState { get; set; }

      public string  Sources { get; set; }

      public string  AllocateBatch { get; set; }

      public DateTime  ? AllocateDate { get; set; }

      public string  AllocateMan { get; set; }

      public string  AllocateWeb { get; set; }

      public string  FBAcceptMan { get; set; }

      public string  FBAcceptWeb { get; set; }

      public DateTime  ? FBAcceptDate { get; set; }

      public string  ReplyToPersonOne { get; set; }

      public string  ReplyToPersonTwo { get; set; }

      public string  ReplyToPersonThree { get; set; }

      public string  ReplyToPersonFour { get; set; }

      public string  ReplyToPersonFive { get; set; }

      public DateTime  ? ReturnTimeOne { get; set; }

      public DateTime  ? ReturnTimeTwo { get; set; }

      public DateTime  ? ReturnTimeThree { get; set; }

      public DateTime  ? ReturnTimeFour { get; set; }

      public DateTime  ? ReturnTimeFive { get; set; }

      public string  ReturnWebOne { get; set; }

      public string  ReturnWebTwo { get; set; }

      public string  ReturnWebThree { get; set; }

      public string  ReturnWebFour { get; set; }

      public string  ReturnWebFive { get; set; }

      public int  ? ReplyTimes { get; set; }

      public string  HDReturnMan { get; set; }

      public DateTime  ? HDReturnTime { get; set; }

      public string  HDReturnWeb { get; set; }

      public string  ReturnToFactoryMan { get; set; }

      public DateTime  ? ReturnToFactoryTime { get; set; }

      public string  ReturnToFactoryWeb { get; set; }

      public string  MailingType { get; set; }

      public string  express { get; set; }

      public string  CourierNumber { get; set; }

      public string  TransferSite { get; set; }
 

    }
}
    //----------ReturnStock结束----------
    