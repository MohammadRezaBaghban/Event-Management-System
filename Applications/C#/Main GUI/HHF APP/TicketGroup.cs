using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class TicketGroup:TicketPurchase
    {

        private readonly List<string> _fNames;
        private readonly List<string> _lNames;
        private readonly List<string> _emails;
        private readonly string _paynow;
        private readonly string _vip;

        public TicketGroup(string fName, string lName, string email, string password, string phone, string iban,
            decimal topUp, List<string> fNames, List<string> lNames, List<string> emails, bool paynow) : base(fName,
            lName, email, password, phone, iban, topUp)
        {
            _fNames = fNames;
            _lNames = lNames;
            _emails = emails;
            if (paynow)
            {
                _paynow = "yes";
            }
            else
            {
                _paynow = "no";
            }

        }

        public TicketGroup(string fName, string lName, string email, string password, string phone, string iban,
            decimal topUp, bool isVip) : base(fName,
            lName, email, password, phone, iban, topUp)
        {
            if (isVip)
            {
                _vip = "yes";
            }
            else
            {
                _vip = "no";
            }

        }

        public List<string> getFNames => _fNames;

        public List<string> getLNames => _lNames;

        public List<string> getEmails => _emails;

        public string getPaynow => _paynow;

        public string getVip => _vip;

    }
}
