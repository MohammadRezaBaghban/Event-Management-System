using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class ReturnLoaned
    {
        private int transaction_id, article_nr, loaned_id;
        private string article_status,article_type;

        public ReturnLoaned(int loaned_id, int transaction_id, int article_nr,string article_status,string article_type)
        {
            this.loaned_id = loaned_id;
            this.transaction_id = transaction_id;
            this.article_nr = article_nr;
            this.article_status = article_status;
            this.article_type = article_type;
        }

        public int getLoanedId { get => loaned_id; }
        public int getTransactionId { get => transaction_id; }
        public int getArticleNr { get => article_nr; }
        public string getArticleStatus { get => article_status; }
        public string getArticleType { get => article_type; }

        public override string ToString()
        {
            return "" + " " + article_type + " " + " , " + " " + article_status + " " + " , " + this.article_nr;
        }
    }
}
