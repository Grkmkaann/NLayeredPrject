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
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
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
            this.dgwList.Location = new System.Drawing.Point(12, 113);
            this.dgwList.Name = "dgwList";
            this.dgwList.Size = new System.Drawing.Size(1393, 361);
            this.dgwList.TabIndex = 0;
            // 
            // OperationsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 739);
            this.Controls.Add(this.dgwList);
            this.Name = "OperationsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.OperationsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwList;
    }
}

