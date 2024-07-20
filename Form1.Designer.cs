namespace Pizza_Project
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMashrooms = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPepeers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblCrustTypeValue = new System.Windows.Forms.Label();
            this.lblToppingsValue = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblWhereToEatValue = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSizeValue = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.gbPizzaSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(213, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(21, 41);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(21, 83);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(2);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(21, 125);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(2);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaSize.Controls.Add(this.rbLarge);
            this.gbPizzaSize.Controls.Add(this.rbMedium);
            this.gbPizzaSize.Controls.Add(this.rbSmall);
            this.gbPizzaSize.Location = new System.Drawing.Point(25, 72);
            this.gbPizzaSize.Margin = new System.Windows.Forms.Padding(2);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Padding = new System.Windows.Forms.Padding(2);
            this.gbPizzaSize.Size = new System.Drawing.Size(116, 168);
            this.gbPizzaSize.TabIndex = 4;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Size";
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(21, 33);
            this.rbThin.Margin = new System.Windows.Forms.Padding(2);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(72, 17);
            this.rbThin.TabIndex = 5;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "10";
            this.rbThin.Text = "Thin crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(21, 74);
            this.rbThick.Margin = new System.Windows.Forms.Padding(2);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(78, 17);
            this.rbThick.TabIndex = 6;
            this.rbThick.Tag = "20";
            this.rbThick.Text = "Thick crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Location = new System.Drawing.Point(25, 262);
            this.gbCrust.Margin = new System.Windows.Forms.Padding(2);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Padding = new System.Windows.Forms.Padding(2);
            this.gbCrust.Size = new System.Drawing.Size(112, 123);
            this.gbCrust.TabIndex = 7;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(16, 35);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(2);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(88, 17);
            this.chkExtraCheese.TabIndex = 8;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(153, 35);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 9;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMashrooms
            // 
            this.chkMashrooms.AutoSize = true;
            this.chkMashrooms.Location = new System.Drawing.Point(16, 75);
            this.chkMashrooms.Margin = new System.Windows.Forms.Padding(2);
            this.chkMashrooms.Name = "chkMashrooms";
            this.chkMashrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMashrooms.TabIndex = 10;
            this.chkMashrooms.Tag = "5";
            this.chkMashrooms.Text = "Mashrooms";
            this.chkMashrooms.UseVisualStyleBackColor = true;
            this.chkMashrooms.CheckedChanged += new System.EventHandler(this.chkMashrooms_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(153, 75);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(2);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 11;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPepeers
            // 
            this.chkGreenPepeers.AutoSize = true;
            this.chkGreenPepeers.Location = new System.Drawing.Point(153, 115);
            this.chkGreenPepeers.Margin = new System.Windows.Forms.Padding(2);
            this.chkGreenPepeers.Name = "chkGreenPepeers";
            this.chkGreenPepeers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPepeers.TabIndex = 12;
            this.chkGreenPepeers.Tag = "tyujtu";
            this.chkGreenPepeers.Text = "Green Pepeers";
            this.chkGreenPepeers.UseVisualStyleBackColor = true;
            this.chkGreenPepeers.CheckedChanged += new System.EventHandler(this.chkGreenPepeers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(16, 115);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(2);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkTomatoes.TabIndex = 13;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkGreenPepeers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMashrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.ForeColor = System.Drawing.Color.Gold;
            this.gbToppings.Location = new System.Drawing.Point(250, 93);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(2);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(2);
            this.gbToppings.Size = new System.Drawing.Size(287, 157);
            this.gbToppings.TabIndex = 14;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(250, 262);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(2);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(2);
            this.gbWhereToEat.Size = new System.Drawing.Size(201, 81);
            this.gbWhereToEat.TabIndex = 17;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(110, 33);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(2);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rbTakeOut.TabIndex = 18;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(30, 33);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(2);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(53, 17);
            this.rbEatIn.TabIndex = 17;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderPizza.Location = new System.Drawing.Point(268, 380);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(101, 24);
            this.btnOrderPizza.TabIndex = 18;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(418, 380);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(101, 24);
            this.btnResetForm.TabIndex = 19;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummary.Controls.Add(this.lblCrustTypeValue);
            this.gbOrderSummary.Controls.Add(this.lblToppingsValue);
            this.gbOrderSummary.Controls.Add(this.lblTotalPriceValue);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEatValue);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblSizeValue);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.Color.Gold;
            this.gbOrderSummary.Location = new System.Drawing.Point(620, 51);
            this.gbOrderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Padding = new System.Windows.Forms.Padding(2);
            this.gbOrderSummary.Size = new System.Drawing.Size(256, 353);
            this.gbOrderSummary.TabIndex = 20;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblCrustTypeValue
            // 
            this.lblCrustTypeValue.AutoSize = true;
            this.lblCrustTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustTypeValue.Location = new System.Drawing.Point(38, 183);
            this.lblCrustTypeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrustTypeValue.Name = "lblCrustTypeValue";
            this.lblCrustTypeValue.Size = new System.Drawing.Size(71, 17);
            this.lblCrustTypeValue.TabIndex = 9;
            this.lblCrustTypeValue.Text = "Thin crust";
            // 
            // lblToppingsValue
            // 
            this.lblToppingsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsValue.Location = new System.Drawing.Point(21, 104);
            this.lblToppingsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToppingsValue.Name = "lblToppingsValue";
            this.lblToppingsValue.Size = new System.Drawing.Size(219, 51);
            this.lblToppingsValue.TabIndex = 8;
            this.lblToppingsValue.Text = "No Toppings";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(88, 309);
            this.lblTotalPriceValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(80, 25);
            this.lblTotalPriceValue.TabIndex = 7;
            this.lblTotalPriceValue.Text = "label9";
            // 
            // lblWhereToEatValue
            // 
            this.lblWhereToEatValue.AutoSize = true;
            this.lblWhereToEatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEatValue.Location = new System.Drawing.Point(46, 255);
            this.lblWhereToEatValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhereToEatValue.Name = "lblWhereToEatValue";
            this.lblWhereToEatValue.Size = new System.Drawing.Size(44, 17);
            this.lblWhereToEatValue.TabIndex = 6;
            this.lblWhereToEatValue.Text = "Eat In";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(20, 77);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(75, 17);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "toppings:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(20, 155);
            this.lblCrustType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(92, 17);
            this.lblCrustType.TabIndex = 4;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(20, 219);
            this.lblWhereToEat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(113, 17);
            this.lblWhereToEat.TabIndex = 3;
            this.lblWhereToEat.Text = "Where To Eat:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 284);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(92, 17);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblSizeValue
            // 
            this.lblSizeValue.AutoSize = true;
            this.lblSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeValue.ForeColor = System.Drawing.Color.Gold;
            this.lblSizeValue.Location = new System.Drawing.Point(56, 45);
            this.lblSizeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSizeValue.Name = "lblSizeValue";
            this.lblSizeValue.Size = new System.Drawing.Size(42, 17);
            this.lblSizeValue.TabIndex = 1;
            this.lblSizeValue.Text = "Small";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Gold;
            this.lblSize.Location = new System.Drawing.Point(20, 45);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 17);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size:";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbPizzaSize);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.Shown += new System.EventHandler(this.frmPizzaOrder_Shown);
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMashrooms;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPepeers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblCrustTypeValue;
        private System.Windows.Forms.Label lblToppingsValue;
        private System.Windows.Forms.Label lblWhereToEatValue;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSizeValue;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTotalPriceValue;
    }
}

