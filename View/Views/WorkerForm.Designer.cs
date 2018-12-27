namespace View
{
    partial class WorkerForm
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
            this.panelWorker = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxRepairCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxComment_return = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeOfReturning_return = new System.Windows.Forms.DateTimePicker();
            this.textBoxReturnTotalSum = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.buttonReturnTotal = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.radioButtonReturnBad = new System.Windows.Forms.RadioButton();
            this.radioButtonReturnGood = new System.Windows.Forms.RadioButton();
            this.comboBoxReturnCar = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxAddClientNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.radioButtonAddClientFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonAddClientMale = new System.Windows.Forms.RadioButton();
            this.textBoxAddClientSurname = new System.Windows.Forms.TextBox();
            this.textBoxAddClientName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxLeaseCarIsReliable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxLeaseCarCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLeaseCarCalculate = new System.Windows.Forms.Button();
            this.buttonLeaseCarChooseClient = new System.Windows.Forms.Button();
            this.comboBoxLeaseCarClients = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeOfReturning_lease = new System.Windows.Forms.DateTimePicker();
            this.dateTimeOfLeasing = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLease = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxLeaseCarSum = new System.Windows.Forms.TextBox();
            this.textBoxLeaseCarTel = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxLeaseCarCar = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxLeaseClientName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxLeaseClientSurname = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelWorkerName = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCarsInUse = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelWorker.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorker
            // 
            this.panelWorker.BackColor = System.Drawing.Color.Transparent;
            this.panelWorker.Controls.Add(this.groupBox10);
            this.panelWorker.Controls.Add(this.groupBox8);
            this.panelWorker.Controls.Add(this.groupBox9);
            this.panelWorker.Location = new System.Drawing.Point(12, 12);
            this.panelWorker.Name = "panelWorker";
            this.panelWorker.Size = new System.Drawing.Size(933, 446);
            this.panelWorker.TabIndex = 13;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxRepairCost);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.textBoxComment_return);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.dateTimeOfReturning_return);
            this.groupBox10.Controls.Add(this.textBoxReturnTotalSum);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.buttonReturnTotal);
            this.groupBox10.Controls.Add(this.buttonReturn);
            this.groupBox10.Controls.Add(this.radioButtonReturnBad);
            this.groupBox10.Controls.Add(this.radioButtonReturnGood);
            this.groupBox10.Controls.Add(this.comboBoxReturnCar);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Location = new System.Drawing.Point(633, 16);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(270, 400);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Return car";
            // 
            // textBoxRepairCost
            // 
            this.textBoxRepairCost.Enabled = false;
            this.textBoxRepairCost.Location = new System.Drawing.Point(99, 99);
            this.textBoxRepairCost.Name = "textBoxRepairCost";
            this.textBoxRepairCost.Size = new System.Drawing.Size(162, 20);
            this.textBoxRepairCost.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Repair cost:";
            // 
            // textBoxComment_return
            // 
            this.textBoxComment_return.Location = new System.Drawing.Point(80, 199);
            this.textBoxComment_return.Multiline = true;
            this.textBoxComment_return.Name = "textBoxComment_return";
            this.textBoxComment_return.Size = new System.Drawing.Size(186, 77);
            this.textBoxComment_return.TabIndex = 31;
            this.textBoxComment_return.TextChanged += new System.EventHandler(this.textBoxComment_return_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Comment:";
            // 
            // dateTimeOfReturning_return
            // 
            this.dateTimeOfReturning_return.Location = new System.Drawing.Point(98, 54);
            this.dateTimeOfReturning_return.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimeOfReturning_return.MinDate = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.dateTimeOfReturning_return.Name = "dateTimeOfReturning_return";
            this.dateTimeOfReturning_return.Size = new System.Drawing.Size(163, 20);
            this.dateTimeOfReturning_return.TabIndex = 29;
            this.dateTimeOfReturning_return.Value = new System.DateTime(2018, 12, 2, 22, 35, 0, 0);
            // 
            // textBoxReturnTotalSum
            // 
            this.textBoxReturnTotalSum.Location = new System.Drawing.Point(103, 164);
            this.textBoxReturnTotalSum.Name = "textBoxReturnTotalSum";
            this.textBoxReturnTotalSum.ReadOnly = true;
            this.textBoxReturnTotalSum.Size = new System.Drawing.Size(136, 20);
            this.textBoxReturnTotalSum.TabIndex = 28;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 168);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 13);
            this.label27.TabIndex = 27;
            this.label27.Text = "Total sum:";
            // 
            // buttonReturnTotal
            // 
            this.buttonReturnTotal.BackColor = System.Drawing.Color.LightCyan;
            this.buttonReturnTotal.Location = new System.Drawing.Point(103, 135);
            this.buttonReturnTotal.Name = "buttonReturnTotal";
            this.buttonReturnTotal.Size = new System.Drawing.Size(111, 23);
            this.buttonReturnTotal.TabIndex = 26;
            this.buttonReturnTotal.Text = "Total";
            this.buttonReturnTotal.UseVisualStyleBackColor = false;
            this.buttonReturnTotal.Click += new System.EventHandler(this.buttonReturnTotal_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.LightCyan;
            this.buttonReturn.Enabled = false;
            this.buttonReturn.Location = new System.Drawing.Point(104, 294);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(111, 23);
            this.buttonReturn.TabIndex = 25;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // radioButtonReturnBad
            // 
            this.radioButtonReturnBad.AutoSize = true;
            this.radioButtonReturnBad.Location = new System.Drawing.Point(158, 80);
            this.radioButtonReturnBad.Name = "radioButtonReturnBad";
            this.radioButtonReturnBad.Size = new System.Drawing.Size(44, 17);
            this.radioButtonReturnBad.TabIndex = 24;
            this.radioButtonReturnBad.TabStop = true;
            this.radioButtonReturnBad.Text = "Bad";
            this.radioButtonReturnBad.UseVisualStyleBackColor = true;
            this.radioButtonReturnBad.CheckedChanged += new System.EventHandler(this.radioButtonReturnBad_CheckedChanged);
            // 
            // radioButtonReturnGood
            // 
            this.radioButtonReturnGood.AutoSize = true;
            this.radioButtonReturnGood.Checked = true;
            this.radioButtonReturnGood.Location = new System.Drawing.Point(99, 80);
            this.radioButtonReturnGood.Name = "radioButtonReturnGood";
            this.radioButtonReturnGood.Size = new System.Drawing.Size(51, 17);
            this.radioButtonReturnGood.TabIndex = 23;
            this.radioButtonReturnGood.TabStop = true;
            this.radioButtonReturnGood.Text = "Good";
            this.radioButtonReturnGood.UseVisualStyleBackColor = true;
            // 
            // comboBoxReturnCar
            // 
            this.comboBoxReturnCar.FormattingEnabled = true;
            this.comboBoxReturnCar.Location = new System.Drawing.Point(98, 27);
            this.comboBoxReturnCar.Name = "comboBoxReturnCar";
            this.comboBoxReturnCar.Size = new System.Drawing.Size(163, 21);
            this.comboBoxReturnCar.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 82);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Condition of car:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Date of returning:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Car:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxAddClientNumber);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.buttonAddClient);
            this.groupBox8.Controls.Add(this.radioButtonAddClientFemale);
            this.groupBox8.Controls.Add(this.radioButtonAddClientMale);
            this.groupBox8.Controls.Add(this.textBoxAddClientSurname);
            this.groupBox8.Controls.Add(this.textBoxAddClientName);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Location = new System.Drawing.Point(23, 14);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(225, 183);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Add new client";
            // 
            // textBoxAddClientNumber
            // 
            this.textBoxAddClientNumber.Location = new System.Drawing.Point(74, 69);
            this.textBoxAddClientNumber.Name = "textBoxAddClientNumber";
            this.textBoxAddClientNumber.Size = new System.Drawing.Size(145, 20);
            this.textBoxAddClientNumber.TabIndex = 11;
            this.textBoxAddClientNumber.Text = "+375";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tel. number:";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddClient.Location = new System.Drawing.Point(65, 139);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 9;
            this.buttonAddClient.Text = "Add";
            this.buttonAddClient.UseVisualStyleBackColor = false;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // radioButtonAddClientFemale
            // 
            this.radioButtonAddClientFemale.AutoSize = true;
            this.radioButtonAddClientFemale.Location = new System.Drawing.Point(129, 110);
            this.radioButtonAddClientFemale.Name = "radioButtonAddClientFemale";
            this.radioButtonAddClientFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonAddClientFemale.TabIndex = 8;
            this.radioButtonAddClientFemale.TabStop = true;
            this.radioButtonAddClientFemale.Text = "Female";
            this.radioButtonAddClientFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddClientMale
            // 
            this.radioButtonAddClientMale.AutoSize = true;
            this.radioButtonAddClientMale.Checked = true;
            this.radioButtonAddClientMale.Location = new System.Drawing.Point(74, 110);
            this.radioButtonAddClientMale.Name = "radioButtonAddClientMale";
            this.radioButtonAddClientMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonAddClientMale.TabIndex = 7;
            this.radioButtonAddClientMale.TabStop = true;
            this.radioButtonAddClientMale.Text = "Male";
            this.radioButtonAddClientMale.UseVisualStyleBackColor = true;
            // 
            // textBoxAddClientSurname
            // 
            this.textBoxAddClientSurname.Location = new System.Drawing.Point(74, 43);
            this.textBoxAddClientSurname.Name = "textBoxAddClientSurname";
            this.textBoxAddClientSurname.Size = new System.Drawing.Size(145, 20);
            this.textBoxAddClientSurname.TabIndex = 6;
            // 
            // textBoxAddClientName
            // 
            this.textBoxAddClientName.Location = new System.Drawing.Point(74, 17);
            this.textBoxAddClientName.Name = "textBoxAddClientName";
            this.textBoxAddClientName.Size = new System.Drawing.Size(145, 20);
            this.textBoxAddClientName.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Sex:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Surname:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Name: ";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxLeaseCarIsReliable);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.comboBoxLeaseCarCategory);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.buttonLeaseCarCalculate);
            this.groupBox9.Controls.Add(this.buttonLeaseCarChooseClient);
            this.groupBox9.Controls.Add(this.comboBoxLeaseCarClients);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.dateTimeOfReturning_lease);
            this.groupBox9.Controls.Add(this.dateTimeOfLeasing);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.buttonLease);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.textBoxLeaseCarSum);
            this.groupBox9.Controls.Add(this.textBoxLeaseCarTel);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.comboBoxLeaseCarCar);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.textBoxLeaseClientName);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.textBoxLeaseClientSurname);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Location = new System.Drawing.Point(297, 14);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(277, 419);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Lease a car";
            // 
            // textBoxLeaseCarIsReliable
            // 
            this.textBoxLeaseCarIsReliable.Location = new System.Drawing.Point(98, 94);
            this.textBoxLeaseCarIsReliable.Name = "textBoxLeaseCarIsReliable";
            this.textBoxLeaseCarIsReliable.ReadOnly = true;
            this.textBoxLeaseCarIsReliable.Size = new System.Drawing.Size(164, 20);
            this.textBoxLeaseCarIsReliable.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Is reliable?";
            // 
            // comboBoxLeaseCarCategory
            // 
            this.comboBoxLeaseCarCategory.FormattingEnabled = true;
            this.comboBoxLeaseCarCategory.Items.AddRange(new object[] {
            "All"});
            this.comboBoxLeaseCarCategory.Location = new System.Drawing.Point(98, 273);
            this.comboBoxLeaseCarCategory.Name = "comboBoxLeaseCarCategory";
            this.comboBoxLeaseCarCategory.Size = new System.Drawing.Size(164, 21);
            this.comboBoxLeaseCarCategory.TabIndex = 30;
            this.comboBoxLeaseCarCategory.SelectedValueChanged += new System.EventHandler(this.comboBoxLeaseCarCategory_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Category: ";
            // 
            // buttonLeaseCarCalculate
            // 
            this.buttonLeaseCarCalculate.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLeaseCarCalculate.Enabled = false;
            this.buttonLeaseCarCalculate.Location = new System.Drawing.Point(20, 382);
            this.buttonLeaseCarCalculate.Name = "buttonLeaseCarCalculate";
            this.buttonLeaseCarCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonLeaseCarCalculate.TabIndex = 28;
            this.buttonLeaseCarCalculate.Text = "Calculate";
            this.buttonLeaseCarCalculate.UseVisualStyleBackColor = false;
            this.buttonLeaseCarCalculate.Click += new System.EventHandler(this.buttonLeaseCarCalculate_Click);
            // 
            // buttonLeaseCarChooseClient
            // 
            this.buttonLeaseCarChooseClient.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLeaseCarChooseClient.Location = new System.Drawing.Point(98, 58);
            this.buttonLeaseCarChooseClient.Name = "buttonLeaseCarChooseClient";
            this.buttonLeaseCarChooseClient.Size = new System.Drawing.Size(164, 23);
            this.buttonLeaseCarChooseClient.TabIndex = 27;
            this.buttonLeaseCarChooseClient.Text = "Choose";
            this.buttonLeaseCarChooseClient.UseVisualStyleBackColor = false;
            this.buttonLeaseCarChooseClient.Click += new System.EventHandler(this.buttonLeaseCarChooseClient_Click);
            // 
            // comboBoxLeaseCarClients
            // 
            this.comboBoxLeaseCarClients.FormattingEnabled = true;
            this.comboBoxLeaseCarClients.Location = new System.Drawing.Point(98, 26);
            this.comboBoxLeaseCarClients.Name = "comboBoxLeaseCarClients";
            this.comboBoxLeaseCarClients.Size = new System.Drawing.Size(164, 21);
            this.comboBoxLeaseCarClients.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Client:";
            // 
            // dateTimeOfReturning_lease
            // 
            this.dateTimeOfReturning_lease.Location = new System.Drawing.Point(98, 239);
            this.dateTimeOfReturning_lease.MaxDate = new System.DateTime(2059, 12, 31, 0, 0, 0, 0);
            this.dateTimeOfReturning_lease.MinDate = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.dateTimeOfReturning_lease.Name = "dateTimeOfReturning_lease";
            this.dateTimeOfReturning_lease.Size = new System.Drawing.Size(170, 20);
            this.dateTimeOfReturning_lease.TabIndex = 24;
            this.dateTimeOfReturning_lease.Value = new System.DateTime(2018, 12, 2, 22, 30, 0, 0);
            // 
            // dateTimeOfLeasing
            // 
            this.dateTimeOfLeasing.Location = new System.Drawing.Point(98, 213);
            this.dateTimeOfLeasing.MaxDate = new System.DateTime(2059, 12, 31, 0, 0, 0, 0);
            this.dateTimeOfLeasing.MinDate = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.dateTimeOfLeasing.Name = "dateTimeOfLeasing";
            this.dateTimeOfLeasing.Size = new System.Drawing.Size(170, 20);
            this.dateTimeOfLeasing.TabIndex = 23;
            this.dateTimeOfLeasing.Value = new System.DateTime(2018, 12, 1, 22, 30, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date of returning:";
            // 
            // buttonLease
            // 
            this.buttonLease.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLease.Enabled = false;
            this.buttonLease.Location = new System.Drawing.Point(144, 382);
            this.buttonLease.Name = "buttonLease";
            this.buttonLease.Size = new System.Drawing.Size(75, 23);
            this.buttonLease.TabIndex = 21;
            this.buttonLease.Text = "Lease";
            this.buttonLease.UseVisualStyleBackColor = false;
            this.buttonLease.Click += new System.EventHandler(this.buttonLease_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 336);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Sum: ";
            // 
            // textBoxLeaseCarSum
            // 
            this.textBoxLeaseCarSum.Location = new System.Drawing.Point(98, 329);
            this.textBoxLeaseCarSum.Name = "textBoxLeaseCarSum";
            this.textBoxLeaseCarSum.ReadOnly = true;
            this.textBoxLeaseCarSum.Size = new System.Drawing.Size(164, 20);
            this.textBoxLeaseCarSum.TabIndex = 19;
            // 
            // textBoxLeaseCarTel
            // 
            this.textBoxLeaseCarTel.Location = new System.Drawing.Point(98, 180);
            this.textBoxLeaseCarTel.Name = "textBoxLeaseCarTel";
            this.textBoxLeaseCarTel.ReadOnly = true;
            this.textBoxLeaseCarTel.Size = new System.Drawing.Size(164, 20);
            this.textBoxLeaseCarTel.TabIndex = 18;
            this.textBoxLeaseCarTel.Text = "+375";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 187);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Tel. number:";
            // 
            // comboBoxLeaseCarCar
            // 
            this.comboBoxLeaseCarCar.FormattingEnabled = true;
            this.comboBoxLeaseCarCar.Location = new System.Drawing.Point(98, 302);
            this.comboBoxLeaseCarCar.Name = "comboBoxLeaseCarCar";
            this.comboBoxLeaseCarCar.Size = new System.Drawing.Size(164, 21);
            this.comboBoxLeaseCarCar.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 310);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Car: ";
            // 
            // textBoxLeaseClientName
            // 
            this.textBoxLeaseClientName.Location = new System.Drawing.Point(98, 128);
            this.textBoxLeaseClientName.Name = "textBoxLeaseClientName";
            this.textBoxLeaseClientName.ReadOnly = true;
            this.textBoxLeaseClientName.Size = new System.Drawing.Size(164, 20);
            this.textBoxLeaseClientName.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 213);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Date of leasing:";
            // 
            // textBoxLeaseClientSurname
            // 
            this.textBoxLeaseClientSurname.Location = new System.Drawing.Point(98, 154);
            this.textBoxLeaseClientSurname.Name = "textBoxLeaseClientSurname";
            this.textBoxLeaseClientSurname.ReadOnly = true;
            this.textBoxLeaseClientSurname.Size = new System.Drawing.Size(164, 20);
            this.textBoxLeaseClientSurname.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Name: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Surname: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelWorkerName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(961, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelWorkerName
            // 
            this.toolStripLabelWorkerName.Name = "toolStripLabelWorkerName";
            this.toolStripLabelWorkerName.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabelWorkerName.Text = "toolStripLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelCarsInUse});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(961, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Cars in use: ";
            // 
            // toolStripStatusLabelCarsInUse
            // 
            this.toolStripStatusLabelCarsInUse.Name = "toolStripStatusLabelCarsInUse";
            this.toolStripStatusLabelCarsInUse.Size = new System.Drawing.Size(0, 17);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(961, 470);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelWorker);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.panelWorker.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWorker;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxReturnTotalSum;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button buttonReturnTotal;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.RadioButton radioButtonReturnBad;
        private System.Windows.Forms.RadioButton radioButtonReturnGood;
        private System.Windows.Forms.ComboBox comboBoxReturnCar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.RadioButton radioButtonAddClientFemale;
        private System.Windows.Forms.RadioButton radioButtonAddClientMale;
        private System.Windows.Forms.TextBox textBoxAddClientSurname;
        private System.Windows.Forms.TextBox textBoxAddClientName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button buttonLease;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxLeaseCarSum;
        private System.Windows.Forms.TextBox textBoxLeaseCarTel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxLeaseCarCar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxLeaseClientName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxLeaseClientSurname;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimeOfReturning_return;
        private System.Windows.Forms.DateTimePicker dateTimeOfReturning_lease;
        private System.Windows.Forms.DateTimePicker dateTimeOfLeasing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComment_return;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelWorkerName;
        private System.Windows.Forms.TextBox textBoxAddClientNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLeaseCarClients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLeaseCarCalculate;
        private System.Windows.Forms.Button buttonLeaseCarChooseClient;
        private System.Windows.Forms.ComboBox comboBoxLeaseCarCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCarsInUse;
        private System.Windows.Forms.TextBox textBoxRepairCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLeaseCarIsReliable;
        private System.Windows.Forms.Label label7;
    }
}