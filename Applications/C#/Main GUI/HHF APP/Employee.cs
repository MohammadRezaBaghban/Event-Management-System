using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class Employee
    {
        private int idNr;
        private String fName;
        private String lName;
        private String role;

        public Employee(int idNr, String fName, String lName, String role)
        {
            this.idNr = idNr;
            this.fName = fName;
            this.lName = lName;
            this.role = role;
        }
        
        public String ToAString()
        {
            return idNr.ToString() + ", " + fName + ", " + lName + ", " + role;
        }
    }
}
