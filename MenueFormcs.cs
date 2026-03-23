using System;
using System.Text;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmMenueForm : Form
    {
        public frmMenueForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(chkAll.Enabled)
            {
                if (MessageBox.Show("Are you Sure you want to Leave this Page"
                 , "Canceling Order",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question
                 , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ResetOrder();
                }
                else
                {
                    return;
                }
            }  
            
            this.Close();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                chkExtraCheese.Enabled = false;
                chkGreenPeppers.Enabled = false;
                chkMushrooms.Enabled = false;
                chkOlives.Enabled = false;
                chkOnion.Enabled = false;
                chkTomatos.Enabled = false;


                chkExtraCheese.Checked = true;
                chkGreenPeppers.Checked = true;
                chkMushrooms.Checked = true;
                chkOlives.Checked = true;
                chkOnion.Checked = true;
                chkTomatos.Checked = true;
            }
            else
            {
                chkExtraCheese.Enabled = true;
                chkGreenPeppers.Enabled = true;
                chkMushrooms.Enabled = true;
                chkOlives.Enabled = true;
                chkOnion.Enabled = true;
                chkTomatos.Enabled = true;

                chkExtraCheese.Checked = false;
                chkGreenPeppers.Checked = false;
                chkMushrooms.Checked = false;
                chkOlives.Checked = false;
                chkOnion.Checked = false;
                chkTomatos.Checked = false;
            }

            ChangeToppingsListLabel();

            ChangeTotalPrice();


        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeChange.Text = "Small";
            ChangeTotalPrice();

            if (rbSmall.Checked)
            {
               
                btnResetOrder.Enabled = true;

                EnableChioces();
            }
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeChange.Text = "Meduim";
            ChangeTotalPrice();

            if (rbMeduim.Checked)
            {
              
                btnResetOrder.Enabled = true;

                EnableChioces();
            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeChange.Text = "Large";
            ChangeTotalPrice();

            if (rbLarge.Checked)
            {
               
                btnResetOrder.Enabled = true;

                EnableChioces();
            }
        }

        private void ChangeToppingsListLabel()
        {
            string Temp = default;

            if (chkExtraCheese.Checked) Temp += chkExtraCheese.Text + ", ";
            if (chkGreenPeppers.Checked) Temp += chkGreenPeppers.Text + ", ";
            if (chkMushrooms.Checked) Temp += chkMushrooms.Text + ", ";
            if (chkOlives.Checked) Temp += chkOlives.Text + ", ";
            if (chkTomatos.Checked) Temp += chkTomatos.Text + ", ";
            if (chkOnion.Checked) Temp += chkOnion.Text + ", ";

            if(Temp!="")
            {
                //Temp = Temp.Substring(0, Temp.Length - 1);
            }

            txtToppingsList.Text = Temp;
        }

        private void ChangeTotalPrice()
        {
            int Temp = 0;

            if (rbSmall.Checked) Temp += Convert.ToInt32(rbSmall.Tag);
            if (rbMeduim.Checked) Temp += Convert.ToInt32(rbMeduim.Tag);
            if (rbLarge.Checked) Temp += Convert.ToInt32(rbLarge.Tag);
            if (rbThick.Checked) Temp += Convert.ToInt32(rbThick.Tag);
            if (rbThin.Checked) Temp += Convert.ToInt32(rbThin.Tag);
            if (rbEatIn.Checked) Temp += Convert.ToInt32(rbEatIn.Tag);
            if (rbTakeAway.Checked) Temp += Convert.ToInt32(rbTakeAway.Tag);
            if (chkExtraCheese.Checked) Temp += Convert.ToInt32(chkExtraCheese.Tag);
            if (chkGreenPeppers.Checked) Temp += Convert.ToInt32(chkGreenPeppers.Tag);
            if (chkMushrooms.Checked) Temp += Convert.ToInt32(chkMushrooms.Tag);
            if (chkOlives.Checked) Temp += Convert.ToInt32(chkOlives.Tag);
            if (chkOnion.Checked) Temp += Convert.ToInt32(chkOnion.Tag);
            if (chkTomatos.Checked) Temp += Convert.ToInt32(chkTomatos.Tag);
            if (chkAll.Checked) Temp += (Convert.ToInt32(chkAll.Tag)-12);

            lblPrice.Text = Convert.ToString(Temp) + "$";

            lblPrice.Tag = Convert.ToString(Temp);

            if (Convert.ToByte(lblPrice.Tag) != 0)
            {
                decimal TotalPrice = Convert.ToDecimal(lblPrice.Tag);
                TotalPrice *= numericUpDown1.Value;

                lblPrice.Text = TotalPrice.ToString();
            }
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToppingsListLabel();
            ChangeTotalPrice();
            

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToppingsListLabel();
            ChangeTotalPrice();
           


        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToppingsListLabel();
            ChangeTotalPrice();
            


        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToppingsListLabel();
            ChangeTotalPrice();
          


        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToppingsListLabel();
            ChangeTotalPrice();
          


        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToppingsListLabel();
            ChangeTotalPrice();
          


        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked) txtCrustType.Text = rbThin.Text;
            else
                txtCrustType.Text = "";

            ChangeTotalPrice();

            if ((rbThick.Checked || rbThin.Checked) && (rbEatIn.Checked || rbTakeAway.Checked))
                btnTakeOrder.Enabled = true;
            else
                btnTakeOrder.Enabled = false;



        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked) txtCrustType.Text = rbThick.Text;
            else
                txtCrustType.Text = "";

            ChangeTotalPrice();

            if ((rbThick.Checked || rbThin.Checked) && (rbEatIn.Checked || rbTakeAway.Checked))
                btnTakeOrder.Enabled = true;
            else
                btnTakeOrder.Enabled = false;

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked) txtWhereToEat.Text = rbEatIn.Text;
            else
                txtWhereToEat.Text = "";

            ChangeTotalPrice();

            if ((rbThick.Checked || rbThin.Checked) && (rbEatIn.Checked || rbTakeAway.Checked))
                btnTakeOrder.Enabled = true;
            else
                btnTakeOrder.Enabled = false;

        }

        private void rbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeAway.Checked) txtWhereToEat.Text = rbTakeAway.Text;
            else
                txtWhereToEat.Text = "";

            ChangeTotalPrice();

            if ((rbThick.Checked || rbThin.Checked)&&(rbEatIn.Checked||rbTakeAway.Checked))
                btnTakeOrder.Enabled = true;
            else
                btnTakeOrder.Enabled = false;
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to take this Order"
                , "Taking Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==DialogResult.Yes)
            {
                Form frmOrderSheet = new frmOrderSheet(lblPrice.Text);
                frmOrderSheet.ShowDialog();

            }
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Reset this Order"
                , "Reseting Order",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ResetOrder();
            }
        }

        private void EnableChioces()
        {
            rbThick.Enabled = true;
            rbThin.Enabled = true;
            chkGreenPeppers.Enabled = true;
            chkTomatos.Enabled = true;
            chkExtraCheese.Enabled = true;
            chkMushrooms.Enabled = true;
            chkAll.Enabled = true;
            chkOlives.Enabled = true;
            chkOnion.Enabled = true;
            rbEatIn.Enabled = true;
            rbTakeAway.Enabled = true;
        }

        private void ResetOrder()
        {
            rbSmall.Checked = false;
            rbMeduim.Checked = false;
            rbLarge.Checked = false;
            rbThick.Checked = false;
            rbThin.Checked = false;
            rbEatIn.Checked = false;
            rbTakeAway.Checked = false;
            chkExtraCheese.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatos.Checked = false;
            chkAll.Checked = false;

            DisableControls();
        }

        private void DisableControls()
        {
            rbThick.Enabled = false;
            rbThin.Enabled = false;
            rbEatIn.Enabled = false;
            rbTakeAway.Enabled = false;
            chkExtraCheese.Enabled = false;
            chkGreenPeppers.Enabled = false;
            chkMushrooms.Enabled = false;
            chkOlives.Enabled = false;
            chkOnion.Enabled = false;
            chkTomatos.Enabled = false;
            chkAll.Enabled = false;
            btnTakeOrder.Enabled = false;
            btnResetOrder.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ChangeTotalPrice();
            lblNumberOfPizza.Text = numericUpDown1.Value.ToString();
        }
    }
}
