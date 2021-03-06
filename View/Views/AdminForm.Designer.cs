﻿namespace View
{
    partial class AdminForm
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRemoveWorker = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAddWorkerSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.textBoxAddWorkerPassword = new System.Windows.Forms.TextBox();
            this.textBoxAddWorkerLogin = new System.Windows.Forms.TextBox();
            this.textBoxAddWorkerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAddCarLoadImage = new System.Windows.Forms.Button();
            this.textBoxAddCarImage = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButtonAddCarManualTransmition = new System.Windows.Forms.RadioButton();
            this.textBoxAddCarBrand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonAddCarAuthmaticTransmition = new System.Windows.Forms.RadioButton();
            this.numericUpDownAddCarYear = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAddCarFuelType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddCarModel = new System.Windows.Forms.TextBox();
            this.comboBoxAddCarcategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxDeleteCar = new System.Windows.Forms.ComboBox();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAddCategoryTarif = new System.Windows.Forms.TextBox();
            this.textBoxAddCategoryFine = new System.Windows.Forms.TextBox();
            this.textBoxAddCategoryName = new System.Windows.Forms.TextBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxDeleteCategories = new System.Windows.Forms.ListBox();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelAdminName = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialogAddCarLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.carRentalDBDataSet = new Presenrers.CarRentalDBDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new Presenrers.CarRentalDBDataSetTableAdapters.CarsTableAdapter();
            this.panelAdmin.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCarYear)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.panelAdmin.Controls.Add(this.groupBox7);
            this.panelAdmin.Controls.Add(this.groupBox6);
            this.panelAdmin.Controls.Add(this.groupBox4);
            this.panelAdmin.Controls.Add(this.groupBox3);
            this.panelAdmin.Controls.Add(this.groupBox1);
            this.panelAdmin.Controls.Add(this.groupBox2);
            this.panelAdmin.Location = new System.Drawing.Point(7, 28);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(843, 558);
            this.panelAdmin.TabIndex = 8;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listBox1);
            this.groupBox7.Controls.Add(this.buttonRemoveWorker);
            this.groupBox7.Location = new System.Drawing.Point(569, 211);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 172);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Remove worker";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonRemoveWorker
            // 
            this.buttonRemoveWorker.BackColor = System.Drawing.Color.LightCyan;
            this.buttonRemoveWorker.Location = new System.Drawing.Point(40, 124);
            this.buttonRemoveWorker.Name = "buttonRemoveWorker";
            this.buttonRemoveWorker.Size = new System.Drawing.Size(120, 23);
            this.buttonRemoveWorker.TabIndex = 1;
            this.buttonRemoveWorker.Text = "Remove";
            this.buttonRemoveWorker.UseVisualStyleBackColor = false;
            this.buttonRemoveWorker.Click += new System.EventHandler(this.buttonRemoveWorker_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxIsAdmin);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textBoxAddWorkerSurname);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.buttonAddWorker);
            this.groupBox6.Controls.Add(this.textBoxAddWorkerPassword);
            this.groupBox6.Controls.Add(this.textBoxAddWorkerLogin);
            this.groupBox6.Controls.Add(this.textBoxAddWorkerName);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(619, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 189);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add new worker";
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(92, 128);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsAdmin.TabIndex = 10;
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Is administrator:";
            // 
            // textBoxAddWorkerSurname
            // 
            this.textBoxAddWorkerSurname.Location = new System.Drawing.Point(68, 50);
            this.textBoxAddWorkerSurname.Name = "textBoxAddWorkerSurname";
            this.textBoxAddWorkerSurname.Size = new System.Drawing.Size(116, 20);
            this.textBoxAddWorkerSurname.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Surname:";
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddWorker.Location = new System.Drawing.Point(40, 155);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(120, 23);
            this.buttonAddWorker.TabIndex = 6;
            this.buttonAddWorker.Text = "Add";
            this.buttonAddWorker.UseVisualStyleBackColor = false;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // textBoxAddWorkerPassword
            // 
            this.textBoxAddWorkerPassword.Location = new System.Drawing.Point(68, 102);
            this.textBoxAddWorkerPassword.Name = "textBoxAddWorkerPassword";
            this.textBoxAddWorkerPassword.Size = new System.Drawing.Size(116, 20);
            this.textBoxAddWorkerPassword.TabIndex = 5;
            // 
            // textBoxAddWorkerLogin
            // 
            this.textBoxAddWorkerLogin.Location = new System.Drawing.Point(68, 76);
            this.textBoxAddWorkerLogin.Name = "textBoxAddWorkerLogin";
            this.textBoxAddWorkerLogin.Size = new System.Drawing.Size(116, 20);
            this.textBoxAddWorkerLogin.TabIndex = 4;
            // 
            // textBoxAddWorkerName
            // 
            this.textBoxAddWorkerName.Location = new System.Drawing.Point(68, 24);
            this.textBoxAddWorkerName.Name = "textBoxAddWorkerName";
            this.textBoxAddWorkerName.Size = new System.Drawing.Size(116, 20);
            this.textBoxAddWorkerName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonAddCarLoadImage);
            this.groupBox4.Controls.Add(this.textBoxAddCarImage);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.radioButtonAddCarManualTransmition);
            this.groupBox4.Controls.Add(this.textBoxAddCarBrand);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.radioButtonAddCarAuthmaticTransmition);
            this.groupBox4.Controls.Add(this.numericUpDownAddCarYear);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.buttonAddCar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.comboBoxAddCarFuelType);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxAddCarModel);
            this.groupBox4.Controls.Add(this.comboBoxAddCarcategory);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(309, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 334);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add new car";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // buttonAddCarLoadImage
            // 
            this.buttonAddCarLoadImage.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddCarLoadImage.Location = new System.Drawing.Point(109, 246);
            this.buttonAddCarLoadImage.Name = "buttonAddCarLoadImage";
            this.buttonAddCarLoadImage.Size = new System.Drawing.Size(85, 23);
            this.buttonAddCarLoadImage.TabIndex = 17;
            this.buttonAddCarLoadImage.Text = "Load Image...";
            this.buttonAddCarLoadImage.UseVisualStyleBackColor = false;
            this.buttonAddCarLoadImage.Click += new System.EventHandler(this.buttonAddCarLoadImage_Click);
            // 
            // textBoxAddCarImage
            // 
            this.textBoxAddCarImage.Location = new System.Drawing.Point(51, 218);
            this.textBoxAddCarImage.Name = "textBoxAddCarImage";
            this.textBoxAddCarImage.Size = new System.Drawing.Size(143, 20);
            this.textBoxAddCarImage.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Image:";
            // 
            // radioButtonAddCarManualTransmition
            // 
            this.radioButtonAddCarManualTransmition.AutoSize = true;
            this.radioButtonAddCarManualTransmition.Location = new System.Drawing.Point(82, 188);
            this.radioButtonAddCarManualTransmition.Name = "radioButtonAddCarManualTransmition";
            this.radioButtonAddCarManualTransmition.Size = new System.Drawing.Size(60, 17);
            this.radioButtonAddCarManualTransmition.TabIndex = 14;
            this.radioButtonAddCarManualTransmition.TabStop = true;
            this.radioButtonAddCarManualTransmition.Text = "Manual";
            this.radioButtonAddCarManualTransmition.UseVisualStyleBackColor = true;
            this.radioButtonAddCarManualTransmition.CheckedChanged += new System.EventHandler(this.radioButtonAddCarManualTransmition_CheckedChanged);
            // 
            // textBoxAddCarBrand
            // 
            this.textBoxAddCarBrand.Location = new System.Drawing.Point(73, 30);
            this.textBoxAddCarBrand.Name = "textBoxAddCarBrand";
            this.textBoxAddCarBrand.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddCarBrand.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Brand:";
            // 
            // radioButtonAddCarAuthmaticTransmition
            // 
            this.radioButtonAddCarAuthmaticTransmition.AutoSize = true;
            this.radioButtonAddCarAuthmaticTransmition.Checked = true;
            this.radioButtonAddCarAuthmaticTransmition.Location = new System.Drawing.Point(82, 165);
            this.radioButtonAddCarAuthmaticTransmition.Name = "radioButtonAddCarAuthmaticTransmition";
            this.radioButtonAddCarAuthmaticTransmition.Size = new System.Drawing.Size(78, 17);
            this.radioButtonAddCarAuthmaticTransmition.TabIndex = 13;
            this.radioButtonAddCarAuthmaticTransmition.TabStop = true;
            this.radioButtonAddCarAuthmaticTransmition.Text = "Authomatic";
            this.radioButtonAddCarAuthmaticTransmition.UseVisualStyleBackColor = true;
            this.radioButtonAddCarAuthmaticTransmition.CheckedChanged += new System.EventHandler(this.radioButtonAddCarAuthmaticTransmition_CheckedChanged);
            // 
            // numericUpDownAddCarYear
            // 
            this.numericUpDownAddCarYear.Location = new System.Drawing.Point(73, 108);
            this.numericUpDownAddCarYear.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numericUpDownAddCarYear.Minimum = new decimal(new int[] {
            1975,
            0,
            0,
            0});
            this.numericUpDownAddCarYear.Name = "numericUpDownAddCarYear";
            this.numericUpDownAddCarYear.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownAddCarYear.TabIndex = 9;
            this.numericUpDownAddCarYear.Value = new decimal(new int[] {
            1975,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Transmition:";
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddCar.Location = new System.Drawing.Point(39, 293);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(120, 23);
            this.buttonAddCar.TabIndex = 8;
            this.buttonAddCar.Text = "Add";
            this.buttonAddCar.UseVisualStyleBackColor = false;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fuel:";
            // 
            // comboBoxAddCarFuelType
            // 
            this.comboBoxAddCarFuelType.FormattingEnabled = true;
            this.comboBoxAddCarFuelType.Location = new System.Drawing.Point(73, 134);
            this.comboBoxAddCarFuelType.Name = "comboBoxAddCarFuelType";
            this.comboBoxAddCarFuelType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddCarFuelType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category:";
            // 
            // textBoxAddCarModel
            // 
            this.textBoxAddCarModel.Location = new System.Drawing.Point(73, 56);
            this.textBoxAddCarModel.Name = "textBoxAddCarModel";
            this.textBoxAddCarModel.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddCarModel.TabIndex = 2;
            // 
            // comboBoxAddCarcategory
            // 
            this.comboBoxAddCarcategory.FormattingEnabled = true;
            this.comboBoxAddCarcategory.Location = new System.Drawing.Point(73, 81);
            this.comboBoxAddCarcategory.Name = "comboBoxAddCarcategory";
            this.comboBoxAddCarcategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddCarcategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxDeleteCar);
            this.groupBox3.Controls.Add(this.buttonDeleteCar);
            this.groupBox3.Location = new System.Drawing.Point(309, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 116);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete a car";
            // 
            // comboBoxDeleteCar
            // 
            this.comboBoxDeleteCar.FormattingEnabled = true;
            this.comboBoxDeleteCar.Location = new System.Drawing.Point(9, 34);
            this.comboBoxDeleteCar.Name = "comboBoxDeleteCar";
            this.comboBoxDeleteCar.Size = new System.Drawing.Size(185, 21);
            this.comboBoxDeleteCar.TabIndex = 2;
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDeleteCar.Location = new System.Drawing.Point(39, 72);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(120, 23);
            this.buttonDeleteCar.TabIndex = 1;
            this.buttonDeleteCar.Text = "Delete";
            this.buttonDeleteCar.UseVisualStyleBackColor = false;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxAddCategoryTarif);
            this.groupBox1.Controls.Add(this.textBoxAddCategoryFine);
            this.groupBox1.Controls.Add(this.textBoxAddCategoryName);
            this.groupBox1.Controls.Add(this.buttonAddCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add category";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Tarif (BYR/day):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Fine (BYR/day):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Name:";
            // 
            // textBoxAddCategoryTarif
            // 
            this.textBoxAddCategoryTarif.Location = new System.Drawing.Point(113, 62);
            this.textBoxAddCategoryTarif.Name = "textBoxAddCategoryTarif";
            this.textBoxAddCategoryTarif.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCategoryTarif.TabIndex = 5;
            this.textBoxAddCategoryTarif.TextChanged += new System.EventHandler(this.textBoxAddCategoryTarif_TextChanged);
            // 
            // textBoxAddCategoryFine
            // 
            this.textBoxAddCategoryFine.Location = new System.Drawing.Point(113, 94);
            this.textBoxAddCategoryFine.Name = "textBoxAddCategoryFine";
            this.textBoxAddCategoryFine.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCategoryFine.TabIndex = 4;
            this.textBoxAddCategoryFine.TextChanged += new System.EventHandler(this.textBoxAddCategoryFine_TextChanged);
            // 
            // textBoxAddCategoryName
            // 
            this.textBoxAddCategoryName.Location = new System.Drawing.Point(113, 30);
            this.textBoxAddCategoryName.Name = "textBoxAddCategoryName";
            this.textBoxAddCategoryName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCategoryName.TabIndex = 3;
            this.textBoxAddCategoryName.TextChanged += new System.EventHandler(this.textBoxAddCategoryName_TextChanged);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddCategory.Location = new System.Drawing.Point(40, 166);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(120, 23);
            this.buttonAddCategory.TabIndex = 2;
            this.buttonAddCategory.Text = "Add new ";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxDeleteCategories);
            this.groupBox2.Controls.Add(this.buttonDeleteCategory);
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 210);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete category";
            // 
            // listBoxDeleteCategories
            // 
            this.listBoxDeleteCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxDeleteCategories.FormattingEnabled = true;
            this.listBoxDeleteCategories.Location = new System.Drawing.Point(18, 19);
            this.listBoxDeleteCategories.Name = "listBoxDeleteCategories";
            this.listBoxDeleteCategories.Size = new System.Drawing.Size(162, 121);
            this.listBoxDeleteCategories.TabIndex = 1;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDeleteCategory.Location = new System.Drawing.Point(40, 155);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(120, 23);
            this.buttonDeleteCategory.TabIndex = 0;
            this.buttonDeleteCategory.Text = "Delete";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelAdminName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelAdminName
            // 
            this.toolStripLabelAdminName.Name = "toolStripLabelAdminName";
            this.toolStripLabelAdminName.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabelAdminName.Text = "toolStripLabel1";
            // 
            // carRentalDBDataSet
            // 
            this.carRentalDBDataSet.DataSetName = "CarRentalDBDataSet";
            this.carRentalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carRentalDBDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(862, 584);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelAdmin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelAdmin.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCarYear)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonRemoveWorker;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxAddWorkerSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.TextBox textBoxAddWorkerPassword;
        private System.Windows.Forms.TextBox textBoxAddWorkerLogin;
        private System.Windows.Forms.TextBox textBoxAddWorkerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDownAddCarYear;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAddCarFuelType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddCarModel;
        private System.Windows.Forms.ComboBox comboBoxAddCarcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAddCategoryName;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxDeleteCategories;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.TextBox textBoxAddCarBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonAddCarManualTransmition;
        private System.Windows.Forms.RadioButton radioButtonAddCarAuthmaticTransmition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxAddCategoryTarif;
        private System.Windows.Forms.TextBox textBoxAddCategoryFine;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAdminName;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonAddCarLoadImage;
        private System.Windows.Forms.TextBox textBoxAddCarImage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialogAddCarLoadImage;
        private System.Windows.Forms.ComboBox comboBoxDeleteCar;
        private Presenrers.CarRentalDBDataSet carRentalDBDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Presenrers.CarRentalDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
    }
}