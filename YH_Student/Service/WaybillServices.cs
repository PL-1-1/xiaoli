using Blog.Core.FrameWork.Entity;
using IRepositroy;
using IServices;
using Service.BASE;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public class WaybillServices : BaseServices<WayBill>, IWaybillServices
    {
        IWaybillRepository dal;
        public WaybillServices(IWaybillRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
    }
}
