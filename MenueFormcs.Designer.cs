namespace PizzaProject
{
    partial class frmMenueForm
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
            this.lblPhrase = new System.Windows.Forms.Label();
            this.grbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.grbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.grbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeAway = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.grbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtWhereToEat = new System.Windows.Forms.TextBox();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.txtCrustType = new System.Windows.Forms.TextBox();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.txtToppingsList = new System.Windows.Forms.TextBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSizeChange = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblResetOrder = new System.Windows.Forms.Label();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTakeOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.lblNumberOfPizza = new System.Windows.Forms.Label();
            this.grbPizzaSize.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbCrustType.SuspendLayout();
            this.grbWhereToEat.SuspendLayout();
            this.grbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.BackColor = System.Drawing.Color.Transparent;
            this.lblPhrase.Font = new System.Drawing.Font("Kristen ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.ForeColor = System.Drawing.Color.Coral;
            this.lblPhrase.Location = new System.Drawing.Point(311, 62);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(447, 65);
            this.lblPhrase.TabIndex = 4;
            this.lblPhrase.Text = "Make Your Pizza ";
            this.lblPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grbPizzaSize
            // 
            this.grbPizzaSize.Controls.Add(this.rbLarge);
            this.grbPizzaSize.Controls.Add(this.rbMeduim);
            this.grbPizzaSize.Controls.Add(this.rbSmall);
            this.grbPizzaSize.Location = new System.Drawing.Point(82, 209);
            this.grbPizzaSize.Name = "grbPizzaSize";
            this.grbPizzaSize.Size = new System.Drawing.Size(200, 158);
            this.grbPizzaSize.TabIndex = 0;
            this.grbPizzaSize.TabStop = false;
            this.grbPizzaSize.Text = "Pizza Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(20, 111);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 0;
            this.rbLarge.Tag = "8";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(20, 72);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(76, 20);
            this.rbMeduim.TabIndex = 3;
            this.rbMeduim.Tag = "4";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(20, 33);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 2;
            this.rbSmall.Tag = "2";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.chkGreenPeppers);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Controls.Add(this.chkOlives);
            this.grbToppings.Controls.Add(this.chkTomatos);
            this.grbToppings.Controls.Add(this.chkExtraCheese);
            this.grbToppings.Controls.Add(this.chkMushrooms);
            this.grbToppings.Controls.Add(this.chkAll);
            this.grbToppings.Location = new System.Drawing.Point(322, 209);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(343, 158);
            this.grbToppings.TabIndex = 1;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Enabled = false;
            this.chkGreenPeppers.Location = new System.Drawing.Point(155, 122);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPeppers.TabIndex = 10;
            this.chkGreenPeppers.TabStop = false;
            this.chkGreenPeppers.Tag = "2";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Enabled = false;
            this.chkOnion.Location = new System.Drawing.Point(155, 33);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 8;
            this.chkOnion.TabStop = false;
            this.chkOnion.Tag = "2";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Enabled = false;
            this.chkOlives.Location = new System.Drawing.Point(155, 79);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 9;
            this.chkOlives.TabStop = false;
            this.chkOlives.Tag = "2";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Enabled = false;
            this.chkTomatos.Location = new System.Drawing.Point(16, 122);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(83, 20);
            this.chkTomatos.TabIndex = 7;
            this.chkTomatos.TabStop = false;
            this.chkTomatos.Tag = "2";
            this.chkTomatos.Text = "Tomatos";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Enabled = false;
            this.chkExtraCheese.Location = new System.Drawing.Point(16, 34);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.chkExtraCheese.TabIndex = 5;
            this.chkExtraCheese.TabStop = false;
            this.chkExtraCheese.Tag = "2";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Enabled = false;
            this.chkMushrooms.Location = new System.Drawing.Point(16, 78);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkMushrooms.TabIndex = 6;
            this.chkMushrooms.TabStop = false;
            this.chkMushrooms.Tag = "2";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAll.Enabled = false;
            this.chkAll.Location = new System.Drawing.Point(284, 11);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(44, 20);
            this.chkAll.TabIndex = 11;
            this.chkAll.TabStop = false;
            this.chkAll.Tag = "12";
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // grbCrustType
            // 
            this.grbCrustType.Controls.Add(this.rbThick);
            this.grbCrustType.Controls.Add(this.rbThin);
            this.grbCrustType.Location = new System.Drawing.Point(82, 411);
            this.grbCrustType.Name = "grbCrustType";
            this.grbCrustType.Size = new System.Drawing.Size(200, 118);
            this.grbCrustType.TabIndex = 3;
            this.grbCrustType.TabStop = false;
            this.grbCrustType.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Enabled = false;
            this.rbThick.Location = new System.Drawing.Point(20, 82);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(94, 20);
            this.rbThick.TabIndex = 13;
            this.rbThick.Tag = "3";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Enabled = false;
            this.rbThin.Location = new System.Drawing.Point(20, 33);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(87, 20);
            this.rbThin.TabIndex = 12;
            this.rbThin.Tag = "1";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // grbWhereToEat
            // 
            this.grbWhereToEat.Controls.Add(this.rbTakeAway);
            this.grbWhereToEat.Controls.Add(this.rbEatIn);
            this.grbWhereToEat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbWhereToEat.Location = new System.Drawing.Point(322, 421);
            this.grbWhereToEat.Name = "grbWhereToEat";
            this.grbWhereToEat.Size = new System.Drawing.Size(285, 75);
            this.grbWhereToEat.TabIndex = 3;
            this.grbWhereToEat.TabStop = false;
            this.grbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeAway
            // 
            this.rbTakeAway.AutoSize = true;
            this.rbTakeAway.Enabled = false;
            this.rbTakeAway.Location = new System.Drawing.Point(136, 37);
            this.rbTakeAway.Name = "rbTakeAway";
            this.rbTakeAway.Size = new System.Drawing.Size(96, 20);
            this.rbTakeAway.TabIndex = 15;
            this.rbTakeAway.Tag = "0";
            this.rbTakeAway.Text = "Take Away";
            this.rbTakeAway.UseVisualStyleBackColor = true;
            this.rbTakeAway.CheckedChanged += new System.EventHandler(this.rbTakeAway_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Enabled = false;
            this.rbEatIn.Location = new System.Drawing.Point(6, 37);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 14;
            this.rbEatIn.Tag = "2";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // grbOrderSummary
            // 
            this.grbOrderSummary.Controls.Add(this.lblNumberOfPizza);
            this.grbOrderSummary.Controls.Add(this.label2);
            this.grbOrderSummary.Controls.Add(this.lblPrice);
            this.grbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.grbOrderSummary.Controls.Add(this.txtWhereToEat);
            this.grbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.grbOrderSummary.Controls.Add(this.txtCrustType);
            this.grbOrderSummary.Controls.Add(this.lblCrustType);
            this.grbOrderSummary.Controls.Add(this.txtToppingsList);
            this.grbOrderSummary.Controls.Add(this.lblToppings);
            this.grbOrderSummary.Controls.Add(this.lblSizeChange);
            this.grbOrderSummary.Controls.Add(this.lblSize);
            this.grbOrderSummary.Location = new System.Drawing.Point(687, 209);
            this.grbOrderSummary.Name = "grbOrderSummary";
            this.grbOrderSummary.Size = new System.Drawing.Size(308, 519);
            this.grbOrderSummary.TabIndex = 7;
            this.grbOrderSummary.TabStop = false;
            this.grbOrderSummary.Text = "Order Summary";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Lime;
            this.lblPrice.Location = new System.Drawing.Point(139, 387);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 71);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "0$";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(24, 403);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(107, 20);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // txtWhereToEat
            // 
            this.txtWhereToEat.BackColor = System.Drawing.Color.MistyRose;
            this.txtWhereToEat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhereToEat.Location = new System.Drawing.Point(178, 300);
            this.txtWhereToEat.Name = "txtWhereToEat";
            this.txtWhereToEat.ReadOnly = true;
            this.txtWhereToEat.Size = new System.Drawing.Size(107, 20);
            this.txtWhereToEat.TabIndex = 8;
            this.txtWhereToEat.TabStop = false;
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(24, 300);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(130, 20);
            this.lblWhereToEat.TabIndex = 7;
            this.lblWhereToEat.Text = "Where To Eat:";
            // 
            // txtCrustType
            // 
            this.txtCrustType.BackColor = System.Drawing.Color.MistyRose;
            this.txtCrustType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrustType.Location = new System.Drawing.Point(151, 249);
            this.txtCrustType.Name = "txtCrustType";
            this.txtCrustType.ReadOnly = true;
            this.txtCrustType.Size = new System.Drawing.Size(107, 20);
            this.txtCrustType.TabIndex = 6;
            this.txtCrustType.TabStop = false;
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(24, 248);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(107, 20);
            this.lblCrustType.TabIndex = 5;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // txtToppingsList
            // 
            this.txtToppingsList.BackColor = System.Drawing.Color.MistyRose;
            this.txtToppingsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToppingsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToppingsList.Location = new System.Drawing.Point(39, 153);
            this.txtToppingsList.Multiline = true;
            this.txtToppingsList.Name = "txtToppingsList";
            this.txtToppingsList.ReadOnly = true;
            this.txtToppingsList.Size = new System.Drawing.Size(235, 83);
            this.txtToppingsList.TabIndex = 4;
            this.txtToppingsList.TabStop = false;
            this.txtToppingsList.UseSystemPasswordChar = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(24, 110);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(91, 20);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblSizeChange
            // 
            this.lblSizeChange.AutoSize = true;
            this.lblSizeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeChange.Location = new System.Drawing.Point(115, 48);
            this.lblSizeChange.Name = "lblSizeChange";
            this.lblSizeChange.Size = new System.Drawing.Size(0, 20);
            this.lblSizeChange.TabIndex = 2;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(24, 48);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(52, 20);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size:";
            // 
            // lblResetOrder
            // 
            this.lblResetOrder.AutoSize = true;
            this.lblResetOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetOrder.Location = new System.Drawing.Point(498, 612);
            this.lblResetOrder.Name = "lblResetOrder";
            this.lblResetOrder.Size = new System.Drawing.Size(112, 20);
            this.lblResetOrder.TabIndex = 9;
            this.lblResetOrder.Text = "Reset Order";
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackgroundImage = global::PizzaProject.Properties.Resources.download__1_;
            this.btnTakeOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTakeOrder.Enabled = false;
            this.btnTakeOrder.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnTakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOrder.Location = new System.Drawing.Point(322, 648);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(53, 50);
            this.btnTakeOrder.TabIndex = 4;
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.BackgroundImage = global::PizzaProject.Properties.Resources.download;
            this.btnResetOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetOrder.Enabled = false;
            this.btnResetOrder.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnResetOrder.FlatAppearance.BorderSize = 0;
            this.btnResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetOrder.Location = new System.Drawing.Point(522, 648);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(53, 50);
            this.btnResetOrder.TabIndex = 5;
            this.btnResetOrder.UseVisualStyleBackColor = true;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PizzaProject.Properties.Resources._176730201;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(140, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.BackgroundImage = global::PizzaProject.Properties.Resources._8568977;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnExit.FlatAppearance.BorderSize = 6;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(30, 661);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 67);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTakeOrder
            // 
            this.lblTakeOrder.AutoSize = true;
            this.lblTakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakeOrder.Location = new System.Drawing.Point(298, 612);
            this.lblTakeOrder.Name = "lblTakeOrder";
            this.lblTakeOrder.Size = new System.Drawing.Size(103, 20);
            this.lblTakeOrder.TabIndex = 11;
            this.lblTakeOrder.Text = "Take Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number Of Pizza:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.MistyRose;
            this.numericUpDown1.Location = new System.Drawing.Point(264, 575);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Kristen ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Coral;
            this.label.Location = new System.Drawing.Point(78, 575);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(151, 24);
            this.label.TabIndex = 13;
            this.label.Text = "Pizza Number ";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberOfPizza
            // 
            this.lblNumberOfPizza.AutoSize = true;
            this.lblNumberOfPizza.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPizza.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfPizza.Location = new System.Drawing.Point(207, 344);
            this.lblNumberOfPizza.Name = "lblNumberOfPizza";
            this.lblNumberOfPizza.Size = new System.Drawing.Size(30, 35);
            this.lblNumberOfPizza.TabIndex = 12;
            this.lblNumberOfPizza.Text = "0";
            // 
            // frmMenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1007, 753);
            this.Controls.Add(this.label);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblTakeOrder);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.lblResetOrder);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.grbOrderSummary);
            this.Controls.Add(this.grbWhereToEat);
            this.Controls.Add(this.grbCrustType);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbPizzaSize);
            this.Controls.Add(this.lblPhrase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMenueForm";
            this.Text = "MenueForm";
            this.grbPizzaSize.ResumeLayout(false);
            this.grbPizzaSize.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbCrustType.ResumeLayout(false);
            this.grbCrustType.PerformLayout();
            this.grbWhereToEat.ResumeLayout(false);
            this.grbWhereToEat.PerformLayout();
            this.grbOrderSummary.ResumeLayout(false);
            this.grbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.GroupBox grbPizzaSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.GroupBox grbCrustType;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox grbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeAway;
        private System.Windows.Forms.GroupBox grbOrderSummary;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizeChange;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.TextBox txtToppingsList;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.TextBox txtCrustType;
        private System.Windows.Forms.TextBox txtWhereToEat;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Label lblResetOrder;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Label lblTakeOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblNumberOfPizza;
    }
}