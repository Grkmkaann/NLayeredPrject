namespace FormUI
{
    partial class OperationsUI
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
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbxDepartmantName = new System.Windows.Forms.ComboBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.cbxTitleName = new System.Windows.Forms.ComboBox();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.tbxMobileHomeNumer = new System.Windows.Forms.TextBox();
            this.lblHomePhoneNumber = new System.Windows.Forms.Label();
            this.tbxMobilePhoneNumer = new System.Windows.Forms.TextBox();
            this.lblMobilePhoneNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDepartmantName = new System.Windows.Forms.Label();
            this.dtpStartDateOfWork = new System.Windows.Forms.DateTimePicker();
            this.lblStartDWork = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.dtpDismissDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.lblDismissDate = new System.Windows.Forms.Label();
            this.tbxEmailAdressUpdate = new System.Windows.Forms.TextBox();
            this.lblEmailAdressUpdate = new System.Windows.Forms.Label();
            this.cbxDepartmantUpdate = new System.Windows.Forms.ComboBox();
            this.cbxGenderUpdate = new System.Windows.Forms.ComboBox();
            this.cbxTitleNameUpdate = new System.Windows.Forms.ComboBox();
            this.lblTitleNameUpdate = new System.Windows.Forms.Label();
            this.tbxHomePhoneNumberUpdate = new System.Windows.Forms.TextBox();
            this.lblHomePhoneNumberUpdate = new System.Windows.Forms.Label();
            this.tbxMobilePhoneNumberUpdate = new System.Windows.Forms.TextBox();
            this.lblMobilePhoneUpdate = new System.Windows.Forms.Label();
            this.lblGenderUpdate = new System.Windows.Forms.Label();
            this.lblDepartmantNameUpdate = new System.Windows.Forms.Label();
            this.dtpStartDateOfWorkUpdate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDateOfWorkUpdate = new System.Windows.Forms.Label();
            this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwList
            // 
            this.dgwList.AllowUserToAddRows = false;
            this.dgwList.AllowUserToDeleteRows = false;
            this.dgwList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(12, 34);
            this.dgwList.Name = "dgwList";
            this.dgwList.Size = new System.Drawing.Size(1393, 361);
            this.dgwList.TabIndex = 0;
            this.dgwList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwList_CellClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxEmail);
            this.gbxAdd.Controls.Add(this.lblEmail);
            this.gbxAdd.Controls.Add(this.cbxDepartmantName);
            this.gbxAdd.Controls.Add(this.cbxGender);
            this.gbxAdd.Controls.Add(this.cbxTitleName);
            this.gbxAdd.Controls.Add(this.lblTitleName);
            this.gbxAdd.Controls.Add(this.tbxMobileHomeNumer);
            this.gbxAdd.Controls.Add(this.lblHomePhoneNumber);
            this.gbxAdd.Controls.Add(this.tbxMobilePhoneNumer);
            this.gbxAdd.Controls.Add(this.lblMobilePhoneNumber);
            this.gbxAdd.Controls.Add(this.lblGender);
            this.gbxAdd.Controls.Add(this.lblDepartmantName);
            this.gbxAdd.Controls.Add(this.dtpStartDateOfWork);
            this.gbxAdd.Controls.Add(this.lblStartDWork);
            this.gbxAdd.Controls.Add(this.tbxSurname);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 414);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(395, 291);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add New";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(124, 238);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(147, 20);
            this.tbxEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 241);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email Adress";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxDepartmantName
            // 
            this.cbxDepartmantName.FormattingEnabled = true;
            this.cbxDepartmantName.Location = new System.Drawing.Point(124, 104);
            this.cbxDepartmantName.Name = "cbxDepartmantName";
            this.cbxDepartmantName.Size = new System.Drawing.Size(147, 21);
            this.cbxDepartmantName.TabIndex = 4;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxGender.Location = new System.Drawing.Point(124, 131);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(147, 21);
            this.cbxGender.TabIndex = 5;
            // 
            // cbxTitleName
            // 
            this.cbxTitleName.FormattingEnabled = true;
            this.cbxTitleName.Location = new System.Drawing.Point(124, 211);
            this.cbxTitleName.Name = "cbxTitleName";
            this.cbxTitleName.Size = new System.Drawing.Size(147, 21);
            this.cbxTitleName.TabIndex = 8;
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(6, 214);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(58, 13);
            this.lblTitleName.TabIndex = 18;
            this.lblTitleName.Text = "Title Name";
            this.lblTitleName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxMobileHomeNumer
            // 
            this.tbxMobileHomeNumer.Location = new System.Drawing.Point(124, 185);
            this.tbxMobileHomeNumer.Name = "tbxMobileHomeNumer";
            this.tbxMobileHomeNumer.Size = new System.Drawing.Size(147, 20);
            this.tbxMobileHomeNumer.TabIndex = 7;
            // 
            // lblHomePhoneNumber
            // 
            this.lblHomePhoneNumber.AutoSize = true;
            this.lblHomePhoneNumber.Location = new System.Drawing.Point(6, 188);
            this.lblHomePhoneNumber.Name = "lblHomePhoneNumber";
            this.lblHomePhoneNumber.Size = new System.Drawing.Size(109, 13);
            this.lblHomePhoneNumber.TabIndex = 14;
            this.lblHomePhoneNumber.Text = "Home Phone Number";
            this.lblHomePhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxMobilePhoneNumer
            // 
            this.tbxMobilePhoneNumer.Location = new System.Drawing.Point(124, 159);
            this.tbxMobilePhoneNumer.Name = "tbxMobilePhoneNumer";
            this.tbxMobilePhoneNumer.Size = new System.Drawing.Size(147, 20);
            this.tbxMobilePhoneNumer.TabIndex = 6;
            // 
            // lblMobilePhoneNumber
            // 
            this.lblMobilePhoneNumber.AutoSize = true;
            this.lblMobilePhoneNumber.Location = new System.Drawing.Point(6, 162);
            this.lblMobilePhoneNumber.Name = "lblMobilePhoneNumber";
            this.lblMobilePhoneNumber.Size = new System.Drawing.Size(112, 13);
            this.lblMobilePhoneNumber.TabIndex = 12;
            this.lblMobilePhoneNumber.Text = "Mobile Phone Number";
            this.lblMobilePhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 134);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDepartmantName
            // 
            this.lblDepartmantName.AutoSize = true;
            this.lblDepartmantName.Location = new System.Drawing.Point(6, 107);
            this.lblDepartmantName.Name = "lblDepartmantName";
            this.lblDepartmantName.Size = new System.Drawing.Size(93, 13);
            this.lblDepartmantName.TabIndex = 8;
            this.lblDepartmantName.Text = "Departmant Name";
            this.lblDepartmantName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpStartDateOfWork
            // 
            this.dtpStartDateOfWork.Location = new System.Drawing.Point(124, 78);
            this.dtpStartDateOfWork.Name = "dtpStartDateOfWork";
            this.dtpStartDateOfWork.Size = new System.Drawing.Size(174, 20);
            this.dtpStartDateOfWork.TabIndex = 3;
            // 
            // lblStartDWork
            // 
            this.lblStartDWork.AutoSize = true;
            this.lblStartDWork.Location = new System.Drawing.Point(6, 81);
            this.lblStartDWork.Name = "lblStartDWork";
            this.lblStartDWork.Size = new System.Drawing.Size(98, 13);
            this.lblStartDWork.TabIndex = 5;
            this.lblStartDWork.Text = "Start Date Of Work";
            this.lblStartDWork.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(124, 52);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(147, 20);
            this.tbxSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 55);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(124, 26);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(147, 20);
            this.tbxName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(314, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.dtpDismissDateUpdate);
            this.gbxUpdate.Controls.Add(this.lblDismissDate);
            this.gbxUpdate.Controls.Add(this.tbxEmailAdressUpdate);
            this.gbxUpdate.Controls.Add(this.lblEmailAdressUpdate);
            this.gbxUpdate.Controls.Add(this.cbxDepartmantUpdate);
            this.gbxUpdate.Controls.Add(this.cbxGenderUpdate);
            this.gbxUpdate.Controls.Add(this.cbxTitleNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblTitleNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxHomePhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblHomePhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.tbxMobilePhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblMobilePhoneUpdate);
            this.gbxUpdate.Controls.Add(this.lblGenderUpdate);
            this.gbxUpdate.Controls.Add(this.lblDepartmantNameUpdate);
            this.gbxUpdate.Controls.Add(this.dtpStartDateOfWorkUpdate);
            this.gbxUpdate.Controls.Add(this.lblStartDateOfWorkUpdate);
            this.gbxUpdate.Controls.Add(this.tbxSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.label8);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(1010, 414);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(395, 313);
            this.gbxUpdate.TabIndex = 2;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // dtpDismissDateUpdate
            // 
            this.dtpDismissDateUpdate.Location = new System.Drawing.Point(124, 107);
            this.dtpDismissDateUpdate.Name = "dtpDismissDateUpdate";
            this.dtpDismissDateUpdate.Size = new System.Drawing.Size(174, 20);
            this.dtpDismissDateUpdate.TabIndex = 21;
            this.dtpDismissDateUpdate.ValueChanged += new System.EventHandler(this.dtpDismissDateUpdate_ValueChanged);
            // 
            // lblDismissDate
            // 
            this.lblDismissDate.AutoSize = true;
            this.lblDismissDate.Location = new System.Drawing.Point(6, 110);
            this.lblDismissDate.Name = "lblDismissDate";
            this.lblDismissDate.Size = new System.Drawing.Size(112, 13);
            this.lblDismissDate.TabIndex = 22;
            this.lblDismissDate.Text = "Dissmis Date of Work ";
            this.lblDismissDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxEmailAdressUpdate
            // 
            this.tbxEmailAdressUpdate.Location = new System.Drawing.Point(124, 269);
            this.tbxEmailAdressUpdate.Name = "tbxEmailAdressUpdate";
            this.tbxEmailAdressUpdate.Size = new System.Drawing.Size(147, 20);
            this.tbxEmailAdressUpdate.TabIndex = 9;
            // 
            // lblEmailAdressUpdate
            // 
            this.lblEmailAdressUpdate.AutoSize = true;
            this.lblEmailAdressUpdate.Location = new System.Drawing.Point(6, 272);
            this.lblEmailAdressUpdate.Name = "lblEmailAdressUpdate";
            this.lblEmailAdressUpdate.Size = new System.Drawing.Size(67, 13);
            this.lblEmailAdressUpdate.TabIndex = 20;
            this.lblEmailAdressUpdate.Text = "Email Adress";
            this.lblEmailAdressUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxDepartmantUpdate
            // 
            this.cbxDepartmantUpdate.FormattingEnabled = true;
            this.cbxDepartmantUpdate.Location = new System.Drawing.Point(124, 134);
            this.cbxDepartmantUpdate.Name = "cbxDepartmantUpdate";
            this.cbxDepartmantUpdate.Size = new System.Drawing.Size(147, 21);
            this.cbxDepartmantUpdate.TabIndex = 4;
            // 
            // cbxGenderUpdate
            // 
            this.cbxGenderUpdate.FormattingEnabled = true;
            this.cbxGenderUpdate.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxGenderUpdate.Location = new System.Drawing.Point(124, 162);
            this.cbxGenderUpdate.Name = "cbxGenderUpdate";
            this.cbxGenderUpdate.Size = new System.Drawing.Size(147, 21);
            this.cbxGenderUpdate.TabIndex = 5;
            // 
            // cbxTitleNameUpdate
            // 
            this.cbxTitleNameUpdate.FormattingEnabled = true;
            this.cbxTitleNameUpdate.Location = new System.Drawing.Point(124, 242);
            this.cbxTitleNameUpdate.Name = "cbxTitleNameUpdate";
            this.cbxTitleNameUpdate.Size = new System.Drawing.Size(147, 21);
            this.cbxTitleNameUpdate.TabIndex = 8;
            // 
            // lblTitleNameUpdate
            // 
            this.lblTitleNameUpdate.AutoSize = true;
            this.lblTitleNameUpdate.Location = new System.Drawing.Point(6, 245);
            this.lblTitleNameUpdate.Name = "lblTitleNameUpdate";
            this.lblTitleNameUpdate.Size = new System.Drawing.Size(58, 13);
            this.lblTitleNameUpdate.TabIndex = 18;
            this.lblTitleNameUpdate.Text = "Title Name";
            this.lblTitleNameUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxHomePhoneNumberUpdate
            // 
            this.tbxHomePhoneNumberUpdate.Location = new System.Drawing.Point(124, 216);
            this.tbxHomePhoneNumberUpdate.Name = "tbxHomePhoneNumberUpdate";
            this.tbxHomePhoneNumberUpdate.Size = new System.Drawing.Size(147, 20);
            this.tbxHomePhoneNumberUpdate.TabIndex = 7;
            // 
            // lblHomePhoneNumberUpdate
            // 
            this.lblHomePhoneNumberUpdate.AutoSize = true;
            this.lblHomePhoneNumberUpdate.Location = new System.Drawing.Point(6, 219);
            this.lblHomePhoneNumberUpdate.Name = "lblHomePhoneNumberUpdate";
            this.lblHomePhoneNumberUpdate.Size = new System.Drawing.Size(109, 13);
            this.lblHomePhoneNumberUpdate.TabIndex = 14;
            this.lblHomePhoneNumberUpdate.Text = "Home Phone Number";
            this.lblHomePhoneNumberUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxMobilePhoneNumberUpdate
            // 
            this.tbxMobilePhoneNumberUpdate.Location = new System.Drawing.Point(124, 189);
            this.tbxMobilePhoneNumberUpdate.Name = "tbxMobilePhoneNumberUpdate";
            this.tbxMobilePhoneNumberUpdate.Size = new System.Drawing.Size(147, 20);
            this.tbxMobilePhoneNumberUpdate.TabIndex = 6;
            // 
            // lblMobilePhoneUpdate
            // 
            this.lblMobilePhoneUpdate.AutoSize = true;
            this.lblMobilePhoneUpdate.Location = new System.Drawing.Point(6, 192);
            this.lblMobilePhoneUpdate.Name = "lblMobilePhoneUpdate";
            this.lblMobilePhoneUpdate.Size = new System.Drawing.Size(112, 13);
            this.lblMobilePhoneUpdate.TabIndex = 12;
            this.lblMobilePhoneUpdate.Text = "Mobile Phone Number";
            this.lblMobilePhoneUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGenderUpdate
            // 
            this.lblGenderUpdate.AutoSize = true;
            this.lblGenderUpdate.Location = new System.Drawing.Point(6, 165);
            this.lblGenderUpdate.Name = "lblGenderUpdate";
            this.lblGenderUpdate.Size = new System.Drawing.Size(42, 13);
            this.lblGenderUpdate.TabIndex = 10;
            this.lblGenderUpdate.Text = "Gender";
            this.lblGenderUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDepartmantNameUpdate
            // 
            this.lblDepartmantNameUpdate.AutoSize = true;
            this.lblDepartmantNameUpdate.Location = new System.Drawing.Point(6, 137);
            this.lblDepartmantNameUpdate.Name = "lblDepartmantNameUpdate";
            this.lblDepartmantNameUpdate.Size = new System.Drawing.Size(93, 13);
            this.lblDepartmantNameUpdate.TabIndex = 8;
            this.lblDepartmantNameUpdate.Text = "Departmant Name";
            this.lblDepartmantNameUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpStartDateOfWorkUpdate
            // 
            this.dtpStartDateOfWorkUpdate.Location = new System.Drawing.Point(124, 78);
            this.dtpStartDateOfWorkUpdate.Name = "dtpStartDateOfWorkUpdate";
            this.dtpStartDateOfWorkUpdate.Size = new System.Drawing.Size(174, 20);
            this.dtpStartDateOfWorkUpdate.TabIndex = 3;
            // 
            // lblStartDateOfWorkUpdate
            // 
            this.lblStartDateOfWorkUpdate.AutoSize = true;
            this.lblStartDateOfWorkUpdate.Location = new System.Drawing.Point(6, 81);
            this.lblStartDateOfWorkUpdate.Name = "lblStartDateOfWorkUpdate";
            this.lblStartDateOfWorkUpdate.Size = new System.Drawing.Size(98, 13);
            this.lblStartDateOfWorkUpdate.TabIndex = 5;
            this.lblStartDateOfWorkUpdate.Text = "Start Date Of Work";
            this.lblStartDateOfWorkUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxSurnameUpdate
            // 
            this.tbxSurnameUpdate.Location = new System.Drawing.Point(124, 52);
            this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
            this.tbxSurnameUpdate.Size = new System.Drawing.Size(147, 20);
            this.tbxSurnameUpdate.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Surname";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(124, 26);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(147, 20);
            this.tbxNameUpdate.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(314, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(6, 29);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "Name";
            this.lblNameUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OperationsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 739);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwList);
            this.Name = "OperationsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.OperationsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartDWork;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.DateTimePicker dtpStartDateOfWork;
        private System.Windows.Forms.Label lblDepartmantName;
        private System.Windows.Forms.TextBox tbxMobileHomeNumer;
        private System.Windows.Forms.Label lblHomePhoneNumber;
        private System.Windows.Forms.TextBox tbxMobilePhoneNumer;
        private System.Windows.Forms.Label lblMobilePhoneNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.ComboBox cbxTitleName;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.ComboBox cbxDepartmantName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox tbxEmailAdressUpdate;
        private System.Windows.Forms.Label lblEmailAdressUpdate;
        private System.Windows.Forms.ComboBox cbxDepartmantUpdate;
        private System.Windows.Forms.ComboBox cbxGenderUpdate;
        private System.Windows.Forms.ComboBox cbxTitleNameUpdate;
        private System.Windows.Forms.Label lblTitleNameUpdate;
        private System.Windows.Forms.TextBox tbxHomePhoneNumberUpdate;
        private System.Windows.Forms.Label lblHomePhoneNumberUpdate;
        private System.Windows.Forms.TextBox tbxMobilePhoneNumberUpdate;
        private System.Windows.Forms.Label lblMobilePhoneUpdate;
        private System.Windows.Forms.Label lblGenderUpdate;
        private System.Windows.Forms.Label lblDepartmantNameUpdate;
        private System.Windows.Forms.DateTimePicker dtpStartDateOfWorkUpdate;
        private System.Windows.Forms.Label lblStartDateOfWorkUpdate;
        private System.Windows.Forms.TextBox tbxSurnameUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.DateTimePicker dtpDismissDateUpdate;
        private System.Windows.Forms.Label lblDismissDate;
    }
}

