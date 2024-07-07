namespace HostelRecordSystem
{
    partial class FrmCustomers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.addCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.starHostelDataSet = new HostelRecordSystem.StarHostelDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clm1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addCustomerTableAdapter = new HostelRecordSystem.StarHostelDataSetTableAdapters.AddCustomerTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpExit = new System.Windows.Forms.DateTimePicker();
            this.dtpEntry = new System.Windows.Forms.DateTimePicker();
            this.mskTxtBoxSSN = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.TxtBoxMail = new System.Windows.Forms.TextBox();
            this.TxtBoxSurname = new System.Windows.Forms.TextBox();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSearchName = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starHostelDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCustomerBindingSource
            // 
            this.addCustomerBindingSource.DataMember = "AddCustomer";
            this.addCustomerBindingSource.DataSource = this.starHostelDataSet;
            // 
            // starHostelDataSet
            // 
            this.starHostelDataSet.DataSetName = "StarHostelDataSet";
            this.starHostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1530, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm1,
            this.clm2,
            this.clm3,
            this.clm4,
            this.clm5,
            this.clm6,
            this.clm7,
            this.clm8,
            this.clm9,
            this.clm10,
            this.clm11});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1514, 308);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // clm1
            // 
            this.clm1.Text = "ID";
            this.clm1.Width = 65;
            // 
            // clm2
            // 
            this.clm2.Text = "Name";
            this.clm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm2.Width = 106;
            // 
            // clm3
            // 
            this.clm3.Text = "Surname";
            this.clm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm3.Width = 115;
            // 
            // clm4
            // 
            this.clm4.Text = "Gender";
            this.clm4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm4.Width = 106;
            // 
            // clm5
            // 
            this.clm5.Text = "PhoneNumber";
            this.clm5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm5.Width = 173;
            // 
            // clm6
            // 
            this.clm6.Text = "Mail";
            this.clm6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm6.Width = 211;
            // 
            // clm7
            // 
            this.clm7.Text = "SSN";
            this.clm7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm7.Width = 142;
            // 
            // clm8
            // 
            this.clm8.Text = "RoomNumber";
            this.clm8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm8.Width = 153;
            // 
            // clm9
            // 
            this.clm9.Text = "Price";
            this.clm9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm9.Width = 116;
            // 
            // clm10
            // 
            this.clm10.Text = "DateOfEntry";
            this.clm10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm10.Width = 159;
            // 
            // clm11
            // 
            this.clm11.Text = "DateOfExit";
            this.clm11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm11.Width = 164;
            // 
            // addCustomerTableAdapter
            // 
            this.addCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(309, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(319, 33);
            this.comboBox1.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(187, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 29);
            this.label10.TabIndex = 40;
            this.label10.Text = "Gender:";
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxPrice.Location = new System.Drawing.Point(885, 89);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(326, 30);
            this.TxtBoxPrice.TabIndex = 39;
            this.TxtBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(780, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Price:";
            // 
            // dtpExit
            // 
            this.dtpExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpExit.Location = new System.Drawing.Point(885, 190);
            this.dtpExit.Name = "dtpExit";
            this.dtpExit.Size = new System.Drawing.Size(329, 30);
            this.dtpExit.TabIndex = 37;
            // 
            // dtpEntry
            // 
            this.dtpEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEntry.Location = new System.Drawing.Point(885, 139);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(329, 30);
            this.dtpEntry.TabIndex = 36;
            // 
            // mskTxtBoxSSN
            // 
            this.mskTxtBoxSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtBoxSSN.Location = new System.Drawing.Point(309, 281);
            this.mskTxtBoxSSN.Mask = "00000000000";
            this.mskTxtBoxSSN.Name = "mskTxtBoxSSN";
            this.mskTxtBoxSSN.Size = new System.Drawing.Size(319, 30);
            this.mskTxtBoxSSN.TabIndex = 35;
            this.mskTxtBoxSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskTxtBoxPhone
            // 
            this.mskTxtBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtBoxPhone.Location = new System.Drawing.Point(309, 189);
            this.mskTxtBoxPhone.Mask = "(999) 000-0000";
            this.mskTxtBoxPhone.Name = "mskTxtBoxPhone";
            this.mskTxtBoxPhone.Size = new System.Drawing.Size(319, 30);
            this.mskTxtBoxPhone.TabIndex = 34;
            this.mskTxtBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxRoomNumber
            // 
            this.TxtBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxRoomNumber.Location = new System.Drawing.Point(885, 35);
            this.TxtBoxRoomNumber.Name = "TxtBoxRoomNumber";
            this.TxtBoxRoomNumber.Size = new System.Drawing.Size(326, 30);
            this.TxtBoxRoomNumber.TabIndex = 33;
            this.TxtBoxRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxMail
            // 
            this.TxtBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxMail.Location = new System.Drawing.Point(309, 234);
            this.TxtBoxMail.Name = "TxtBoxMail";
            this.TxtBoxMail.Size = new System.Drawing.Size(319, 30);
            this.TxtBoxMail.TabIndex = 32;
            // 
            // TxtBoxSurname
            // 
            this.TxtBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxSurname.Location = new System.Drawing.Point(309, 87);
            this.TxtBoxSurname.Name = "TxtBoxSurname";
            this.TxtBoxSurname.Size = new System.Drawing.Size(319, 30);
            this.TxtBoxSurname.TabIndex = 31;
            this.TxtBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxName.Location = new System.Drawing.Point(309, 32);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(319, 30);
            this.TxtBoxName.TabIndex = 30;
            this.TxtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(703, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Date Of Exit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(687, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Date Of Entry:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(672, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Room Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(0, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Social Security Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(220, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(99, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(200, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(1279, 88);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(260, 40);
            this.BtnUpdate.TabIndex = 42;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Location = new System.Drawing.Point(1279, 224);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(260, 40);
            this.BtnSearch.TabIndex = 43;
            this.BtnSearch.Text = "SEARCH";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(1279, 157);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(260, 40);
            this.BtnDelete.TabIndex = 44;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(22, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 60);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1169, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 29);
            this.label11.TabIndex = 46;
            this.label11.Text = "Name:";
            // 
            // TxtSearchName
            // 
            this.TxtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearchName.Location = new System.Drawing.Point(1279, 363);
            this.TxtSearchName.Name = "TxtSearchName";
            this.TxtSearchName.Size = new System.Drawing.Size(260, 34);
            this.TxtSearchName.TabIndex = 47;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.DarkGray;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClear.Location = new System.Drawing.Point(1279, 292);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(260, 40);
            this.BtnClear.TabIndex = 48;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.DarkGray;
            this.BtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnShow.ForeColor = System.Drawing.Color.Black;
            this.BtnShow.Location = new System.Drawing.Point(1279, 21);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(260, 40);
            this.BtnShow.TabIndex = 49;
            this.BtnShow.Text = "SHOW";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1548, 771);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtSearchName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtBoxPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpExit);
            this.Controls.Add(this.dtpEntry);
            this.Controls.Add(this.mskTxtBoxSSN);
            this.Controls.Add(this.mskTxtBoxPhone);
            this.Controls.Add(this.TxtBoxRoomNumber);
            this.Controls.Add(this.TxtBoxMail);
            this.Controls.Add(this.TxtBoxSurname);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starHostelDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private StarHostelDataSet starHostelDataSet;
        private System.Windows.Forms.BindingSource addCustomerBindingSource;
        private StarHostelDataSetTableAdapters.AddCustomerTableAdapter addCustomerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpExit;
        private System.Windows.Forms.DateTimePicker dtpEntry;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxSSN;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxPhone;
        private System.Windows.Forms.TextBox TxtBoxRoomNumber;
        private System.Windows.Forms.TextBox TxtBoxMail;
        private System.Windows.Forms.TextBox TxtBoxSurname;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSearchName;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clm1;
        private System.Windows.Forms.ColumnHeader clm2;
        private System.Windows.Forms.ColumnHeader clm3;
        private System.Windows.Forms.ColumnHeader clm4;
        private System.Windows.Forms.ColumnHeader clm5;
        private System.Windows.Forms.ColumnHeader clm6;
        private System.Windows.Forms.ColumnHeader clm7;
        private System.Windows.Forms.ColumnHeader clm8;
        private System.Windows.Forms.ColumnHeader clm9;
        private System.Windows.Forms.ColumnHeader clm10;
        private System.Windows.Forms.ColumnHeader clm11;
        private System.Windows.Forms.Button BtnShow;
    }
}