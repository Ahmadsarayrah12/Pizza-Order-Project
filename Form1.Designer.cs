namespace Pizza_Project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TitleLable = new Label();
            grSize = new GroupBox();
            rdSmall = new RadioButton();
            rdMedium = new RadioButton();
            rdLarg = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rdThinCrust = new RadioButton();
            rdThickCrust = new RadioButton();
            grToppings = new GroupBox();
            chkGreenPeppers = new CheckBox();
            chkOlives = new CheckBox();
            chkOnion = new CheckBox();
            chkTomatoes = new CheckBox();
            chkMushrooms = new CheckBox();
            chkExtraChees = new CheckBox();
            rdEateIn = new RadioButton();
            grWhereToEate = new GroupBox();
            rdTakeOut = new RadioButton();
            btnOrder = new Button();
            btnReset = new Button();
            pnlSummary = new Panel();
            lblTitleSummary = new Label();
            lblTitleSize = new Label();
            lbSizeBill = new Label();
            lblTitleCrust = new Label();
            lbCrustTypeBill = new Label();
            lblTitleWhere = new Label();
            lbWheretoEatBill = new Label();
            lblTitleToppings = new Label();
            lbToppingsBill = new Label();
            lblTitleTotal = new Label();
            lbPriceBill = new Label();
            lbPrice = new Label();
            grSize.SuspendLayout();
            groupBox1.SuspendLayout();
            grToppings.SuspendLayout();
            grWhereToEate.SuspendLayout();
            pnlSummary.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLable
            // 
            TitleLable.AutoSize = true;
            TitleLable.BackColor = Color.Transparent;
            TitleLable.Font = new Font("Showcard Gothic", 38F, FontStyle.Bold);
            TitleLable.ForeColor = Color.DarkOrange;
            TitleLable.Location = new Point(576, 32);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(636, 63);
            TitleLable.TabIndex = 0;
            TitleLable.Text = "🍕 Pizza Restaurant 🍕";
            // 
            // grSize
            // 
            grSize.BackColor = Color.Transparent;
            grSize.Controls.Add(rdSmall);
            grSize.Controls.Add(rdMedium);
            grSize.Controls.Add(rdLarg);
            grSize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grSize.ForeColor = Color.Chocolate;
            grSize.Location = new Point(68, 40);
            grSize.Name = "grSize";
            grSize.Size = new Size(300, 60);
            grSize.TabIndex = 1;
            grSize.TabStop = false;
            grSize.Text = "📏 Size";
            // 
            // rdSmall
            // 
            rdSmall.AutoSize = true;
            rdSmall.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdSmall.ForeColor = Color.Black;
            rdSmall.Location = new Point(170, 25);
            rdSmall.Name = "rdSmall";
            rdSmall.Size = new Size(64, 23);
            rdSmall.TabIndex = 2;
            rdSmall.TabStop = true;
            rdSmall.Tag = "10";
            rdSmall.Text = "Small";
            rdSmall.UseVisualStyleBackColor = true;
            rdSmall.CheckedChanged += rdSmall_CheckedChanged;
            // 
            // rdMedium
            // 
            rdMedium.AutoSize = true;
            rdMedium.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdMedium.ForeColor = Color.Black;
            rdMedium.Location = new Point(80, 25);
            rdMedium.Name = "rdMedium";
            rdMedium.Size = new Size(82, 23);
            rdMedium.TabIndex = 1;
            rdMedium.TabStop = true;
            rdMedium.Tag = "20";
            rdMedium.Text = "Medium";
            rdMedium.UseVisualStyleBackColor = true;
            rdMedium.CheckedChanged += rdMedium_CheckedChanged;
            // 
            // rdLarg
            // 
            rdLarg.AutoSize = true;
            rdLarg.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdLarg.ForeColor = Color.Black;
            rdLarg.Location = new Point(6, 25);
            rdLarg.Name = "rdLarg";
            rdLarg.Size = new Size(65, 23);
            rdLarg.TabIndex = 0;
            rdLarg.TabStop = true;
            rdLarg.Tag = "30";
            rdLarg.Text = "Large";
            rdLarg.UseVisualStyleBackColor = true;
            rdLarg.CheckedChanged += rdLarg_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 2;
            label1.Text = "📝 Pizza Details";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rdThinCrust);
            groupBox1.Controls.Add(rdThickCrust);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Chocolate;
            groupBox1.Location = new Point(68, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 60);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "🍞 Crust Type";
            // 
            // rdThinCrust
            // 
            rdThinCrust.AutoSize = true;
            rdThinCrust.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdThinCrust.ForeColor = Color.Black;
            rdThinCrust.Location = new Point(80, 25);
            rdThinCrust.Name = "rdThinCrust";
            rdThinCrust.Size = new Size(55, 23);
            rdThinCrust.TabIndex = 1;
            rdThinCrust.TabStop = true;
            rdThinCrust.Tag = "0";
            rdThinCrust.Text = "Thin";
            rdThinCrust.UseVisualStyleBackColor = true;
            rdThinCrust.CheckedChanged += rdThinCrust_CheckedChanged;
            // 
            // rdThickCrust
            // 
            rdThickCrust.AutoSize = true;
            rdThickCrust.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdThickCrust.ForeColor = Color.Black;
            rdThickCrust.Location = new Point(6, 25);
            rdThickCrust.Name = "rdThickCrust";
            rdThickCrust.Size = new Size(62, 23);
            rdThickCrust.TabIndex = 0;
            rdThickCrust.TabStop = true;
            rdThickCrust.Tag = "5";
            rdThickCrust.Text = "Thick";
            rdThickCrust.UseVisualStyleBackColor = true;
            rdThickCrust.CheckedChanged += rdThickCrust_CheckedChanged;
            // 
            // grToppings
            // 
            grToppings.BackColor = Color.Transparent;
            grToppings.Controls.Add(chkGreenPeppers);
            grToppings.Controls.Add(chkOlives);
            grToppings.Controls.Add(chkOnion);
            grToppings.Controls.Add(chkTomatoes);
            grToppings.Controls.Add(chkMushrooms);
            grToppings.Controls.Add(chkExtraChees);
            grToppings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grToppings.ForeColor = Color.Chocolate;
            grToppings.Location = new Point(68, 199);
            grToppings.Name = "grToppings";
            grToppings.Size = new Size(300, 215);
            grToppings.TabIndex = 4;
            grToppings.TabStop = false;
            grToppings.Text = "🧀 Toppings";
            // 
            // chkGreenPeppers
            // 
            chkGreenPeppers.AutoSize = true;
            chkGreenPeppers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkGreenPeppers.ForeColor = Color.Black;
            chkGreenPeppers.Location = new Point(17, 167);
            chkGreenPeppers.Name = "chkGreenPeppers";
            chkGreenPeppers.Size = new Size(127, 23);
            chkGreenPeppers.TabIndex = 5;
            chkGreenPeppers.Tag = "2";
            chkGreenPeppers.Text = "Green Peppers";
            chkGreenPeppers.UseVisualStyleBackColor = true;
            chkGreenPeppers.CheckedChanged += chkGreenPeppers_CheckedChanged;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkOlives.ForeColor = Color.Black;
            chkOlives.Location = new Point(17, 138);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(69, 23);
            chkOlives.TabIndex = 4;
            chkOlives.Tag = "2";
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            chkOlives.CheckedChanged += chkOlives_CheckedChanged;
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkOnion.ForeColor = Color.Black;
            chkOnion.Location = new Point(17, 109);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(68, 23);
            chkOnion.TabIndex = 3;
            chkOnion.Tag = "2";
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += chkOnion_CheckedChanged;
            // 
            // chkTomatoes
            // 
            chkTomatoes.AutoSize = true;
            chkTomatoes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkTomatoes.ForeColor = Color.Black;
            chkTomatoes.Location = new Point(17, 80);
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Size = new Size(93, 23);
            chkTomatoes.TabIndex = 2;
            chkTomatoes.Tag = "3";
            chkTomatoes.Text = "Tomatoes";
            chkTomatoes.UseVisualStyleBackColor = true;
            chkTomatoes.CheckedChanged += chkTomatoes_CheckedChanged;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkMushrooms.ForeColor = Color.Black;
            chkMushrooms.Location = new Point(17, 51);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(106, 23);
            chkMushrooms.TabIndex = 1;
            chkMushrooms.Tag = "3";
            chkMushrooms.Text = "Mushrooms";
            chkMushrooms.UseVisualStyleBackColor = true;
            chkMushrooms.CheckedChanged += chkMushrooms_CheckedChanged;
            // 
            // chkExtraChees
            // 
            chkExtraChees.AutoSize = true;
            chkExtraChees.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkExtraChees.ForeColor = Color.Black;
            chkExtraChees.Location = new Point(18, 22);
            chkExtraChees.Name = "chkExtraChees";
            chkExtraChees.Size = new Size(113, 23);
            chkExtraChees.TabIndex = 0;
            chkExtraChees.Tag = "5";
            chkExtraChees.Text = "Extra Cheese";
            chkExtraChees.UseVisualStyleBackColor = true;
            chkExtraChees.CheckedChanged += chkExtraChees_CheckedChanged;
            // 
            // rdEateIn
            // 
            rdEateIn.AutoSize = true;
            rdEateIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdEateIn.ForeColor = Color.Black;
            rdEateIn.Location = new Point(6, 30);
            rdEateIn.Name = "rdEateIn";
            rdEateIn.Size = new Size(63, 23);
            rdEateIn.TabIndex = 0;
            rdEateIn.TabStop = true;
            rdEateIn.Text = "Eat In";
            rdEateIn.UseVisualStyleBackColor = true;
            // 
            // grWhereToEate
            // 
            grWhereToEate.BackColor = Color.Transparent;
            grWhereToEate.Controls.Add(rdTakeOut);
            grWhereToEate.Controls.Add(rdEateIn);
            grWhereToEate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grWhereToEate.ForeColor = Color.Chocolate;
            grWhereToEate.Location = new Point(68, 420);
            grWhereToEate.Name = "grWhereToEate";
            grWhereToEate.Size = new Size(300, 74);
            grWhereToEate.TabIndex = 5;
            grWhereToEate.TabStop = false;
            grWhereToEate.Text = "🍽️ Where To Eat";
            // 
            // rdTakeOut
            // 
            rdTakeOut.AutoSize = true;
            rdTakeOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdTakeOut.ForeColor = Color.Black;
            rdTakeOut.Location = new Point(80, 30);
            rdTakeOut.Name = "rdTakeOut";
            rdTakeOut.Size = new Size(86, 23);
            rdTakeOut.TabIndex = 1;
            rdTakeOut.TabStop = true;
            rdTakeOut.Text = "Take Out";
            rdTakeOut.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(39, 174, 96);
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(79, 521);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(120, 50);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "\U0001f6d2 ORDER";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 57, 43);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(238, 521);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 50);
            btnReset.TabIndex = 0;
            btnReset.Text = "🔄 RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.FromArgb(220, 255, 255, 255);
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(lblTitleSummary);
            pnlSummary.Controls.Add(lblTitleSize);
            pnlSummary.Controls.Add(lbSizeBill);
            pnlSummary.Controls.Add(lblTitleCrust);
            pnlSummary.Controls.Add(lbCrustTypeBill);
            pnlSummary.Controls.Add(lblTitleWhere);
            pnlSummary.Controls.Add(lbWheretoEatBill);
            pnlSummary.Controls.Add(lblTitleToppings);
            pnlSummary.Controls.Add(lbToppingsBill);
            pnlSummary.Controls.Add(lblTitleTotal);
            pnlSummary.Controls.Add(lbPriceBill);
            pnlSummary.Location = new Point(877, 123);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(365, 536);
            pnlSummary.TabIndex = 6;
            pnlSummary.Visible = false;
            // 
            // lblTitleSummary
            // 
            lblTitleSummary.AutoSize = true;
            lblTitleSummary.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblTitleSummary.ForeColor = Color.Chocolate;
            lblTitleSummary.Location = new Point(60, 20);
            lblTitleSummary.Name = "lblTitleSummary";
            lblTitleSummary.Size = new Size(237, 32);
            lblTitleSummary.TabIndex = 0;
            lblTitleSummary.Text = "\U0001f9fe Order Summary";
            // 
            // lblTitleSize
            // 
            lblTitleSize.AutoSize = true;
            lblTitleSize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitleSize.Location = new Point(20, 90);
            lblTitleSize.Name = "lblTitleSize";
            lblTitleSize.Size = new Size(45, 21);
            lblTitleSize.TabIndex = 1;
            lblTitleSize.Text = "Size:";
            // 
            // lbSizeBill
            // 
            lbSizeBill.AutoSize = true;
            lbSizeBill.Font = new Font("Segoe UI", 12F);
            lbSizeBill.Location = new Point(140, 90);
            lbSizeBill.Name = "lbSizeBill";
            lbSizeBill.Size = new Size(54, 21);
            lbSizeBill.TabIndex = 11;
            lbSizeBill.Text = "Empty";
            // 
            // lblTitleCrust
            // 
            lblTitleCrust.AutoSize = true;
            lblTitleCrust.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitleCrust.Location = new Point(20, 140);
            lblTitleCrust.Name = "lblTitleCrust";
            lblTitleCrust.Size = new Size(93, 21);
            lblTitleCrust.TabIndex = 3;
            lblTitleCrust.Text = "Crust Type:";
            // 
            // lbCrustTypeBill
            // 
            lbCrustTypeBill.AutoSize = true;
            lbCrustTypeBill.Font = new Font("Segoe UI", 12F);
            lbCrustTypeBill.Location = new Point(140, 140);
            lbCrustTypeBill.Name = "lbCrustTypeBill";
            lbCrustTypeBill.Size = new Size(54, 21);
            lbCrustTypeBill.TabIndex = 12;
            lbCrustTypeBill.Text = "Empty";
            // 
            // lblTitleWhere
            // 
            lblTitleWhere.AutoSize = true;
            lblTitleWhere.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitleWhere.Location = new Point(20, 190);
            lblTitleWhere.Name = "lblTitleWhere";
            lblTitleWhere.Size = new Size(112, 21);
            lblTitleWhere.TabIndex = 5;
            lblTitleWhere.Text = "Where to Eat:";
            // 
            // lbWheretoEatBill
            // 
            lbWheretoEatBill.AutoSize = true;
            lbWheretoEatBill.Font = new Font("Segoe UI", 12F);
            lbWheretoEatBill.Location = new Point(140, 190);
            lbWheretoEatBill.Name = "lbWheretoEatBill";
            lbWheretoEatBill.Size = new Size(54, 21);
            lbWheretoEatBill.TabIndex = 14;
            lbWheretoEatBill.Text = "Empty";
            // 
            // lblTitleToppings
            // 
            lblTitleToppings.AutoSize = true;
            lblTitleToppings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitleToppings.Location = new Point(20, 240);
            lblTitleToppings.Name = "lblTitleToppings";
            lblTitleToppings.Size = new Size(84, 21);
            lblTitleToppings.TabIndex = 7;
            lblTitleToppings.Text = "Toppings:";
            // 
            // lbToppingsBill
            // 
            lbToppingsBill.AutoSize = true;
            lbToppingsBill.Font = new Font("Segoe UI", 11F);
            lbToppingsBill.ForeColor = Color.Black;
            lbToppingsBill.Location = new Point(60, 270);
            lbToppingsBill.Name = "lbToppingsBill";
            lbToppingsBill.Size = new Size(51, 20);
            lbToppingsBill.TabIndex = 13;
            lbToppingsBill.Text = "Empty";
            // 
            // lblTitleTotal
            // 
            lblTitleTotal.AutoSize = true;
            lblTitleTotal.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblTitleTotal.Location = new Point(20, 410);
            lblTitleTotal.Name = "lblTitleTotal";
            lblTitleTotal.Size = new Size(145, 25);
            lblTitleTotal.TabIndex = 9;
            lblTitleTotal.Text = "💵 Total Price:";
            // 
            // lbPriceBill
            // 
            lbPriceBill.AutoSize = true;
            lbPriceBill.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lbPriceBill.ForeColor = Color.Green;
            lbPriceBill.Location = new Point(100, 440);
            lbPriceBill.Name = "lbPriceBill";
            lbPriceBill.Size = new Size(153, 65);
            lbPriceBill.TabIndex = 15;
            lbPriceBill.Text = "$0.00";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.BackColor = Color.Transparent;
            lbPrice.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lbPrice.ForeColor = Color.Green;
            lbPrice.Location = new Point(149, 584);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(153, 65);
            lbPrice.TabIndex = 10;
            lbPrice.Text = "$0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1331, 731);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grWhereToEate);
            Controls.Add(grToppings);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(grSize);
            Controls.Add(TitleLable);
            Controls.Add(pnlSummary);
            Controls.Add(lbPrice);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Pizza Form";
            grSize.ResumeLayout(false);
            grSize.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grToppings.ResumeLayout(false);
            grToppings.PerformLayout();
            grWhereToEate.ResumeLayout(false);
            grWhereToEate.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLable;
        private GroupBox grSize;
        private Label label1;
        private RadioButton rdLarg;
        private RadioButton rdSmall;
        private RadioButton rdMedium;
        private GroupBox groupBox1;
        private RadioButton rdThinCrust;
        private RadioButton rdThickCrust;
        private GroupBox grToppings;
        private CheckBox chkMushrooms;
        private CheckBox chkExtraChees;
        private CheckBox chkGreenPeppers;
        private CheckBox chkOlives;
        private CheckBox chkOnion;
        private CheckBox chkTomatoes;
        private RadioButton rdEateIn;
        private GroupBox grWhereToEate;
        private RadioButton rdTakeOut;
        private Button btnOrder;
        private Button btnReset;

        private Panel pnlSummary;
        private Label lblTitleSummary;
        private Label lblTitleSize;
        private Label lblTitleCrust;
        private Label lblTitleWhere;
        private Label lblTitleToppings;
        private Label lblTitleTotal;
        private Label lbPrice;
        private Label lbSizeBill;
        private Label lbCrustTypeBill;
        private Label lbToppingsBill;
        private Label lbWheretoEatBill;
        private Label lbPriceBill;
    }
}