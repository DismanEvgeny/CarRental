namespace CarRental
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.labelCategories = new System.Windows.Forms.Label();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.buttonGoToCategory = new System.Windows.Forms.Button();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.textBoxRentCarClientTelephone = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.numericUpDownRentCarDays = new System.Windows.Forms.NumericUpDown();
            this.textBoxRentCarClientSurname = new System.Windows.Forms.TextBox();
            this.textBoxRentCarClientName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRentCar = new System.Windows.Forms.Button();
            this.panelImages = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCarsInUse = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentCarDays)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategories.Location = new System.Drawing.Point(12, 40);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(100, 24);
            this.labelCategories.TabIndex = 4;
            this.labelCategories.Text = "Categories";
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 18;
            this.listBoxCategories.Items.AddRange(new object[] {
            "All"});
            this.listBoxCategories.Location = new System.Drawing.Point(12, 79);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(180, 216);
            this.listBoxCategories.TabIndex = 8;
            // 
            // buttonGoToCategory
            // 
            this.buttonGoToCategory.Location = new System.Drawing.Point(16, 342);
            this.buttonGoToCategory.Name = "buttonGoToCategory";
            this.buttonGoToCategory.Size = new System.Drawing.Size(100, 23);
            this.buttonGoToCategory.TabIndex = 10;
            this.buttonGoToCategory.Text = "Go to category";
            this.buttonGoToCategory.UseVisualStyleBackColor = true;
            this.buttonGoToCategory.Click += new System.EventHandler(this.buttonGoToCategory_Click);
            // 
            // panelCategories
            // 
            this.panelCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCategories.Controls.Add(this.textBoxRentCarClientTelephone);
            this.panelCategories.Controls.Add(this.label26);
            this.panelCategories.Controls.Add(this.numericUpDownRentCarDays);
            this.panelCategories.Controls.Add(this.textBoxRentCarClientSurname);
            this.panelCategories.Controls.Add(this.textBoxRentCarClientName);
            this.panelCategories.Controls.Add(this.label12);
            this.panelCategories.Controls.Add(this.label11);
            this.panelCategories.Controls.Add(this.label10);
            this.panelCategories.Controls.Add(this.label9);
            this.panelCategories.Controls.Add(this.buttonRentCar);
            this.panelCategories.Controls.Add(this.panelImages);
            this.panelCategories.Enabled = false;
            this.panelCategories.Location = new System.Drawing.Point(198, 72);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(823, 432);
            this.panelCategories.TabIndex = 11;
            this.panelCategories.Visible = false;
            // 
            // textBoxRentCarClientTelephone
            // 
            this.textBoxRentCarClientTelephone.Location = new System.Drawing.Point(327, 392);
            this.textBoxRentCarClientTelephone.Name = "textBoxRentCarClientTelephone";
            this.textBoxRentCarClientTelephone.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentCarClientTelephone.TabIndex = 10;
            this.textBoxRentCarClientTelephone.Text = "+375";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(198, 396);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "Your telephone number: ";
            // 
            // numericUpDownRentCarDays
            // 
            this.numericUpDownRentCarDays.Location = new System.Drawing.Point(725, 392);
            this.numericUpDownRentCarDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownRentCarDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRentCarDays.Name = "numericUpDownRentCarDays";
            this.numericUpDownRentCarDays.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownRentCarDays.TabIndex = 8;
            this.numericUpDownRentCarDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxRentCarClientSurname
            // 
            this.textBoxRentCarClientSurname.Location = new System.Drawing.Point(517, 392);
            this.textBoxRentCarClientSurname.Name = "textBoxRentCarClientSurname";
            this.textBoxRentCarClientSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentCarClientSurname.TabIndex = 7;
            // 
            // textBoxRentCarClientName
            // 
            this.textBoxRentCarClientName.Location = new System.Drawing.Point(92, 392);
            this.textBoxRentCarClientName.Name = "textBoxRentCarClientName";
            this.textBoxRentCarClientName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentCarClientName.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(635, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Number of days:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Your surname: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Your name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(341, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rent a car";
            // 
            // buttonRentCar
            // 
            this.buttonRentCar.Location = new System.Drawing.Point(743, 626);
            this.buttonRentCar.Name = "buttonRentCar";
            this.buttonRentCar.Size = new System.Drawing.Size(75, 23);
            this.buttonRentCar.TabIndex = 1;
            this.buttonRentCar.Text = "Send";
            this.buttonRentCar.UseVisualStyleBackColor = true;
            // 
            // panelImages
            // 
            this.panelImages.Location = new System.Drawing.Point(3, 41);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(815, 326);
            this.panelImages.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelCarsInUse});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Cars in use:";
            // 
            // toolStripStatusLabelCarsInUse
            // 
            this.toolStripStatusLabelCarsInUse.Name = "toolStripStatusLabelCarsInUse";
            this.toolStripStatusLabelCarsInUse.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelCarsInUse.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Check connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Result";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(241, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(102, 20);
            this.textBoxPassword.TabIndex = 17;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(69, 5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(102, 20);
            this.textBoxLogin.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(363, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(63, 23);
            this.buttonLogin.TabIndex = 21;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Location = new System.Drawing.Point(627, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 37);
            this.panel1.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1064, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelCategories);
            this.Controls.Add(this.buttonGoToCategory);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.labelCategories);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelCategories.ResumeLayout(false);
            this.panelCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentCarDays)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button buttonGoToCategory;
        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.NumericUpDown numericUpDownRentCarDays;
        private System.Windows.Forms.TextBox textBoxRentCarClientSurname;
        private System.Windows.Forms.TextBox textBoxRentCarClientName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRentCar;
        private System.Windows.Forms.TextBox textBoxRentCarClientTelephone;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCarsInUse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
    }
}

