using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class Food : Article
    {   //here we have enums to be used in the constructors and in the ToString
        public enum MealType {Meal,Drink}

        //fields

        private MealType tyoeOfFood;
        private bool Chili, Double, Menu;
        private decimal Amount;

        //constructor for Meals
        public Food(string name, decimal price, int quantity, ArticleType atype, bool Chili,bool Double, bool Menu) : base(name, price, quantity,atype)
        {
            this.tyoeOfFood = MealType.Meal;
            this.Chili = Chili;
            this.Double = Double;
            this.Menu = Menu;
            Amount = 0m;
        }

        //constructor for drinks
        public Food(string name, decimal price, int quantity, ArticleType atype) : base(name, price, quantity,atype)
        {
            this.tyoeOfFood = MealType.Drink;
        }
        public override decimal GetPrice()
        {
            Amount = 0m;
            Amount += base.GetPrice();

            if (Chili)
            {
                Amount += 1;
            }

            if (Double)
            {
                Amount += 4;
            }

            if (Menu)
            {
                Amount += 6;
            }

          

            return Amount;
        }

        public override string ToString()
        {
            if (tyoeOfFood == MealType.Drink)
            {
                return base.ToString();
            }
             string msj=base.ToString()+Convert.ToString(value: (decimal)GetPrice());
            if (tyoeOfFood == MealType.Meal)
            {
                if (Menu)
                {
                    msj += ", Menu Meal";
                }

                if (Chili || Double)
                {
                    msj += ", with Add-ons: ";
                    if (Double)
                    {
                        msj += "| Double Toppings |";
                    }

                    if (Chili)
                    {
                        msj += "| Chili |";
                    }
                }

                return msj;
            }

            return base.ToString() + GetPrice();

        }
    }
}
