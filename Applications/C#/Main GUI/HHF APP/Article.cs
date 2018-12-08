using System.Windows.Forms;

namespace HHF_APP
{
    internal class Article
    {
        public enum ArticleType
        {
            Food,
            Item
        }

        //storing the name, price and quantity of food
        private string name;
        private decimal price;
        private int quantity;
        private ArticleType tpArticleType;

        //constructor
        public Article(string name,
            decimal price,
            int quantity,
            ArticleType type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            tpArticleType = type;
        }

        //methods

        //return price
        public virtual decimal GetPrice()
        {
            return price * quantity;
        }

        //change quantity
        public void ChangeQuantity(int i)
        {
            if (i > 0)
                quantity = i;
            else
                MessageBox.Show("Minimum quantity is 1! Please use a value above 0");
        }

        //return information of article as a string
        public override string ToString()
        {
            if (tpArticleType == ArticleType.Food) return string.Format(name + ", Quantitiy: " + quantity + ", Amount: €");

            return string.Format(name + ", Quantitiy: " + quantity + ", Amount: €" + GetPrice());
        }
    }
}
