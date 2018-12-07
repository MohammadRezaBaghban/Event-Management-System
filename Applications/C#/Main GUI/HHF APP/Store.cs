using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HHF_APP
{
    class store
    {
        public List<Articles> MyArticleses;

        public store()
        {
            MyArticleses = new  List<Articles>();
        }

        public bool addFoodArticle(string name,decimal price, int quantity,bool chili,bool Double,bool Menu)
        {
            try
            {
                Articles s = new Food(name, price, quantity, chili, Double, Menu);
                MyArticleses.Add(s);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }  
        }
    }
}
