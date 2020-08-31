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
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblStartDWork = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDepartmantCode = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblDepartmantName = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblMobilePhoneNumber = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblHomePhoneNumber = new System.Windows.Forms.Label();
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
            this.gbxAdd.Controls.Add(this.textBox7);
            this.gbxAdd.Controls.Add(this.lblHomePhoneNumber);
            this.gbxAdd.Controls.Add(this.textBox6);
            this.gbxAdd.Controls.Add(this.lblMobilePhoneNumber);
            this.gbxAdd.Controls.Add(this.textBox5);
            this.gbxAdd.Controls.Add(this.lblGender);
            this.gbxAdd.Controls.Add(this.textBox4);
            this.gbxAdd.Controls.Add(this.lblDepartmantName);
            this.gbxAdd.Controls.Add(this.textBox3);
            this.gbxAdd.Controls.Add(this.lblDepartmantCode);
            this.gbxAdd.Controls.Add(this.dateTimePicker1);
            this.gbxAdd.Controls.Add(this.lblStartDWork);
            this.gbxAdd.Controls.Add(this.textBox2);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Controls.Add(this.textBox1);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 414);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(350, 313);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add New";
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 4;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 7;
            // 
            // lblDepartmantCode
            // 
            this.lblDepartmantCode.AutoSize = true;
            this.lblDepartmantCode.Location = new System.Drawing.Point(6, 107);
            this.lblDepartmantCode.Name = "lblDepartmantCode";
            this.lblDepartmantCode.Size = new System.Drawing.Size(90, 13);
            this.lblDepartmantCode.TabIndex = 6;
            this.lblDepartmantCode.Text = "Departmant Code";
            this.lblDepartmantCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 20);
            this.textBox4.TabIndex = 9;
            // 
            // lblDepartmantName
            // 
            this.lblDepartmantName.AutoSize = true;
            this.lblDepartmantName.Location = new System.Drawing.Point(6, 133);
            this.lblDepartmantName.Name = "lblDepartmantName";
            this.lblDepartmantName.Size = new System.Drawing.Size(93, 13);
            this.lblDepartmantName.TabIndex = 8;
            this.lblDepartmantName.Text = "Departmant Name";
            this.lblDepartmantName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 20);
            this.textBox5.TabIndex = 11;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 159);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(124, 182);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 20);
            this.textBox6.TabIndex = 13;
            // 
            // lblMobilePhoneNumber
            // 
            this.lblMobilePhoneNumber.AutoSize = true;
            this.lblMobilePhoneNumber.Location = new System.Drawing.Point(6, 185);
            this.lblMobilePhoneNumber.Name = "lblMobilePhoneNumber";
            this.lblMobilePhoneNumber.Size = new System.Drawing.Size(112, 13);
            this.lblMobilePhoneNumber.TabIndex = 12;
            this.lblMobilePhoneNumber.Text = "Mobile Phone Number";
            this.lblMobilePhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(124, 208);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(147, 20);
            this.textBox7.TabIndex = 15;
            // 
            // lblHomePhoneNumber
            // 
            this.lblHomePhoneNumber.AutoSize = true;
            this.lblHomePhoneNumber.Location = new System.Drawing.Point(6, 211);
            this.lblHomePhoneNumber.Name = "lblHomePhoneNumber";
            this.lblHomePhoneNumber.Size = new System.Drawing.Size(109, 13);
            this.lblHomePhoneNumber.TabIndex = 14;
            this.lblHomePhoneNumber.Text = "Home Phone Number";
            this.lblHomePhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartDWork;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDepartmantCode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblDepartmantName;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblHomePhoneNumber;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblMobilePhoneNumber;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblGender;
    }
}

