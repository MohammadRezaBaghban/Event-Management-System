//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;


//namespace HHF_APP
//{
//    class store
//    {
//        private string name;
//        public List<Article> MyArticles;

//        public store(string name)
//        {
//            this.name = name;
//            MyArticles = new  List<Article>();
//        }

//        public bool addFoodArticle(string name,decimal price, int quantity,bool chili,bool Double,bool Menu)
//        {
//            try
//            {
//                //Article s = new Food(name, price, quantity, chili, Double, Menu);
//                MyArticles.Add(s);
//                return true;
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message);
//                return false;
//            }  
//        }
//        public bool addArticle(string name,decimal price, int quantity)
//        {
//            try
//            {
//              //  Article s = new Food(name, price, quantity);
//                MyArticles.Add(s);
//                return true;
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message);
//                return false;
//            }  
//        }


//    }
//}
