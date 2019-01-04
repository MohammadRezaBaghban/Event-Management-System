using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class Transactions
    {
        private int transaction_id,transaction_amount;
        private string transaction_type,date,time;

        public Transactions(int transaction_id,int transaction_amount,string transaction_type,string date,string time)
        {
            this.transaction_id = transaction_id;
            this.transaction_amount = transaction_amount;
            this.transaction_type = transaction_type;
            this.date = date;
            date = date.Split(' ')[0];
            this.time = time;
        }

        public int getTransactionId { get => transaction_id; }
        public int getTransactionAmount { get => transaction_amount; }
        public string getTransactionType { get => transaction_type; }
        public string getTransactionDate => date;
        public string getTransactionTime { get => time; }


        public override string ToString()
        {
            return this.getTransactionId + ", " + this.getTransactionType + ", "
                   + this.getTransactionAmount + ", " + this.getTransactionDate.Split(' ')[0] + ", " + this.getTransactionTime;
        }
    }
}