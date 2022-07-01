using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
   public class StuData
    {
        private string rollNo;
        private string degree;
        private string semester;
        private string firstName;
        private string lastName;
        private string shift;

        public string RollNo { get => rollNo; set => rollNo = value; }
        public string Degree { get => degree; set => degree = value; }
        public string Semester { get => semester; set => semester = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Shift { get => shift; set => shift = value; }
    }
}
