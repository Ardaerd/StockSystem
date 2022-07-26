namespace StockSystem.Forms
{
    partial class StockCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCompanyForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.numericUpDown_stockId = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_companyId = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_tip = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_IrsaliyeDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_IrsaliyeNo = new System.Windows.Forms.NumericUpDown();
            this.button_selectCompany = new System.Windows.Forms.Button();
            this.dataGridView_stockCompany = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stockId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_companyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IrsaliyeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(162, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(846, 93);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(209)))), ((int)(((byte)(230)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(968, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Location = new System.Drawing.Point(-1, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 502);
            this.panel1.TabIndex = 10;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.Location = new System.Drawing.Point(0, 274);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(144, 57);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Image = ((System.Drawing.Image)(resources.GetObject("button_edit.Image")));
            this.button_edit.Location = new System.Drawing.Point(0, 184);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(147, 57);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Image = ((System.Drawing.Image)(resources.GetObject("button_add.Image")));
            this.button_add.Location = new System.Drawing.Point(0, 94);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(144, 57);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_status
            // 
            this.textBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_status.Location = new System.Drawing.Point(785, 126);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(160, 27);
            this.textBox_status.TabIndex = 32;
            // 
            // numericUpDown_stockId
            // 
            this.numericUpDown_stockId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_stockId.Location = new System.Drawing.Point(319, 126);
            this.numericUpDown_stockId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_stockId.Name = "numericUpDown_stockId";
            this.numericUpDown_stockId.Size = new System.Drawing.Size(114, 27);
            this.numericUpDown_stockId.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Irsaliye_Date :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "TIP :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Company_ID :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Stock_ID :";
            // 
            // numericUpDown_companyId
            // 
            this.numericUpDown_companyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_companyId.Location = new System.Drawing.Point(319, 185);
            this.numericUpDown_companyId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_companyId.Name = "numericUpDown_companyId";
            this.numericUpDown_companyId.Size = new System.Drawing.Size(114, 27);
            this.numericUpDown_companyId.TabIndex = 34;
            // 
            // numericUpDown_tip
            // 
            this.numericUpDown_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_tip.Location = new System.Drawing.Point(319, 245);
            this.numericUpDown_tip.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_tip.Name = "numericUpDown_tip";
            this.numericUpDown_tip.Size = new System.Drawing.Size(114, 27);
            this.numericUpDown_tip.TabIndex = 35;
            // 
            // dateTimePicker_IrsaliyeDate
            // 
            this.dateTimePicker_IrsaliyeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_IrsaliyeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_IrsaliyeDate.Location = new System.Drawing.Point(785, 180);
            this.dateTimePicker_IrsaliyeDate.Name = "dateTimePicker_IrsaliyeDate";
            this.dateTimePicker_IrsaliyeDate.Size = new System.Drawing.Size(160, 27);
            this.dateTimePicker_IrsaliyeDate.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(638, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 37;
            this.label8.Text = "Irsaliye_No :";
            // 
            // numericUpDown_IrsaliyeNo
            // 
            this.numericUpDown_IrsaliyeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_IrsaliyeNo.Location = new System.Drawing.Point(785, 233);
            this.numericUpDown_IrsaliyeNo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_IrsaliyeNo.Name = "numericUpDown_IrsaliyeNo";
            this.numericUpDown_IrsaliyeNo.Size = new System.Drawing.Size(114, 27);
            this.numericUpDown_IrsaliyeNo.TabIndex = 38;
            // 
            // button_selectCompany
            // 
            this.button_selectCompany.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectCompany.Location = new System.Drawing.Point(455, 181);
            this.button_selectCompany.Name = "button_selectCompany";
            this.button_selectCompany.Size = new System.Drawing.Size(95, 33);
            this.button_selectCompany.TabIndex = 44;
            this.button_selectCompany.Text = "Select";
            this.button_selectCompany.UseVisualStyleBackColor = true;
            this.button_selectCompany.Click += new System.EventHandler(this.button_selectCompany_Click);
            // 
            // dataGridView_stockCompany
            // 
            this.dataGridView_stockCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_stockCompany.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_stockCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_stockCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_stockCompany.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_stockCompany.Location = new System.Drawing.Point(168, 314);
            this.dataGridView_stockCompany.Name = "dataGridView_stockCompany";
            this.dataGridView_stockCompany.RowHeadersWidth = 51;
            this.dataGridView_stockCompany.RowTemplate.Height = 24;
            this.dataGridView_stockCompany.Size = new System.Drawing.Size(826, 223);
            this.dataGridView_stockCompany.TabIndex = 45;
            this.dataGridView_stockCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_stockCompany_CellClick);
            // 
            // StockCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1006, 549);
            this.Controls.Add(this.dataGridView_stockCompany);
            this.Controls.Add(this.button_selectCompany);
            this.Controls.Add(this.numericUpDown_IrsaliyeNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker_IrsaliyeDate);
            this.Controls.Add(this.numericUpDown_tip);
            this.Controls.Add(this.numericUpDown_companyId);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.numericUpDown_stockId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockCompanyForm";
            this.Load += new System.EventHandler(this.StockCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stockId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_companyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IrsaliyeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.NumericUpDown numericUpDown_stockId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_tip;
        private System.Windows.Forms.DateTimePicker dateTimePicker_IrsaliyeDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_IrsaliyeNo;
        private System.Windows.Forms.Button button_selectCompany;
        private System.Windows.Forms.DataGridView dataGridView_stockCompany;
        public System.Windows.Forms.NumericUpDown numericUpDown_companyId;
    }
}