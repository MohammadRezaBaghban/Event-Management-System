using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using static HHF_APP.Form1;

namespace HHF_APP
{
    public partial class viewStore : UserControl
    {
        private Article newArticle;
        private Article.ArticleType ArtTypeFood;
        private Article.ArticleType ArtTypeItem;
        private DataHelper dh;

        public viewStore()
        {
            InitializeComponent();
            ArtTypeFood = Article.ArticleType.Food;
            ArtTypeItem = Article.ArticleType.Item;
            dh=new DataHelper();
      
        }

        private void viewStore_Load(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            newArticle = new Food("Pizza", 10, Convert.ToInt32(Math.Round(nud1.Value)), ArtTypeFood, cbChili1.Checked,
                cbDoubleTopping1.Checked, cbMenu1.Checked);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            newArticle = new Food("Shawarma", 6, Convert.ToInt32(Math.Round(nud2.Value)), ArtTypeFood, cbChili2.Checked,
                cbDoubleTopping2.Checked, cbMenu2.Checked);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            newArticle = new Food("Cheese Burger", (decimal) 8.5, Convert.ToInt32(Math.Round(nud3.Value)), ArtTypeFood,
                cbChili3.Checked, cbDouble.Checked, cbMenu3.Checked);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            newArticle = new Food("Greek Salad", (decimal) 4.5, Convert.ToInt32(Math.Round(nud4.Value)), ArtTypeFood);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);

        }

        private void btnAddDrink1_Click(object sender, EventArgs e)
        {
            newArticle = new Food("Cola-Original", (decimal) 1.75, Convert.ToInt32(Math.Round(nudDrink1.Value)),
                ArtTypeItem);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnAddDrink2_Click(object sender, EventArgs e)
        {
            newArticle = new Food("Cola-Zero", (decimal) 1.75, Convert.ToInt32(Math.Round(nudDrink2.Value)),
                ArtTypeItem);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnAddDrink3_Click(object sender, EventArgs e)
        {
            newArticle = new Food("Fanta", (decimal) 1.75, Convert.ToInt32(Math.Round(nudDrink3.Value)), ArtTypeItem);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnAddDrink4_Click(object sender, EventArgs e)
        {
            newArticle = new Food("Sprite", (decimal) 1.75, Convert.ToInt32(Math.Round(nudDrink4.Value)), ArtTypeItem);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnItemDrink1_Click(object sender, EventArgs e)
        {
            newArticle = new Article("Halloween Plate", 5, Convert.ToInt32(Math.Round(nudItem1.Value)), ArtTypeItem);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            newArticle = new Article("Halloween Mug", (decimal) 3.5, Convert.ToInt32(Math.Round(nudItem2.Value)),
                ArtTypeItem);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnItemDrink3_Click(object sender, EventArgs e)
        {
            newArticle = new Article("H Power Bank", 19, Convert.ToInt32(Math.Round(nudItem3.Value)), ArtTypeItem);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void btnItemDrink4_Click(object sender, EventArgs e)
        {
            newArticle = new Article("Mask", (decimal) 10.5, Convert.ToInt32(Math.Round(nudItem4.Value)), ArtTypeItem);
            lbBasket.Items.Add(newArticle);
            lbBasket_Click(sender,e);
        }

        private void lbBasket_Click(object sender, EventArgs e)
        {
            decimal total=0m;
            foreach (Article a in lbBasket.Items)
            {
                total += a.GetPrice();
            }

            lblTotal.Text = total.ToString();

        }

        private void lbChangeQuantity_Click(object sender, EventArgs e)
        {try
            {
            (lbBasket.SelectedItem as Article)?.ChangeQuantity(Convert.ToInt32(tbquantity.Text));
            lbBasket.Items[lbBasket.SelectedIndex] = lbBasket.Items[lbBasket.SelectedIndex];
            lbBasket_Click( sender,  e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a number as quantity");
            }
            catch(Exception)
            {
                MessageBox.Show("Select something to change quantity");
            }
        }

        private void btnRemoveBasketItem_Click(object sender, EventArgs e)
        {
            if (lbBasket.SelectedItem != null)
            {
            lbBasket.Items.Remove(lbBasket.SelectedItem);
                lbBasket_Click(sender, e);
            }
            else
            {
               MessageBox.Show("Nothing is selected "); 
            }
            
        }

        private void btnUndoFoods_Click(object sender, EventArgs e)
        {
            try
            {
                lbBasket.Items.RemoveAt(lbBasket.Items.Count - 1);
                lbBasket_Click(sender, e);
            }
            catch 
            {
                MessageBox.Show("There are no more Items in the list");
            }

        }

        private void btnConfirmFood_Click(object sender, EventArgs e)
        {
            
            decimal totalfood=0m;
            var confirmResult =  MessageBox.Show("Are you sure you want to confirm order?",
                "Confirm Order",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {

                    lbBasket_Click(sender, e);
                    Form1 myParent = (Form1) this.Parent;
                    int user_id = Convert.ToInt32(myParent.tbBarcode.Text);

                    if (user_id > 0)
                    {
                        foreach (Article a in lbBasket.Items)
                        {
                            if (a is Food)
                            {
                                totalfood += a.GetPrice();
                            }
                        }



                        decimal total;
                        total = Convert.ToDecimal(lblTotal.Text);
                        int checkinsertion=1;
                        int checkinsertion2 = 1;
                        if (total - totalfood != 0)
                        {
                            if (dh.addTransaction(user_id, (total - totalfood), "items") != 1) checkinsertion = 0;
                        }

                        if (totalfood > 0) {if (dh.addTransaction(user_id, totalfood, "food")!= 1) checkinsertion2=0;}

                        if (checkinsertion == 1 && checkinsertion2 == 1)
                        {
                            MessageBox.Show("Order Complete!");
                            lbBasket.Items.Clear();
                            myParent.tbBarcode.Text = "0";
                            myParent.btnSearch_Click(sender,e);
                        }
                        else
                        {
                            MessageBox.Show("Error while adding order!");
                        }
                    }
                    else
                    {
                        throw new Exception("No person with that id");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void lbBasket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
