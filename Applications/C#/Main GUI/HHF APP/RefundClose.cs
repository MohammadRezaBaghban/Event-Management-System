using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class RefundClose
    {
        private string is_admin, status;

        public RefundClose(string is_admin,string status)
        {
            this.is_admin = is_admin;
            this.status = status;
        }

        public string getUserLevel { get => is_admin; }
        public string getUserStatus { get => status; }
    }
}
