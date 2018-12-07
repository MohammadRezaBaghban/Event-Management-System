using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHF_APP
{
    class Food : Articles
    {   //here we have enums to be used in the constructors and in the ToString
        public enum type {Meal,Drink}

        //fields

        private type tyoeOfFood;
        private bool Chili, Double, Menu;
        private decimal Amount;

        //constructor for Meals
        public Food(string name, decimal price, int quantity, bool Chili,bool Double, bool Menu) : base(name, price, quantity)
        {
            this.tyoeOfFood = type.Meal;
            this.Chili = Chili;
            this.Double = Double;
            this.Menu = Menu;
         
        }

        //constructor for drinks
        public Food(string name, decimal price, int quantity) : base(name, price, quantity)
        {
            this.tyoeOfFood = type.Drink;
        }
        public override decimal GetPrice()
        {
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

            Amount += base.GetPrice();

            return Amount;
        }

        public override string ToString()
        {
             string msj=base.ToString() + Amount;
            if (tyoeOfFood == type.Meal)
            {
                if (Menu)
                {
                    msj += ", Menu Meal";
                }

                if (Chili || Double)
                {
                    msj += "with Add-ons: ";
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

            return string.Format(base.ToString() + Amount);
        }
    }
}
