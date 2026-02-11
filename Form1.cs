namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        void StopChange()
        {
           
            grSize.Enabled = false;
            groupBox1.Enabled = false;  
            grToppings.Enabled = false;
            grWhereToEate.Enabled = false;
        }

        void StartChange()
        {
            
            grSize.Enabled = true;
            groupBox1.Enabled = true;
            grToppings.Enabled = true;
            grWhereToEate.Enabled = true;
        }

         
        float PriceCalculate()
        {
            float TotalPrice = 0;

            if (rdLarg.Checked) TotalPrice += float.Parse(rdLarg.Tag.ToString());
            else if (rdMedium.Checked) TotalPrice += float.Parse(rdMedium.Tag.ToString());
            else if (rdSmall.Checked) TotalPrice += float.Parse(rdSmall.Tag.ToString());

            if (rdThickCrust.Checked) TotalPrice += float.Parse(rdThickCrust.Tag.ToString());
            else if (rdThinCrust.Checked) TotalPrice += float.Parse(rdThinCrust.Tag.ToString());

            if (chkExtraChees.Checked) TotalPrice += float.Parse(chkExtraChees.Tag.ToString());
            if (chkMushrooms.Checked) TotalPrice += float.Parse(chkMushrooms.Tag.ToString());
            if (chkTomatoes.Checked) TotalPrice += float.Parse(chkTomatoes.Tag.ToString());
            if (chkOnion.Checked) TotalPrice += float.Parse(chkOnion.Tag.ToString());
            if (chkOlives.Checked) TotalPrice += float.Parse(chkOlives.Tag.ToString());
            if (chkGreenPeppers.Checked) TotalPrice += float.Parse(chkGreenPeppers.Tag.ToString());

            return TotalPrice;
        }

        void UpdateOrder()
        {
            float currentPrice = PriceCalculate();
            lbPrice.Text = "$" + currentPrice.ToString();
        }

        void UpdateBillDetails() 
        {
             
            if (rdLarg.Checked) lbSizeBill.Text = "Large";
            else if (rdMedium.Checked) lbSizeBill.Text = "Medium";
            else if (rdSmall.Checked) lbSizeBill.Text = "Small";

            
            if (rdThickCrust.Checked) lbCrustTypeBill.Text = "Thick";
            else if (rdThinCrust.Checked) lbCrustTypeBill.Text = "Thin";

             
            string Toppings = "";
            if (chkExtraChees.Checked) Toppings += "Extra Cheese\n";
            if (chkMushrooms.Checked) Toppings += "Mushrooms\n";
            if (chkTomatoes.Checked) Toppings += "Tomatoes\n";
            if (chkOnion.Checked) Toppings += "Onion\n";
            if (chkOlives.Checked) Toppings += "Olives\n";
            if (chkGreenPeppers.Checked) Toppings += "Green Peppers\n";

           
            if (Toppings == "") Toppings = "No Toppings";

            lbToppingsBill.Text = Toppings;

            
            if (rdEateIn.Checked) lbWheretoEatBill.Text = "Eat In";
            else if (rdTakeOut.Checked) lbWheretoEatBill.Text = "Take Out";

             
            lbPriceBill.Text = lbPrice.Text;
        }

        bool IsOrderComplete()  
        {
            
            return ((rdLarg.Checked || rdMedium.Checked || rdSmall.Checked) &&
                    (rdThickCrust.Checked || rdThinCrust.Checked) &&
                    (rdTakeOut.Checked || rdEateIn.Checked));
        }

       
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderComplete())
            {
                UpdateBillDetails();
                StopChange(); 
                pnlSummary.Visible = true;  
            }
            else
            {
                MessageBox.Show("You must select Size, Crust, and Where to eat!", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset the form?", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                rdSmall.Checked = false;
                rdMedium.Checked = false;
                rdLarg.Checked = false;

                rdThinCrust.Checked = false;
                rdThickCrust.Checked = false;

                rdEateIn.Checked = false;
                rdTakeOut.Checked = false;

                chkExtraChees.Checked = false;
                chkMushrooms.Checked = false;
                chkTomatoes.Checked = false;
                chkOnion.Checked = false;
                chkOlives.Checked = false;
                chkGreenPeppers.Checked = false;

                lbPrice.Text = "$0.00";

                StartChange(); 
                pnlSummary.Visible = false;
            }
        }
 
        private void rdLarg_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void rdMedium_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void rdSmall_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void rdThickCrust_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void rdThinCrust_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkExtraChees_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkOnion_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkOlives_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
    }
}