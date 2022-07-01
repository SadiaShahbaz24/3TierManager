using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataDAL
    {
        DbCon db = new DbCon();

        //functions of student

        public bool StuInsertDAL(StuData sd)
        {
            string qry = "Insert into Students Values ('" + sd.RollNo + "','" + sd.FirstName + "','" + sd.LastName + "','" + sd.Degree + "','" + sd.Semester + "','" + sd.Shift + "')";
            return db.UDI(qry);
        }
        public bool StuDeleteDAL(StuData sd)
        {
            return db.UDI("Delete from Students where RollNo='" + sd.RollNo + "'");
        }
        public bool StuUpdateDAL(StuData sd)
        {
            return db.UDI("Update Students set FirstName='" + sd.FirstName + "', LastName='" + sd.LastName + "', Degree='" + sd.Degree + "', Semester='" + sd.Semester + "', Shift='" + sd.Shift + "' where RollNo='" + sd.RollNo + "'");
        }
        public DataTable StuSearchDAL(StuData sd)
        {
            return db.Search("Select from Students where RollNo='" + sd.RollNo + "'");
        }
        public DataTable StuGetAllDAL()
        {
            return db.Search("Select * from Students ");
        }

        //functions of Teacher

        public bool TeaInsertDAL(TeaData td)
        {
            string qry = "Insert into Teachers Values ('" + td.Id1 + "','" + td.FirstName + "','" + td.LastName + "','" + td.Qualification + "','" + td.Course + "','" + td.Email + "')";
            return db.UDI(qry);
        }
        public bool TeaDeleteDAL(TeaData td)
        {
            return db.UDI("Delete from Teachers where TeacherID='" + td.Id1 + "'");
        }
        public bool TeaUpdateDAL(TeaData td)
        {
            return db.UDI("Update Teachers set FirstName='" + td.FirstName + "', LastName='" + td.LastName + "', Qualification='" + td.Qualification + "', Course='" + td.Course + "', Email='" + td.Email + "' where TeacherID='" + td.Id1 + "'");
        }
        public DataTable TeaSearchDAL(TeaData td)
        {
            return db.Search("Select from Teachers where TeacherID='" + td.Id1 + "'");
        }
        public DataTable TeaGetAllDAL()
        {
            return db.Search("Select * from Teachers");
        }
        //Functions of Course
        public bool CouInsertDAL(CouData cd)
        {
            string qry = "Insert into Courses Values ('" + cd.Id + "','" + cd.Name + "','" + cd.CrHour + "','" + cd.Type + "','" + cd.Dept + "' )";
            return db.UDI(qry);
        }
        public bool CouDeleteDAL(CouData cd)
        {
            return db.UDI("Delete from Courses where CourseID='" + cd.Id + "'");
        }
        public bool CouUpdateDAL(CouData cd)
        {
            return db.UDI("Update Courses set CourseName='" + cd.Name + "', CreditHour='" + cd.CrHour + "', Type='" + cd.Type + "', Department='" + cd.Dept + "' where CourseID='" + cd.Id + "'");
        }
        public DataTable CouSearchDAL(CouData cd)
        {
            return db.Search("Select from Courses where CourseID='" + cd.Id + "'");
        }
        public DataTable CouGetAllDAL()
        {
            return db.Search("Select * from Courses");
        }

    }
}
