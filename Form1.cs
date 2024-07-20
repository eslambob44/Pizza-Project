using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void frmPizzaOrder_Shown(object sender, EventArgs e)
        {
            
            lblTotalPriceValue.Text="$"+GetTotalPrice().ToString();
   
        }

        void ChangeToppingsLabel()
        {
            string ToppingsLabel = "";
            if(chkExtraCheese.Checked) 
            { 
                ToppingsLabel = chkExtraCheese.Text; 
            }
            if(chkGreenPepeers.Checked)
            {
                ToppingsLabel += "," + chkGreenPepeers.Text;
            }
            if(chkMashrooms.Checked)
            {
                ToppingsLabel += "," + chkMashrooms.Text;
            }
            if(chkOlives.Checked)
            {
                ToppingsLabel += "," + chkOlives.Text;
            }
            if(chkOnion.Checked)
            {
                ToppingsLabel+= "," + chkOnion.Text;
            }
            if(chkTomatoes.Checked)
            {
                ToppingsLabel += "," + chkTomatoes.Text;
            }

            if(ToppingsLabel!="")
            {
                if (ToppingsLabel.ElementAt(0) == ',')
                {
                    ToppingsLabel = ToppingsLabel.Substring(1);
                }
            }
            if(ToppingsLabel=="")
            {
                ToppingsLabel = "No Toppings";
            }
            
            lblToppingsValue.Text = ToppingsLabel;
        }

        void ChangeTotalPrizeLabel()
        {
            lblTotalPriceValue.Text = "$" + GetTotalPrice().ToString();
        }



        float GetSizePrice()
        {
            if(rbSmall.Checked) 
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            if(rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            if (rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
            return 0;
        }

        float GetCrustPrice()
        {
            if(rbThin.Checked)
            {
                return Convert.ToSingle(rbThin.Tag);
            }
            if(rbThick.Checked)
            {
                return Convert.ToSingle(rbThick.Tag);
            }
            return 0;
        }

        float GetToppingsPrice()
        {
            float ToppingsPrice = 0;
            if(chkExtraCheese.Checked)
            {
                ToppingsPrice +=Convert.ToSingle(chkExtraCheese.Tag);
            }

            if(chkGreenPepeers.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkGreenPepeers.Tag);
            }

            if(chkMashrooms.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkMashrooms.Tag);
            }

            if(chkOlives.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if(chkOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if(chkTomatoes.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            return ToppingsPrice;
        }

        float GetTotalPrice()
        {
            return GetSizePrice() + GetCrustPrice() + GetToppingsPrice();
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            
            
            lblSizeValue.Text = rbSmall.Text;
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            lblSizeValue.Text = rbMedium.Text;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            lblSizeValue.Text = rbLarge.Text;

        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            lblCrustTypeValue.Text = rbThin.Text;
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            lblCrustTypeValue.Text = rbThick.Text;
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEatValue.Text = rbEatIn.Text;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEatValue.Text = rbTakeOut.Text;
        }

        


        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            ChangeToppingsLabel();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            ChangeToppingsLabel();
        }

        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            ChangeToppingsLabel();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            ChangeToppingsLabel();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            ChangeToppingsLabel();
        }

        private void chkGreenPepeers_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabel();
            ChangeToppingsLabel();
        }

        void ConfirmOrder()
        {
            MessageBox.Show("Ordered Success");
            gbCrust.Enabled = false;
            gbPizzaSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
            btnOrderPizza.Enabled = false;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Order","Confirm Order",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==DialogResult.Yes)
            {
                ConfirmOrder();
            }
        }

        

        void ResetForm()
        {
            gbCrust.Enabled = true;
            gbPizzaSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            btnOrderPizza.Enabled = true;

            rbMedium.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;

            chkExtraCheese.Checked = false;
            chkGreenPepeers.Checked = false;
            chkMashrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();

        }
    }
}
