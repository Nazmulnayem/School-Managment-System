using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class EAdmission
    {
        public int Action { get; set; }

        public int AdmissionId { get; set; }
        public int RegSl { get; set; }
        public string RegistrationNo { get; set; }
        public int RollNo { get; set; }
        public int SessionYear { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int Shift { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public Nullable<int> EntryBy { get; set; }
        public Nullable<DateTime> EntryDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
    }
}
