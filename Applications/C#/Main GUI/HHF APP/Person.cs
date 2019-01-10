using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class Person
    {
        private int user_id, act_id, ticket_id;
        private string group_id;
        private string fname, lname,Vstatus,status,tickettype;
        private decimal balance;


        public Person(int user_id, string groupId,string fname, string lname, int act_id, int ticket_id, decimal balance,string Vstatus,string valid,string tictype)
        {
            this.user_id = user_id;
            this.group_id = groupId;
            this.act_id = act_id;
            this.fname = fname;
            this.lname = lname;
            
            if (valid == "yes")
            {
                this.status = "VALID";
            }
            else this.status = "NOT VALID";


            if (tictype == "yes")
            {
                this.tickettype = "VIP";
            }
            
            else if (tictype == "no" && groupId != "NULL")
            {
                this.tickettype = "GROUP";
            }
            else
            {
                this.tickettype = "INDIVIDUAL";
            }

            this.ticket_id = ticket_id;
            this.balance = balance;

            if (Vstatus == "checked_in")
            {
                this.Vstatus = "CHECKED IN";
            } else if (Vstatus == "check_out")
            {
                this.Vstatus = "CHECKED OUT";
            }
            else if(Vstatus=="") { this.Vstatus = "PENDING"; };
        }


        public Person(string fname, string lname , string groupid)
        {
            this.fname = fname;
            this.lname = lname;
            this.group_id = groupid;
        }


        public int getUserId { get => user_id; }
        public int getActId { get => act_id; }
        public int getTicketId { get => ticket_id; }
        public string getName { get => fname + " " + lname; }
        public string getTicketvalidity { get => status; }
        public string getTicketType { get => tickettype; }
        public decimal getBalance { get => balance; }
        public string getVisitorStatus { get =>Vstatus; }

        public override string ToString()
        {
            return "Name(s) :" + " "+ this.getName + " " +" Group id :" +" " + this.group_id;
        }

    }
}
