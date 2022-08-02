namespace StockSystem.Forms
{
    partial class StockProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_selectProduct = new System.Windows.Forms.Button();
            this.numericUpDown_ProductId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_stockProduct = new System.Windows.Forms.DataGridView();
            this.numericUpDown_StockId = new System.Windows.Forms.NumericUpDown();
            this.label_StockId = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label_quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ProductId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StockId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(167, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(916, 93);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stock Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1043, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(209)))), ((int)(((byte)(230)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Location = new System.Drawing.Point(-1, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 502);
            this.panel1.TabIndex = 8;
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
            // button_selectProduct
            // 
            this.button_selectProduct.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectProduct.Location = new System.Drawing.Point(751, 222);
            this.button_selectProduct.Name = "button_selectProduct";
            this.button_selectProduct.Size = new System.Drawing.Size(146, 33);
            this.button_selectProduct.TabIndex = 46;
            this.button_selectProduct.Text = "Select Product";
            this.button_selectProduct.UseVisualStyleBackColor = true;
            this.button_selectProduct.Click += new System.EventHandler(this.button_selectProduct_Click);
            // 
            // numericUpDown_ProductId
            // 
            this.numericUpDown_ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_ProductId.Location = new System.Drawing.Point(607, 222);
            this.numericUpDown_ProductId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_ProductId.Name = "numericUpDown_ProductId";
            this.numericUpDown_ProductId.Size = new System.Drawing.Size(114, 27);
            this.numericUpDown_ProductId.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Product_ID :";
            // 
            // dataGridView_stockProduct
            // 
            this.dataGridView_stockProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_stockProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_stockProduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_stockProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_stockProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_stockProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_stockProduct.Location = new System.Drawing.Point(179, 276);
            this.dataGridView_stockProduct.Name = "dataGridView_stockProduct";
            this.dataGridView_stockProduct.RowHeadersWidth = 51;
            this.dataGridView_stockProduct.RowTemplate.Height = 24;
            this.dataGridView_stockProduct.Size = new System.Drawing.Size(891, 305);
            this.dataGridView_stockProduct.TabIndex = 50;
            this.dataGridView_stockProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_stockProduct_CellClick);
            // 
            // numericUpDown_StockId
            // 
            this.numericUpDown_StockId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_StockId.Location = new System.Drawing.Point(607, 112);
            this.numericUpDown_StockId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_StockId.Name = "numericUpDown_StockId";
            this.numericUpDown_StockId.Size = new System.Drawing.Size(114, 27);
            this.numericUpDown_StockId.TabIndex = 52;
            // 
            // label_StockId
            // 
            this.label_StockId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StockId.Location = new System.Drawing.Point(442, 112);
            this.label_StockId.Name = "label_StockId";
            this.label_StockId.Size = new System.Drawing.Size(130, 23);
            this.label_StockId.TabIndex = 51;
            this.label_StockId.Text = "Stock_ID :";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(607, 171);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(114, 27);
            this.numericUpDownQuantity.TabIndex = 54;
            // 
            // label_quantity
            // 
            this.label_quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(442, 171);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(130, 23);
            this.label_quantity.TabIndex = 53;
            this.label_quantity.Text = "Quantity :";
            // 
            // StockProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1082, 593);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.numericUpDown_StockId);
            this.Controls.Add(this.label_StockId);
            this.Controls.Add(this.dataGridView_stockProduct);
            this.Controls.Add(this.button_selectProduct);
            this.Controls.Add(this.numericUpDown_ProductId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockProductForm";
            this.Load += new System.EventHandler(this.StockProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ProductId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StockId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_selectProduct;
        public System.Windows.Forms.NumericUpDown numericUpDown_ProductId;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numericUpDown_StockId;
        private System.Windows.Forms.Label label_StockId;
        public System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label_quantity;
        public System.Windows.Forms.DataGridView dataGridView_stockProduct;
    }
}