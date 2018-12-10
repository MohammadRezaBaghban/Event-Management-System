namespace HHF_APP
{
    public class Person
    {
        private int user_id, act_id, ticket_id;
        private string fname, lname;
        private decimal balance;


        public Person(int user_id, string fname, string lname, int act_id, int ticket_id
,
            decimal balance)
        { this.user_id = user_id;this.act_id = act_id;this.fname = fname;this.lname = lname; this.ticket_id = ticket_id;this.balance = balance;}

        public int User_id { get => user_id; }
        public int Act_id { get => act_id;  }
        public int Ticket_id { get => ticket_id; }
        public string Fname { get => fname; }
        public string Lname { get => lname;  }
        public decimal Balance { get => balance; }
    }
}