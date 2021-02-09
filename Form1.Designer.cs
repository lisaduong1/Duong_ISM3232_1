namespace Duong_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.motelPictureBox = new System.Windows.Forms.PictureBox();
            this.motorwayMotelLabel = new System.Windows.Forms.Label();
            this.checkoutDateLabel = new System.Windows.Forms.Label();
            this.checkoutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberNightsLabel = new System.Windows.Forms.Label();
            this.numberNightsTextBox = new System.Windows.Forms.TextBox();
            this.nightlyRateLabel = new System.Windows.Forms.Label();
            this.miniBarLabel = new System.Windows.Forms.Label();
            this.miniBarTextBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.MiscChargesLabel = new System.Windows.Forms.Label();
            this.miscTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.roomChargesLabel = new System.Windows.Forms.Label();
            this.roomChargesOutput = new System.Windows.Forms.Label();
            this.additionalChargesLabel = new System.Windows.Forms.Label();
            this.additionalChargesOutput = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.guestInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.billingSummaryGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.motelPictureBox)).BeginInit();
            this.guestInfoGroupBox.SuspendLayout();
            this.roomInfoGroupBox.SuspendLayout();
            this.additionalChargesGroupBox.SuspendLayout();
            this.billingSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // motelPictureBox
            // 
            this.motelPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("motelPictureBox.BackgroundImage")));
            this.motelPictureBox.Location = new System.Drawing.Point(51, 12);
            this.motelPictureBox.Name = "motelPictureBox";
            this.motelPictureBox.Size = new System.Drawing.Size(302, 148);
            this.motelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.motelPictureBox.TabIndex = 0;
            this.motelPictureBox.TabStop = false;
            // 
            // motorwayMotelLabel
            // 
            this.motorwayMotelLabel.AutoSize = true;
            this.motorwayMotelLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.motorwayMotelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motorwayMotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorwayMotelLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.motorwayMotelLabel.Location = new System.Drawing.Point(398, 68);
            this.motorwayMotelLabel.Name = "motorwayMotelLabel";
            this.motorwayMotelLabel.Size = new System.Drawing.Size(291, 46);
            this.motorwayMotelLabel.TabIndex = 1;
            this.motorwayMotelLabel.Text = "Motorway Motel";
            // 
            // checkoutDateLabel
            // 
            this.checkoutDateLabel.AutoSize = true;
            this.checkoutDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDateLabel.Location = new System.Drawing.Point(105, 163);
            this.checkoutDateLabel.Name = "checkoutDateLabel";
            this.checkoutDateLabel.Size = new System.Drawing.Size(160, 25);
            this.checkoutDateLabel.TabIndex = 2;
            this.checkoutDateLabel.Text = "Check-Out Date:";
            this.checkoutDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkoutDatePicker
            // 
            this.checkoutDatePicker.CustomFormat = "";
            this.checkoutDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.checkoutDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkoutDatePicker.Location = new System.Drawing.Point(427, 158);
            this.checkoutDatePicker.Name = "checkoutDatePicker";
            this.checkoutDatePicker.Size = new System.Drawing.Size(173, 30);
            this.checkoutDatePicker.TabIndex = 3;
            this.checkoutDatePicker.Value = new System.DateTime(2020, 2, 17, 3, 49, 34, 0);
            this.checkoutDatePicker.ValueChanged += new System.EventHandler(this.checkoutDatePicker_ValueChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(426, 29);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(195, 30);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(104, 32);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(112, 25);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(426, 65);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(195, 30);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(104, 68);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberLabel.Location = new System.Drawing.Point(104, 32);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(143, 25);
            this.roomNumberLabel.TabIndex = 10;
            this.roomNumberLabel.Text = "Room Number:";
            this.roomNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberTextBox.Location = new System.Drawing.Point(426, 27);
            this.roomNumberTextBox.MaxLength = 3;
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(91, 30);
            this.roomNumberTextBox.TabIndex = 11;
            this.roomNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberNightsLabel
            // 
            this.numberNightsLabel.AutoSize = true;
            this.numberNightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberNightsLabel.Location = new System.Drawing.Point(104, 68);
            this.numberNightsLabel.Name = "numberNightsLabel";
            this.numberNightsLabel.Size = new System.Drawing.Size(129, 25);
            this.numberNightsLabel.TabIndex = 12;
            this.numberNightsLabel.Text = "No. of Nights:";
            this.numberNightsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberNightsTextBox
            // 
            this.numberNightsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberNightsTextBox.Location = new System.Drawing.Point(426, 63);
            this.numberNightsTextBox.MaxLength = 3;
            this.numberNightsTextBox.Name = "numberNightsTextBox";
            this.numberNightsTextBox.Size = new System.Drawing.Size(91, 30);
            this.numberNightsTextBox.TabIndex = 13;
            this.numberNightsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nightlyRateLabel
            // 
            this.nightlyRateLabel.AutoSize = true;
            this.nightlyRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightlyRateLabel.Location = new System.Drawing.Point(104, 104);
            this.nightlyRateLabel.Name = "nightlyRateLabel";
            this.nightlyRateLabel.Size = new System.Drawing.Size(122, 25);
            this.nightlyRateLabel.TabIndex = 14;
            this.nightlyRateLabel.Text = "Nightly Rate:";
            this.nightlyRateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // miniBarLabel
            // 
            this.miniBarLabel.AutoSize = true;
            this.miniBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniBarLabel.Location = new System.Drawing.Point(104, 40);
            this.miniBarLabel.Name = "miniBarLabel";
            this.miniBarLabel.Size = new System.Drawing.Size(169, 25);
            this.miniBarLabel.TabIndex = 17;
            this.miniBarLabel.Text = "Mini Bar Charges:";
            // 
            // miniBarTextBox
            // 
            this.miniBarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniBarTextBox.Location = new System.Drawing.Point(426, 37);
            this.miniBarTextBox.MaxLength = 10;
            this.miniBarTextBox.Name = "miniBarTextBox";
            this.miniBarTextBox.Size = new System.Drawing.Size(91, 30);
            this.miniBarTextBox.TabIndex = 18;
            this.miniBarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.miniBarTextBox.TextChanged += new System.EventHandler(this.miniBarTextBox_TextChanged);
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneLabel.Location = new System.Drawing.Point(104, 81);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(192, 25);
            this.telephoneLabel.TabIndex = 22;
            this.telephoneLabel.Text = "Telephone Charges:";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneTextBox.Location = new System.Drawing.Point(426, 78);
            this.telephoneTextBox.MaxLength = 10;
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(91, 30);
            this.telephoneTextBox.TabIndex = 23;
            this.telephoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MiscChargesLabel
            // 
            this.MiscChargesLabel.AutoSize = true;
            this.MiscChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiscChargesLabel.Location = new System.Drawing.Point(104, 117);
            this.MiscChargesLabel.Name = "MiscChargesLabel";
            this.MiscChargesLabel.Size = new System.Drawing.Size(144, 25);
            this.MiscChargesLabel.TabIndex = 24;
            this.MiscChargesLabel.Text = "Misc. Charges:";
            // 
            // miscTextBox
            // 
            this.miscTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscTextBox.Location = new System.Drawing.Point(426, 114);
            this.miscTextBox.MaxLength = 100;
            this.miscTextBox.Name = "miscTextBox";
            this.miscTextBox.Size = new System.Drawing.Size(91, 30);
            this.miscTextBox.TabIndex = 25;
            this.miscTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.Location = new System.Drawing.Point(426, 99);
            this.rateTextBox.MaxLength = 10;
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(91, 30);
            this.rateTextBox.TabIndex = 15;
            this.rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rateTextBox.TextChanged += new System.EventHandler(this.rateTextBox_TextChanged);
            // 
            // roomChargesLabel
            // 
            this.roomChargesLabel.AutoSize = true;
            this.roomChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomChargesLabel.Location = new System.Drawing.Point(104, 26);
            this.roomChargesLabel.Name = "roomChargesLabel";
            this.roomChargesLabel.Size = new System.Drawing.Size(149, 25);
            this.roomChargesLabel.TabIndex = 27;
            this.roomChargesLabel.Text = "Room Charges:";
            this.roomChargesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomChargesOutput
            // 
            this.roomChargesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomChargesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomChargesOutput.Location = new System.Drawing.Point(426, 26);
            this.roomChargesOutput.Name = "roomChargesOutput";
            this.roomChargesOutput.Size = new System.Drawing.Size(113, 25);
            this.roomChargesOutput.TabIndex = 28;
            this.roomChargesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // additionalChargesLabel
            // 
            this.additionalChargesLabel.AutoSize = true;
            this.additionalChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalChargesLabel.Location = new System.Drawing.Point(104, 61);
            this.additionalChargesLabel.Name = "additionalChargesLabel";
            this.additionalChargesLabel.Size = new System.Drawing.Size(184, 25);
            this.additionalChargesLabel.TabIndex = 29;
            this.additionalChargesLabel.Text = "Additional Charges:";
            this.additionalChargesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // additionalChargesOutput
            // 
            this.additionalChargesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.additionalChargesOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalChargesOutput.Location = new System.Drawing.Point(426, 61);
            this.additionalChargesOutput.Name = "additionalChargesOutput";
            this.additionalChargesOutput.Size = new System.Drawing.Size(113, 25);
            this.additionalChargesOutput.TabIndex = 30;
            this.additionalChargesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(104, 95);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(90, 25);
            this.subtotalLabel.TabIndex = 31;
            this.subtotalLabel.Text = "Subtotal:";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(426, 95);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(113, 25);
            this.subtotalOutput.TabIndex = 32;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.AutoSize = true;
            this.taxAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountLabel.Location = new System.Drawing.Point(104, 129);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(52, 25);
            this.taxAmountLabel.TabIndex = 33;
            this.taxAmountLabel.Text = "Tax:";
            this.taxAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taxOutput
            // 
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(426, 129);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(113, 25);
            this.taxOutput.TabIndex = 34;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taxOutput.Click += new System.EventHandler(this.taxOutput_Click);
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(426, 169);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(113, 25);
            this.totalOutput.TabIndex = 36;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(104, 169);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 25);
            this.totalLabel.TabIndex = 35;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(406, 157);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 4);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(51, 791);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(102, 39);
            this.totalButton.TabIndex = 37;
            this.totalButton.Text = "&Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(224, 791);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 39);
            this.clearButton.TabIndex = 38;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(416, 791);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(102, 39);
            this.helpButton.TabIndex = 39;
            this.helpButton.Text = "&Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(587, 791);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 39);
            this.exitButton.TabIndex = 40;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // guestInfoGroupBox
            // 
            this.guestInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.guestInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.guestInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.guestInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.guestInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestInfoGroupBox.Location = new System.Drawing.Point(1, 194);
            this.guestInfoGroupBox.Name = "guestInfoGroupBox";
            this.guestInfoGroupBox.Size = new System.Drawing.Size(742, 104);
            this.guestInfoGroupBox.TabIndex = 4;
            this.guestInfoGroupBox.TabStop = false;
            this.guestInfoGroupBox.Text = "Guest Information";
            // 
            // roomInfoGroupBox
            // 
            this.roomInfoGroupBox.Controls.Add(this.roomNumberLabel);
            this.roomInfoGroupBox.Controls.Add(this.roomNumberTextBox);
            this.roomInfoGroupBox.Controls.Add(this.numberNightsTextBox);
            this.roomInfoGroupBox.Controls.Add(this.rateTextBox);
            this.roomInfoGroupBox.Controls.Add(this.numberNightsLabel);
            this.roomInfoGroupBox.Controls.Add(this.nightlyRateLabel);
            this.roomInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomInfoGroupBox.Location = new System.Drawing.Point(1, 295);
            this.roomInfoGroupBox.Name = "roomInfoGroupBox";
            this.roomInfoGroupBox.Size = new System.Drawing.Size(742, 139);
            this.roomInfoGroupBox.TabIndex = 9;
            this.roomInfoGroupBox.TabStop = false;
            this.roomInfoGroupBox.Text = "Room Information";
            // 
            // additionalChargesGroupBox
            // 
            this.additionalChargesGroupBox.Controls.Add(this.miniBarLabel);
            this.additionalChargesGroupBox.Controls.Add(this.telephoneLabel);
            this.additionalChargesGroupBox.Controls.Add(this.miniBarTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.telephoneTextBox);
            this.additionalChargesGroupBox.Controls.Add(this.MiscChargesLabel);
            this.additionalChargesGroupBox.Controls.Add(this.miscTextBox);
            this.additionalChargesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalChargesGroupBox.Location = new System.Drawing.Point(1, 430);
            this.additionalChargesGroupBox.Name = "additionalChargesGroupBox";
            this.additionalChargesGroupBox.Size = new System.Drawing.Size(742, 156);
            this.additionalChargesGroupBox.TabIndex = 16;
            this.additionalChargesGroupBox.TabStop = false;
            this.additionalChargesGroupBox.Text = "Additional Charges";
            // 
            // billingSummaryGroupBox
            // 
            this.billingSummaryGroupBox.Controls.Add(this.roomChargesLabel);
            this.billingSummaryGroupBox.Controls.Add(this.roomChargesOutput);
            this.billingSummaryGroupBox.Controls.Add(this.additionalChargesLabel);
            this.billingSummaryGroupBox.Controls.Add(this.additionalChargesOutput);
            this.billingSummaryGroupBox.Controls.Add(this.subtotalLabel);
            this.billingSummaryGroupBox.Controls.Add(this.subtotalOutput);
            this.billingSummaryGroupBox.Controls.Add(this.taxAmountLabel);
            this.billingSummaryGroupBox.Controls.Add(this.taxOutput);
            this.billingSummaryGroupBox.Controls.Add(this.totalOutput);
            this.billingSummaryGroupBox.Controls.Add(this.totalLabel);
            this.billingSummaryGroupBox.Controls.Add(this.groupBox5);
            this.billingSummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingSummaryGroupBox.Location = new System.Drawing.Point(1, 580);
            this.billingSummaryGroupBox.Name = "billingSummaryGroupBox";
            this.billingSummaryGroupBox.Size = new System.Drawing.Size(742, 205);
            this.billingSummaryGroupBox.TabIndex = 26;
            this.billingSummaryGroupBox.TabStop = false;
            this.billingSummaryGroupBox.Text = "Billing Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 832);
            this.Controls.Add(this.billingSummaryGroupBox);
            this.Controls.Add(this.additionalChargesGroupBox);
            this.Controls.Add(this.roomInfoGroupBox);
            this.Controls.Add(this.guestInfoGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.checkoutDatePicker);
            this.Controls.Add(this.checkoutDateLabel);
            this.Controls.Add(this.motorwayMotelLabel);
            this.Controls.Add(this.motelPictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorway Motel Guest Check-Out";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.motelPictureBox)).EndInit();
            this.guestInfoGroupBox.ResumeLayout(false);
            this.guestInfoGroupBox.PerformLayout();
            this.roomInfoGroupBox.ResumeLayout(false);
            this.roomInfoGroupBox.PerformLayout();
            this.additionalChargesGroupBox.ResumeLayout(false);
            this.additionalChargesGroupBox.PerformLayout();
            this.billingSummaryGroupBox.ResumeLayout(false);
            this.billingSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox motelPictureBox;
        private System.Windows.Forms.Label motorwayMotelLabel;
        private System.Windows.Forms.Label checkoutDateLabel;
        private System.Windows.Forms.DateTimePicker checkoutDatePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Label numberNightsLabel;
        private System.Windows.Forms.TextBox numberNightsTextBox;
        private System.Windows.Forms.Label nightlyRateLabel;
        private System.Windows.Forms.Label miniBarLabel;
        private System.Windows.Forms.TextBox miniBarTextBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.Label MiscChargesLabel;
        private System.Windows.Forms.TextBox miscTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label roomChargesLabel;
        private System.Windows.Forms.Label roomChargesOutput;
        private System.Windows.Forms.Label additionalChargesLabel;
        private System.Windows.Forms.Label additionalChargesOutput;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox guestInfoGroupBox;
        private System.Windows.Forms.GroupBox roomInfoGroupBox;
        private System.Windows.Forms.GroupBox additionalChargesGroupBox;
        private System.Windows.Forms.GroupBox billingSummaryGroupBox;
    }
}

