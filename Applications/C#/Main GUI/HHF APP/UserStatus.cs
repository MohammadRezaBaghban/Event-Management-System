using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class UserStatus
    {

        private string user_status;
        public UserStatus(string user_status)
        {
            this.user_status = user_status;
        }
        public string getUserStatus { get => user_status; }
    }
}
