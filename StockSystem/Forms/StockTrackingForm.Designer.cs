namespace StockSystem.Forms
{
    partial class StockTrackingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTrackingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_stock = new System.Windows.Forms.Button();
            this.label_startingDate = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.dateTimePicker_startingDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endingDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_companyName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(163, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 93);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stock Tracking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(209)))), ((int)(((byte)(230)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.button_stock);
            this.panel1.Location = new System.Drawing.Point(-2, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 367);
            this.panel1.TabIndex = 11;
            // 
            // button_stock
            // 
            this.button_stock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stock.Image = ((System.Drawing.Image)(resources.GetObject("button_stock.Image")));
            this.button_stock.Location = new System.Drawing.Point(0, 132);
            this.button_stock.Name = "button_stock";
            this.button_stock.Size = new System.Drawing.Size(144, 57);
            this.button_stock.TabIndex = 5;
            this.button_stock.Text = "Stock";
            this.button_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_stock.UseVisualStyleBackColor = true;
            this.button_stock.Click += new System.EventHandler(this.button_stock_Click);
            // 
            // label_startingDate
            // 
            this.label_startingDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startingDate.Location = new System.Drawing.Point(165, 119);
            this.label_startingDate.Name = "label_startingDate";
            this.label_startingDate.Size = new System.Drawing.Size(152, 30);
            this.label_startingDate.TabIndex = 12;
            this.label_startingDate.Text = "Starting_Date :";
            // 
            // label_2
            // 
            this.label_2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(169, 165);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(148, 30);
            this.label_2.TabIndex = 13;
            this.label_2.Text = "Ending_Date :";
            // 
            // dateTimePicker_startingDate
            // 
            this.dateTimePicker_startingDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_startingDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_startingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startingDate.Location = new System.Drawing.Point(323, 120);
            this.dateTimePicker_startingDate.Name = "dateTimePicker_startingDate";
            this.dateTimePicker_startingDate.Size = new System.Drawing.Size(139, 28);
            this.dateTimePicker_startingDate.TabIndex = 14;
            this.dateTimePicker_startingDate.Value = new System.DateTime(2022, 8, 8, 0, 0, 0, 0);
            // 
            // dateTimePicker_endingDate
            // 
            this.dateTimePicker_endingDate.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_endingDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_endingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endingDate.Location = new System.Drawing.Point(323, 166);
            this.dateTimePicker_endingDate.Name = "dateTimePicker_endingDate";
            this.dateTimePicker_endingDate.Size = new System.Drawing.Size(139, 28);
            this.dateTimePicker_endingDate.TabIndex = 15;
            this.dateTimePicker_endingDate.Value = new System.DateTime(2022, 8, 8, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Company_Name :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "(Optinal)";
            // 
            // dataGridView_stock
            // 
            this.dataGridView_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_stock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_stock.Location = new System.Drawing.Point(169, 219);
            this.dataGridView_stock.Name = "dataGridView_stock";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_stock.RowHeadersWidth = 51;
            this.dataGridView_stock.RowTemplate.Height = 24;
            this.dataGridView_stock.Size = new System.Drawing.Size(731, 219);
            this.dataGridView_stock.TabIndex = 19;
            this.dataGridView_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_stock_CellClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(872, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // comboBox_companyName
            // 
            this.comboBox_companyName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_companyName.FormattingEnabled = true;
            this.comboBox_companyName.Location = new System.Drawing.Point(671, 119);
            this.comboBox_companyName.Name = "comboBox_companyName";
            this.comboBox_companyName.Size = new System.Drawing.Size(229, 29);
            this.comboBox_companyName.TabIndex = 21;
            // 
            // StockTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.comboBox_companyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_endingDate);
            this.Controls.Add(this.dateTimePicker_startingDate);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_startingDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockTrackingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockTrackingForm";
            this.Load += new System.EventHandler(this.StockTrackingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_stock;
        private System.Windows.Forms.Label label_startingDate;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startingDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_companyName;
    }
}