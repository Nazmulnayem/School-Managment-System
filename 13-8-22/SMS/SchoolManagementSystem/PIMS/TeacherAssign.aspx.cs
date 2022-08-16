using DAL;
using DAL.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SchoolManagementSystem.PIMS
{
    public partial class TeacherAssign : System.Web.UI.Page
    {
        StudentProfileBll objStuBll = new StudentProfileBll();
        CommonDAL objc = new CommonDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CommonDAL.Fillddl(ddlteacher, @"SELECT EmployeeInfo.EmployeeId, EmployeeInfo.FirstName + N' ' + EmployeeInfo.LastName + N' - ' + Conf_Designation.DesignationName AS TeacherName
                FROM EmployeeInfo INNER JOIN
                Conf_Designation ON EmployeeInfo.DesignationId = Conf_Designation.DesignationId
                WHERE (EmployeeInfo.EmployeeType = N'Teacher')", "TeacherName", "EmployeeId");
                CommonDAL.Fillddl(ddlShift, @"SELECT Conf_ClassShedule.ShiftId, Conf_Shift.ShiftName
                FROM Conf_ClassShedule INNER JOIN
                Conf_Shift ON Conf_ClassShedule.ShiftId = Conf_Shift.ShiftId
                GROUP BY Conf_ClassShedule.ShiftId, Conf_Shift.ShiftName", "ShiftName", "ShiftId");
               
            }
        }



        //private void Save()
        //{
        //    int save = 0;

        //    EStudentProfile objEStuPro = new EStudentProfile();

        //    objEStuPro.RegSl = int.Parse(hdnRegsl.Value)+1;
        //    objEStuPro.RegistrationNo = txtRegNo.Text;
        //    objEStuPro.RollNo = int.Parse(txtRoll.Text);
        //    objEStuPro.SessionYear = int.Parse(ddlSession.SelectedValue);
        //    objEStuPro.AdmissionDate = Convert.ToDateTime(txtDate.Text);
        //    objEStuPro.Shift = int.Parse(ddlShift.SelectedValue);
        //    objEStuPro.ClassId = int.Parse(ddlClass.SelectedValue);
        //    objEStuPro.StudentId = int.Parse(hdnStuId.Value);
        //    objEStuPro.EntryBy = int.Parse(Session["UserId"].ToString());

        //    save = objStuBll.InsertAdmissionInfo(objEStuPro);
        //    if (save > 0)
        //    {
        //        rmmsg.SuccessMessage = "Save Done";
        //    }
        //}
        //private bool checkValue()
        //{
        //    rmmsg.SetResponseMessageVisibleFalse();
        //    bool isReq = false;
        //    DataTable dt = new DataTable();

        //    if (gvClassShedule.Rows.Count > 0)
        //    {
        //        dt = (DataTable)ViewState["classShedule"];
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            string shiftId = dt.Rows[i]["ShiftId"].ToString();
        //            string ClassID = dt.Rows[i]["ClassID"].ToString();
        //            string WeekDay = dt.Rows[i]["WeekDay"].ToString();
        //            string SubjectId = dt.Rows[i]["SubjectId"].ToString();
                   
        //            DateTime StartTime = DateTime.Parse(dt.Rows[i]["StartTime"].ToString());
        //            DateTime EndTime = DateTime.Parse(dt.Rows[i]["EndTime"].ToString());
        //            if (shiftId==ddlShift.SelectedValue && ClassID == ddlShedule.SelectedValue && WeekDay == ddlWeekDay.SelectedValue && SubjectId == ddlSubject.SelectedValue)
        //            {
        //                isReq = true;
        //                rmmsg.FailureMessage = "This Subject already Exist.";

        //            } 
        //            else if (shiftId == ddlShift.SelectedValue && ClassID == ddlShedule.SelectedValue && WeekDay == ddlWeekDay.SelectedValue  && (DateTime.Parse(txtStartTime.Text) >= StartTime && DateTime.Parse(txtStartTime.Text) <= EndTime))
        //            {
        //                isReq = true;
        //                rmmsg.FailureMessage = "This time already Exist.";
        //            }
        //            else if (shiftId == ddlShift.SelectedValue && ClassID == ddlShedule.SelectedValue && WeekDay == ddlWeekDay.SelectedValue && (DateTime.Parse(txtEndTime.Text) >= StartTime && DateTime.Parse(txtEndTime.Text) <= EndTime))
        //            {
        //                isReq = true;
        //                rmmsg.FailureMessage = "This time already Exist.";
        //            }

                    
        //        }
        //    }

        //    return isReq;
        //}

        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    Save();
        //}
        //    protected void AddBtn_Click(object sender, EventArgs e)
        //{
        //    if (checkValue()==false )
        //    {
        //        ListAdd();
        //    }
          
        //}
        //private void ListAdd()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add(new System.Data.DataColumn("Shift", typeof(string)));
        //    dt.Columns.Add(new System.Data.DataColumn("ShiftId", typeof(string)));
        //    dt.Columns.Add(new System.Data.DataColumn("Class", typeof(string)));
        //    dt.Columns.Add(new System.Data.DataColumn("ClassID", typeof(string)));
        //    dt.Columns.Add(new System.Data.DataColumn("WeekDay", typeof(string)));
        //    dt.Columns.Add(new System.Data.DataColumn("Subject", typeof(string)));
        //    dt.Columns.Add(new System.Data.DataColumn("SubjectId", typeof(string)));
        //    dt.Columns.Add(new System.Data.DataColumn("StartTime", typeof(string)));
        //    dt.Columns.Add(new System.Data.DataColumn("EndTime", typeof(string)));
        //    if (gvClassShedule.Rows.Count>0)
        //    {
        //        dt = (DataTable)ViewState["classShedule"];
               
        //    }
           

        //    DataRow dr = dt.NewRow();

        //    dr[0] = ddlShift.SelectedItem.Text;
        //    dr[1] = ddlShift.SelectedValue;
        //    dr[2] = ddlShedule.SelectedItem.Text;
        //    dr[3] = ddlShedule.SelectedValue;
        //    dr[4] = ddlWeekDay.SelectedValue;
        //    dr[5] = ddlSubject.SelectedItem.Text;
        //    dr[6] = ddlSubject.SelectedValue;
        //    dr[7] = txtStartTime.Text;
        //    dr[8] = txtEndTime.Text;
        //    dt.Rows.Add(dr);

        //    ViewState["classShedule"] = dt;

        //    gvClassShedule.DataSource = dt;
        //    gvClassShedule.DataBind();
        //}

        //List<EClassShedule> collection = new List<EClassShedule>();
        //ClassSheduleBLL objclssBLL = new ClassSheduleBLL();
        //private void Save()
        //{
        //    if (gvClassShedule.Rows.Count>0)
        //    {
        //        int save = 0;
        //        DataTable dt = new DataTable();
        //        dt = (DataTable)ViewState["classShedule"];
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            EClassShedule objclss = new EClassShedule();
        //            objclss.ShiftId =int.Parse(dt.Rows[i]["ShiftId"].ToString());
        //            objclss.ClassID =int.Parse(dt.Rows[i]["ClassID"].ToString());
        //            objclss.WeekDay =(dt.Rows[i]["WeekDay"].ToString());
        //            objclss.SubjectId =int.Parse(dt.Rows[i]["SubjectId"].ToString());
        //            objclss.StartTime =DateTime.Parse(dt.Rows[i]["StartTime"].ToString());
        //            objclss.EndTime =DateTime.Parse(dt.Rows[i]["EndTime"].ToString());
        //            objclss.EntryBy =int.Parse(Session["UserId"].ToString());
        //            collection.Add(objclss);

        //        }
        //        save=objclssBLL.InsertUpdateDelete_InstituteBLL(collection);
        //        if (save>0)
        //        {
        //            rmmsg.SuccessMessage = "Save Done";
        //        }
        //        else
        //        {
        //            rmmsg.FailureMessage = "Save failure";
        //        }
        //    }
        //    else
        //    {
        //        rmmsg.FailureMessage = "There is no Class Shedule.";
        //    }
        //}

        protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlStr = @"SELECT        Conf_ClassShedule.CSheduleId, Conf_ClassShedule.WeekDay + ' - ' + Conf_Subject.SubjectName + ' - ' + CONVERT(varchar(5), CAST(Conf_ClassShedule.StartTime AS time)) + ' - ' + CONVERT(varchar(5), 
            CAST(Conf_ClassShedule.EndTime AS time)) AS Shedule
            FROM            Conf_ClassShedule INNER JOIN
            Conf_SchoolClass ON Conf_ClassShedule.ClassId = Conf_SchoolClass.SchoolClassId INNER JOIN
            Conf_Subject ON Conf_ClassShedule.SubjectId = Conf_Subject.SubjectId
  WHERE        (Conf_ClassShedule.ShiftId = "+ddlShift.SelectedValue+") AND (Conf_ClassShedule.ClassId = "+ddlClass.SelectedValue+")";

            CommonDAL.Fillddl(ddlShedule, sqlStr, "Shedule", "CSheduleId");

        }

        protected void ddlShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonDAL.Fillddl(ddlClass, @"SELECT Conf_ClassShedule.ClassId, Conf_SchoolClass.ClassName
            FROM            Conf_ClassShedule INNER JOIN
            Conf_SchoolClass ON Conf_ClassShedule.ClassId = Conf_SchoolClass.SchoolClassId
            WHERE        (Conf_ClassShedule.ShiftId = "+ddlShift.SelectedValue+ ") GROUP BY Conf_ClassShedule.ClassId, Conf_SchoolClass.ClassName", "ClassName", "ClassId");

        }
    }
}