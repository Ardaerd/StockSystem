namespace StockSystem.Forms
{
    partial class SelectCompanyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_selectClose = new System.Windows.Forms.Button();
            this.dataGridView_selectCompany = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // button_selectClose
            // 
            this.button_selectClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.button_selectClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectClose.Location = new System.Drawing.Point(160, 469);
            this.button_selectClose.Name = "button_selectClose";
            this.button_selectClose.Size = new System.Drawing.Size(182, 52);
            this.button_selectClose.TabIndex = 38;
            this.button_selectClose.Text = "Select ";
            this.button_selectClose.UseVisualStyleBackColor = false;
            this.button_selectClose.Click += new System.EventHandler(this.button_selectClose_Click);
            // 
            // dataGridView_selectCompany
            // 
            this.dataGridView_selectCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selectCompany.Location = new System.Drawing.Point(12, 101);
            this.dataGridView_selectCompany.Name = "dataGridView_selectCompany";
            this.dataGridView_selectCompany.RowHeadersWidth = 51;
            this.dataGridView_selectCompany.RowTemplate.Height = 24;
            this.dataGridView_selectCompany.Size = new System.Drawing.Size(473, 347);
            this.dataGridView_selectCompany.TabIndex = 37;
            this.dataGridView_selectCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_selectCompany_CellClick);
            // 
            // SelectCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(497, 533);
            this.Controls.Add(this.button_selectClose);
            this.Controls.Add(this.dataGridView_selectCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCompanyForm";
            this.Load += new System.EventHandler(this.SelectCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_selectClose;
        private System.Windows.Forms.DataGridView dataGridView_selectCompany;
    }
}