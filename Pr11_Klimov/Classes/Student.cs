using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11_Klimov.Classes
{
    public class Student
    {
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }

        public Student(string firstname, string middlename, string lastname)
        {
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
        }

        public string GetFIO()
        {
            return $"{firstname} {middlename} {lastname}";
        }
    }
}
