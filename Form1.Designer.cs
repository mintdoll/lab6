namespace MicrofinanceApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.groupBoxClients = new System.Windows.Forms.GroupBox();
            this.btnRefreshClients = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.labelClientPhone = new System.Windows.Forms.Label();
            this.txtClientFullName = new System.Windows.Forms.TextBox();
            this.labelClientFullName = new System.Windows.Forms.Label();
            this.tabManagers = new System.Windows.Forms.TabPage();
            this.dgvManagers = new System.Windows.Forms.DataGridView();
            this.groupBoxManagers = new System.Windows.Forms.GroupBox();
            this.btnRefreshManagers = new System.Windows.Forms.Button();
            this.btnDeleteManager = new System.Windows.Forms.Button();
            this.btnUpdateManager = new System.Windows.Forms.Button();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.txtManagerFullName = new System.Windows.Forms.TextBox();
            this.labelManagerFullName = new System.Windows.Forms.Label();
            this.tabLoans = new System.Windows.Forms.TabPage();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.groupBoxLoans = new System.Windows.Forms.GroupBox();
            this.btnRefreshLoans = new System.Windows.Forms.Button();
            this.btnDeleteLoan = new System.Windows.Forms.Button();
            this.btnUpdateLoan = new System.Windows.Forms.Button();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.cmbLoanManager = new System.Windows.Forms.ComboBox();
            this.labelLoanManager = new System.Windows.Forms.Label();
            this.cmbLoanClient = new System.Windows.Forms.ComboBox();
            this.labelLoanClient = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.labelLoanAmount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.groupBoxClients.SuspendLayout();
            this.tabManagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagers)).BeginInit();
            this.groupBoxManagers.SuspendLayout();
            this.tabLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.groupBoxLoans.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClients);
            this.tabControl1.Controls.Add(this.tabManagers);
            this.tabControl1.Controls.Add(this.tabLoans);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 760);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.dgvClients);
            this.tabClients.Controls.Add(this.groupBoxClients);
            this.tabClients.Location = new System.Drawing.Point(4, 29);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(1212, 727);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(18, 239);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 62;
            this.dgvClients.RowTemplate.Height = 28;
            this.dgvClients.Size = new System.Drawing.Size(1168, 468);
            this.dgvClients.TabIndex = 1;
            // 
            // groupBoxClients
            // 
            this.groupBoxClients.Controls.Add(this.btnRefreshClients);
            this.groupBoxClients.Controls.Add(this.btnDeleteClient);
            this.groupBoxClients.Controls.Add(this.btnUpdateClient);
            this.groupBoxClients.Controls.Add(this.btnAddClient);
            this.groupBoxClients.Controls.Add(this.txtClientPhone);
            this.groupBoxClients.Controls.Add(this.labelClientPhone);
            this.groupBoxClients.Controls.Add(this.txtClientFullName);
            this.groupBoxClients.Controls.Add(this.labelClientFullName);
            this.groupBoxClients.Location = new System.Drawing.Point(18, 18);
            this.groupBoxClients.Name = "groupBoxClients";
            this.groupBoxClients.Size = new System.Drawing.Size(1168, 205);
            this.groupBoxClients.TabIndex = 0;
            this.groupBoxClients.TabStop = false;
            this.groupBoxClients.Text = "Управление клиентами";
            // 
            // btnRefreshClients
            // 
            this.btnRefreshClients.Location = new System.Drawing.Point(874, 142);
            this.btnRefreshClients.Name = "btnRefreshClients";
            this.btnRefreshClients.Size = new System.Drawing.Size(248, 42);
            this.btnRefreshClients.TabIndex = 7;
            this.btnRefreshClients.Text = "Обновить";
            this.btnRefreshClients.UseVisualStyleBackColor = true;
            this.btnRefreshClients.Click += new System.EventHandler(this.btnRefreshClients_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(594, 142);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(248, 42);
            this.btnDeleteClient.TabIndex = 6;
            this.btnDeleteClient.Text = "Удалить";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(310, 142);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(248, 42);
            this.btnUpdateClient.TabIndex = 5;
            this.btnUpdateClient.Text = "Изменить";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(20, 142);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(248, 42);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Добавить";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(180, 84);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(942, 26);
            this.txtClientPhone.TabIndex = 3;
            // 
            // labelClientPhone
            // 
            this.labelClientPhone.AutoSize = true;
            this.labelClientPhone.Location = new System.Drawing.Point(20, 88);
            this.labelClientPhone.Name = "labelClientPhone";
            this.labelClientPhone.Size = new System.Drawing.Size(76, 20);
            this.labelClientPhone.TabIndex = 2;
            this.labelClientPhone.Text = "Телефон";
            // 
            // txtClientFullName
            // 
            this.txtClientFullName.Location = new System.Drawing.Point(180, 36);
            this.txtClientFullName.Name = "txtClientFullName";
            this.txtClientFullName.Size = new System.Drawing.Size(942, 26);
            this.txtClientFullName.TabIndex = 1;
            // 
            // labelClientFullName
            // 
            this.labelClientFullName.AutoSize = true;
            this.labelClientFullName.Location = new System.Drawing.Point(20, 40);
            this.labelClientFullName.Name = "labelClientFullName";
            this.labelClientFullName.Size = new System.Drawing.Size(127, 20);
            this.labelClientFullName.TabIndex = 0;
            this.labelClientFullName.Text = "ФИО клиента";
            // 
            // tabManagers
            // 
            this.tabManagers.Controls.Add(this.dgvManagers);
            this.tabManagers.Controls.Add(this.groupBoxManagers);
            this.tabManagers.Location = new System.Drawing.Point(4, 29);
            this.tabManagers.Name = "tabManagers";
            this.tabManagers.Padding = new System.Windows.Forms.Padding(3);
            this.tabManagers.Size = new System.Drawing.Size(1212, 727);
            this.tabManagers.TabIndex = 1;
            this.tabManagers.Text = "Менеджеры";
            this.tabManagers.UseVisualStyleBackColor = true;
            // 
            // dgvManagers
            // 
            this.dgvManagers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagers.Location = new System.Drawing.Point(18, 239);
            this.dgvManagers.Name = "dgvManagers";
            this.dgvManagers.RowHeadersWidth = 62;
            this.dgvManagers.RowTemplate.Height = 28;
            this.dgvManagers.Size = new System.Drawing.Size(1168, 468);
            this.dgvManagers.TabIndex = 1;
            // 
            // groupBoxManagers
            // 
            this.groupBoxManagers.Controls.Add(this.btnRefreshManagers);
            this.groupBoxManagers.Controls.Add(this.btnDeleteManager);
            this.groupBoxManagers.Controls.Add(this.btnUpdateManager);
            this.groupBoxManagers.Controls.Add(this.btnAddManager);
            this.groupBoxManagers.Controls.Add(this.txtDepartment);
            this.groupBoxManagers.Controls.Add(this.labelDepartment);
            this.groupBoxManagers.Controls.Add(this.txtManagerFullName);
            this.groupBoxManagers.Controls.Add(this.labelManagerFullName);
            this.groupBoxManagers.Location = new System.Drawing.Point(18, 18);
            this.groupBoxManagers.Name = "groupBoxManagers";
            this.groupBoxManagers.Size = new System.Drawing.Size(1168, 205);
            this.groupBoxManagers.TabIndex = 0;
            this.groupBoxManagers.TabStop = false;
            this.groupBoxManagers.Text = "Управление менеджерами";
            // 
            // btnRefreshManagers
            // 
            this.btnRefreshManagers.Location = new System.Drawing.Point(874, 142);
            this.btnRefreshManagers.Name = "btnRefreshManagers";
            this.btnRefreshManagers.Size = new System.Drawing.Size(248, 42);
            this.btnRefreshManagers.TabIndex = 7;
            this.btnRefreshManagers.Text = "Обновить";
            this.btnRefreshManagers.UseVisualStyleBackColor = true;
            this.btnRefreshManagers.Click += new System.EventHandler(this.btnRefreshManagers_Click);
            // 
            // btnDeleteManager
            // 
            this.btnDeleteManager.Location = new System.Drawing.Point(594, 142);
            this.btnDeleteManager.Name = "btnDeleteManager";
            this.btnDeleteManager.Size = new System.Drawing.Size(248, 42);
            this.btnDeleteManager.TabIndex = 6;
            this.btnDeleteManager.Text = "Удалить";
            this.btnDeleteManager.UseVisualStyleBackColor = true;
            this.btnDeleteManager.Click += new System.EventHandler(this.btnDeleteManager_Click);
            // 
            // btnUpdateManager
            // 
            this.btnUpdateManager.Location = new System.Drawing.Point(310, 142);
            this.btnUpdateManager.Name = "btnUpdateManager";
            this.btnUpdateManager.Size = new System.Drawing.Size(248, 42);
            this.btnUpdateManager.TabIndex = 5;
            this.btnUpdateManager.Text = "Изменить";
            this.btnUpdateManager.UseVisualStyleBackColor = true;
            this.btnUpdateManager.Click += new System.EventHandler(this.btnUpdateManager_Click);
            // 
            // btnAddManager
            // 
            this.btnAddManager.Location = new System.Drawing.Point(20, 142);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(248, 42);
            this.btnAddManager.TabIndex = 4;
            this.btnAddManager.Text = "Добавить";
            this.btnAddManager.UseVisualStyleBackColor = true;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(180, 84);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(942, 26);
            this.txtDepartment.TabIndex = 3;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(20, 88);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(57, 20);
            this.labelDepartment.TabIndex = 2;
            this.labelDepartment.Text = "Отдел";
            // 
            // txtManagerFullName
            // 
            this.txtManagerFullName.Location = new System.Drawing.Point(180, 36);
            this.txtManagerFullName.Name = "txtManagerFullName";
            this.txtManagerFullName.Size = new System.Drawing.Size(942, 26);
            this.txtManagerFullName.TabIndex = 1;
            // 
            // labelManagerFullName
            // 
            this.labelManagerFullName.AutoSize = true;
            this.labelManagerFullName.Location = new System.Drawing.Point(20, 40);
            this.labelManagerFullName.Name = "labelManagerFullName";
            this.labelManagerFullName.Size = new System.Drawing.Size(146, 20);
            this.labelManagerFullName.TabIndex = 0;
            this.labelManagerFullName.Text = "ФИО менеджера";
            // 
            // tabLoans
            // 
            this.tabLoans.Controls.Add(this.dgvLoans);
            this.tabLoans.Controls.Add(this.groupBoxLoans);
            this.tabLoans.Location = new System.Drawing.Point(4, 29);
            this.tabLoans.Name = "tabLoans";
            this.tabLoans.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoans.Size = new System.Drawing.Size(1212, 727);
            this.tabLoans.TabIndex = 2;
            this.tabLoans.Text = "Займы";
            this.tabLoans.UseVisualStyleBackColor = true;
            // 
            // dgvLoans
            // 
            this.dgvLoans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(18, 345);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowHeadersWidth = 62;
            this.dgvLoans.RowTemplate.Height = 28;
            this.dgvLoans.Size = new System.Drawing.Size(1168, 362);
            this.dgvLoans.TabIndex = 1;
            // 
            // groupBoxLoans
            // 
            this.groupBoxLoans.Controls.Add(this.btnRefreshLoans);
            this.groupBoxLoans.Controls.Add(this.btnDeleteLoan);
            this.groupBoxLoans.Controls.Add(this.btnUpdateLoan);
            this.groupBoxLoans.Controls.Add(this.btnAddLoan);
            this.groupBoxLoans.Controls.Add(this.cmbLoanManager);
            this.groupBoxLoans.Controls.Add(this.labelLoanManager);
            this.groupBoxLoans.Controls.Add(this.cmbLoanClient);
            this.groupBoxLoans.Controls.Add(this.labelLoanClient);
            this.groupBoxLoans.Controls.Add(this.txtComment);
            this.groupBoxLoans.Controls.Add(this.labelComment);
            this.groupBoxLoans.Controls.Add(this.dtpDueDate);
            this.groupBoxLoans.Controls.Add(this.labelDueDate);
            this.groupBoxLoans.Controls.Add(this.dtpIssueDate);
            this.groupBoxLoans.Controls.Add(this.labelIssueDate);
            this.groupBoxLoans.Controls.Add(this.txtInterestRate);
            this.groupBoxLoans.Controls.Add(this.labelInterestRate);
            this.groupBoxLoans.Controls.Add(this.txtLoanAmount);
            this.groupBoxLoans.Controls.Add(this.labelLoanAmount);
            this.groupBoxLoans.Location = new System.Drawing.Point(18, 18);
            this.groupBoxLoans.Name = "groupBoxLoans";
            this.groupBoxLoans.Size = new System.Drawing.Size(1168, 311);
            this.groupBoxLoans.TabIndex = 0;
            this.groupBoxLoans.TabStop = false;
            this.groupBoxLoans.Text = "Управление займами";
            // 
            // btnRefreshLoans
            // 
            this.btnRefreshLoans.Location = new System.Drawing.Point(874, 252);
            this.btnRefreshLoans.Name = "btnRefreshLoans";
            this.btnRefreshLoans.Size = new System.Drawing.Size(248, 42);
            this.btnRefreshLoans.TabIndex = 17;
            this.btnRefreshLoans.Text = "Обновить";
            this.btnRefreshLoans.UseVisualStyleBackColor = true;
            this.btnRefreshLoans.Click += new System.EventHandler(this.btnRefreshLoans_Click);
            // 
            // btnDeleteLoan
            // 
            this.btnDeleteLoan.Location = new System.Drawing.Point(594, 252);
            this.btnDeleteLoan.Name = "btnDeleteLoan";
            this.btnDeleteLoan.Size = new System.Drawing.Size(248, 42);
            this.btnDeleteLoan.TabIndex = 16;
            this.btnDeleteLoan.Text = "Удалить";
            this.btnDeleteLoan.UseVisualStyleBackColor = true;
            this.btnDeleteLoan.Click += new System.EventHandler(this.btnDeleteLoan_Click);
            // 
            // btnUpdateLoan
            // 
            this.btnUpdateLoan.Location = new System.Drawing.Point(310, 252);
            this.btnUpdateLoan.Name = "btnUpdateLoan";
            this.btnUpdateLoan.Size = new System.Drawing.Size(248, 42);
            this.btnUpdateLoan.TabIndex = 15;
            this.btnUpdateLoan.Text = "Изменить";
            this.btnUpdateLoan.UseVisualStyleBackColor = true;
            this.btnUpdateLoan.Click += new System.EventHandler(this.btnUpdateLoan_Click);
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(20, 252);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(248, 42);
            this.btnAddLoan.TabIndex = 14;
            this.btnAddLoan.Text = "Добавить";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // cmbLoanManager
            // 
            this.cmbLoanManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanManager.FormattingEnabled = true;
            this.cmbLoanManager.Location = new System.Drawing.Point(760, 201);
            this.cmbLoanManager.Name = "cmbLoanManager";
            this.cmbLoanManager.Size = new System.Drawing.Size(362, 28);
            this.cmbLoanManager.TabIndex = 13;
            // 
            // labelLoanManager
            // 
            this.labelLoanManager.AutoSize = true;
            this.labelLoanManager.Location = new System.Drawing.Point(638, 205);
            this.labelLoanManager.Name = "labelLoanManager";
            this.labelLoanManager.Size = new System.Drawing.Size(88, 20);
            this.labelLoanManager.TabIndex = 12;
            this.labelLoanManager.Text = "Менеджер";
            // 
            // cmbLoanClient
            // 
            this.cmbLoanClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanClient.FormattingEnabled = true;
            this.cmbLoanClient.Location = new System.Drawing.Point(180, 201);
            this.cmbLoanClient.Name = "cmbLoanClient";
            this.cmbLoanClient.Size = new System.Drawing.Size(362, 28);
            this.cmbLoanClient.TabIndex = 11;
            // 
            // labelLoanClient
            // 
            this.labelLoanClient.AutoSize = true;
            this.labelLoanClient.Location = new System.Drawing.Point(20, 205);
            this.labelLoanClient.Name = "labelLoanClient";
            this.labelLoanClient.Size = new System.Drawing.Size(66, 20);
            this.labelLoanClient.TabIndex = 10;
            this.labelLoanClient.Text = "Клиент";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(180, 161);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(942, 26);
            this.txtComment.TabIndex = 9;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(20, 165);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(105, 20);
            this.labelComment.TabIndex = 8;
            this.labelComment.Text = "Комментарий";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(760, 118);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(362, 26);
            this.dtpDueDate.TabIndex = 7;
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(638, 122);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(99, 20);
            this.labelDueDate.TabIndex = 6;
            this.labelDueDate.Text = "Погашение";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(180, 118);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(362, 26);
            this.dtpIssueDate.TabIndex = 5;
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Location = new System.Drawing.Point(20, 122);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(91, 20);
            this.labelIssueDate.TabIndex = 4;
            this.labelIssueDate.Text = "Дата выдачи";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(760, 62);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(362, 26);
            this.txtInterestRate.TabIndex = 3;
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Location = new System.Drawing.Point(638, 66);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(66, 20);
            this.labelInterestRate.TabIndex = 2;
            this.labelInterestRate.Text = "Процент";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(180, 62);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(362, 26);
            this.txtLoanAmount.TabIndex = 1;
            // 
            // labelLoanAmount
            // 
            this.labelLoanAmount.AutoSize = true;
            this.labelLoanAmount.Location = new System.Drawing.Point(20, 66);
            this.labelLoanAmount.Name = "labelLoanAmount";
            this.labelLoanAmount.Size = new System.Drawing.Size(58, 20);
            this.labelLoanAmount.TabIndex = 0;
            this.labelLoanAmount.Text = "Сумма";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 760);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Микрофинансовая организация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.groupBoxClients.ResumeLayout(false);
            this.groupBoxClients.PerformLayout();
            this.tabManagers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagers)).EndInit();
            this.groupBoxManagers.ResumeLayout(false);
            this.groupBoxManagers.PerformLayout();
            this.tabLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.groupBoxLoans.ResumeLayout(false);
            this.groupBoxLoans.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabManagers;
        private System.Windows.Forms.TabPage tabLoans;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.GroupBox groupBoxClients;
        private System.Windows.Forms.DataGridView dgvManagers;
        private System.Windows.Forms.GroupBox groupBoxManagers;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.GroupBox groupBoxLoans;
        private System.Windows.Forms.TextBox txtClientFullName;
        private System.Windows.Forms.Label labelClientFullName;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.Label labelClientPhone;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnRefreshClients;
        private System.Windows.Forms.TextBox txtManagerFullName;
        private System.Windows.Forms.Label labelManagerFullName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.Button btnUpdateManager;
        private System.Windows.Forms.Button btnDeleteManager;
        private System.Windows.Forms.Button btnRefreshManagers;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label labelLoanAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.ComboBox cmbLoanClient;
        private System.Windows.Forms.Label labelLoanClient;
        private System.Windows.Forms.ComboBox cmbLoanManager;
        private System.Windows.Forms.Label labelLoanManager;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.Button btnUpdateLoan;
        private System.Windows.Forms.Button btnDeleteLoan;
        private System.Windows.Forms.Button btnRefreshLoans;
    }
}


