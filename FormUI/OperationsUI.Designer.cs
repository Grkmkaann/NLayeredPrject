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
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.gbxAdd.SuspendLayout();
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
            "Kadın",
            "Erkek"});
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
            // OperationsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 739);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwList);
            this.Name = "OperationsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.OperationsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
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
    }
}

