using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHF_APP
{
    abstract class Articles
    {
        //storing the name, price and quantity of food
        private string name;
        private decimal price;
        private int quantity;

        //constructor
        public Articles(string name,decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
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
            {
                this.quantity = i;
            }
            else
            {
                MessageBox.Show("Minimum quantity is 1! Please use a value above 0");
            }
        }
   
        //return information of article as a string
        public override string ToString()
        {
            return string.Format(this.name + ", Quantitiy: " + quantity + ", Amount: €");
        }

    }
}
