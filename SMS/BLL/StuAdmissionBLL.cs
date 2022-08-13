using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entity;
using System.Data;
namespace BLL
{
    public class StuAdmissionBLL
    {
        StuAdmissionDAL objStuAdDAL = new StuAdmissionDAL();
        public int Insert_StudentAdmissionBLL(EAdmission objStuAd)
        {
            int ret = 0;
            ret = objStuAdDAL.Insert_StudentAdmissionDAL(objStuAd);
            return ret;
        }
    }
}
