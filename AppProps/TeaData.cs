using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
  public class TeaData
    {
        private string Id;
        private string qualification;
        private string course;
        private string firstName;
        private string lastName;
        private string email;

        public string Id1 { get => Id; set => Id = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Course { get => course; set => course = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
    }
}
