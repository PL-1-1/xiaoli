using IRepositroy;
using IServices;
using Service.BASE;
using System;
using System.Collections.Generic;
using System.Text;
using YH.Core.Model.Models;

namespace Service
{
   public class StudentServives:BaseServices<student>,IStudentServices
    {
        IStudentRepository dal;
        public StudentServives(IStudentRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
    }
}
