using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StuAdmissionDAL
    {
        public int Insert_StudentAdmissionDAL(Entity.EAdmission objEAdm)
        {
            int ret = 0;
            Database db;
            DbCommand dbcmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbcmd = db.GetStoredProcCommand("Insert_SpAdmission");

            db.AddInParameter(dbcmd, "Action", DbType.Int32, objEAdm.Action);
            db.AddInParameter(dbcmd, "RegSl", DbType.Int32, objEAdm.RegSl);
            db.AddInParameter(dbcmd, "RegistrationNo", DbType.String, objEAdm.RegistrationNo);
            db.AddInParameter(dbcmd, "RollNo", DbType.Int32, objEAdm.RollNo);
            db.AddInParameter(dbcmd, "SessionYear", DbType.Int32, objEAdm.SessionYear);
            db.AddInParameter(dbcmd, "AdmissionDate", DbType.DateTime, objEAdm.AdmissionDate);
            db.AddInParameter(dbcmd, "Shift", DbType.Int32, objEAdm.Shift);
            db.AddInParameter(dbcmd, "ClassId", DbType.Int32, objEAdm.ClassId);
            db.AddInParameter(dbcmd, "StudentId", DbType.Int32, objEAdm.StudentId);
            db.AddInParameter(dbcmd, "EntryBy", DbType.Int32, objEAdm.EntryBy);



            ret = db.ExecuteNonQuery(dbcmd);

            return ret;
        }
    }
}
