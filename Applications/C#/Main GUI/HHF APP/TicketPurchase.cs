using System.Text;
using CryptSharp.Utility;
using DevOne.Security.Cryptography.BCrypt;

namespace HHF_APP
{
    class TicketPurchase
    {
        private readonly string _fName, _lName, _email, _password, _phone, _iban;
        private readonly decimal _topUp;

        public TicketPurchase(string fName, string lName, string email, string password, string phone, string iban, decimal topUp)
        {
            _fName = fName;
            _lName = lName;
            _email = email;

            _password = BCryptHelper.HashPassword(password, getSalt());
            _phone = phone;
            _iban = iban;
            _topUp = topUp;
        }

        private static string getSalt()
        {

            return BCryptHelper.GenerateSalt();
        }
        public string getFName => _fName;
        public string getLName => _lName;

        public string getEmail => _email;

        public string getPassword => _password;

        public string getPhone => _phone;

        public string getIban => _iban;

        public decimal getTopUp => _topUp;
    }
}
