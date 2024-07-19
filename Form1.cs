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
            
            lblTotalPriceValue.Text="$"+(int.Parse(rbSmall.Tag.ToString())+int.Parse(rbThin.Tag.ToString())).ToString();
   
        }

        void ChangeTotalPrizeLabelbasedOnChangeOnPrize(int Prize)
        {
            int TotalPrize;
            TotalPrize = int.Parse(lblTotalPriceValue.Text.Substring(1,lblTotalPriceValue.Text.Length-1));
            TotalPrize += Prize;
            lblTotalPriceValue.Text = "$"+TotalPrize.ToString();
        }

        int GetPrize(RadioButton rb)
        {
            int temp;
            if(rb.Tag==null || !int.TryParse(rb.Tag.ToString(),out temp)) return 0;
            int Prize = Convert.ToInt32(rb.Tag);
            Prize *= (rb.Checked) ? 1 : -1;
            return Prize;
        }

        int GetPrize(CheckBox chk)
        {
            int temp;
            if (chk.Tag == null || !int.TryParse(chk.Tag.ToString(), out temp)) return 0;
            int Prize = Convert.ToInt32(chk.Tag);
            Prize *= (chk.Checked) ? 1 : -1;
            return Prize;
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(rbSmall));
            lblSizeValue.Text = rbSmall.Text;
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(rbMedium));
            lblSizeValue.Text = rbMedium.Text;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(rbLarge));
            lblSizeValue.Text = rbLarge.Text;

        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(rbThin));
            lblCrustTypeValue.Text = rbThin.Text;
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(rbThick));
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

        string RemoveSubStringFromString(string S1 ,string SubString)
        {
            return S1.Remove(S1.IndexOf(SubString),SubString.Length);
        }

        void DeleteToppingFromToppingsLabel(CheckBox chkTopping)
        {
            if (lblToppingsValue.Text.IndexOf(chkTopping.Text) == 0)
            {
                if (lblToppingsValue.Text == chkTopping.Text)
                {
                    lblToppingsValue.Text = default(string);
                    lblToppingsValue.Text = "No Toppings";
                }
                else
                {
                    lblToppingsValue.Text = RemoveSubStringFromString(lblToppingsValue.Text, chkTopping.Text + ",");
                }

            }
            else
            {
                lblToppingsValue.Text = RemoveSubStringFromString(lblToppingsValue.Text, "," + chkTopping.Text);
            }
        }

        void ChangeToppingsLabel(CheckBox chkTopping)
        {

            if (chkTopping.Checked)
            {
                if (lblToppingsValue.Text == "No Toppings") lblToppingsValue.Text = "";
                if(lblToppingsValue.Text!="") lblToppingsValue.Text += ",";
                lblToppingsValue.Text += chkTopping.Text;
            }
            else 
            {
                DeleteToppingFromToppingsLabel(chkTopping);
            }
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(chkExtraCheese));
            ChangeToppingsLabel(chkExtraCheese);
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(chkOnion));
            ChangeToppingsLabel(chkOnion);
        }

        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(chkMashrooms));
            ChangeToppingsLabel(chkMashrooms);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(chkOlives));
            ChangeToppingsLabel(chkOlives);
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(chkTomatoes));
            ChangeToppingsLabel(chkTomatoes);
        }

        private void chkGreenPepeers_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTotalPrizeLabelbasedOnChangeOnPrize(GetPrize(chkGreenPepeers));
            ChangeToppingsLabel(chkGreenPepeers);
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Order","Confirm Order",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==DialogResult.Yes)
            {
                MessageBox.Show("Ordered Success");
                gbCrust.Enabled = false;
                gbPizzaSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbCrust.Enabled = true;
            gbPizzaSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;
            rbSmall.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;
            chkExtraCheese.Checked = false;
            chkGreenPepeers.Checked = false;
            chkMashrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked=false;
            chkTomatoes.Checked = false;

        }
    }
}
