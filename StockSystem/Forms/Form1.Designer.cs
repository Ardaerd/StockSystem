namespace StockSystem
{
    partial class Form1
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
            this.button_productInfo = new System.Windows.Forms.Button();
            this.button_productPrice = new System.Windows.Forms.Button();
            this.button_comapny = new System.Windows.Forms.Button();
            this.button_companyProduct = new System.Windows.Forms.Button();
            this.button_stockProduct = new System.Windows.Forms.Button();
            this.button_stockCompany = new System.Windows.Forms.Button();
            this.button_stockTracking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock System";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(685, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // button_productInfo
            // 
            this.button_productInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_productInfo.Location = new System.Drawing.Point(6, 68);
            this.button_productInfo.Name = "button_productInfo";
            this.button_productInfo.Size = new System.Drawing.Size(205, 43);
            this.button_productInfo.TabIndex = 2;
            this.button_productInfo.Text = "Product Info";
            this.button_productInfo.UseVisualStyleBackColor = true;
            this.button_productInfo.Click += new System.EventHandler(this.button_productInfo_Click);
            // 
            // button_productPrice
            // 
            this.button_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_productPrice.Location = new System.Drawing.Point(12, 154);
            this.button_productPrice.Name = "button_productPrice";
            this.button_productPrice.Size = new System.Drawing.Size(199, 43);
            this.button_productPrice.TabIndex = 3;
            this.button_productPrice.Text = "Product Price";
            this.button_productPrice.UseVisualStyleBackColor = true;
            this.button_productPrice.Click += new System.EventHandler(this.button_productPrice_Click);
            // 
            // button_comapny
            // 
            this.button_comapny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_comapny.Location = new System.Drawing.Point(232, 68);
            this.button_comapny.Name = "button_comapny";
            this.button_comapny.Size = new System.Drawing.Size(225, 43);
            this.button_comapny.TabIndex = 4;
            this.button_comapny.Text = "Company";
            this.button_comapny.UseVisualStyleBackColor = true;
            this.button_comapny.Click += new System.EventHandler(this.button_comapny_Click);
            // 
            // button_companyProduct
            // 
            this.button_companyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_companyProduct.Location = new System.Drawing.Point(232, 154);
            this.button_companyProduct.Name = "button_companyProduct";
            this.button_companyProduct.Size = new System.Drawing.Size(225, 43);
            this.button_companyProduct.TabIndex = 5;
            this.button_companyProduct.Text = "Company Product";
            this.button_companyProduct.UseVisualStyleBackColor = true;
            this.button_companyProduct.Click += new System.EventHandler(this.button_companyProduct_Click);
            // 
            // button_stockProduct
            // 
            this.button_stockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stockProduct.Location = new System.Drawing.Point(487, 68);
            this.button_stockProduct.Name = "button_stockProduct";
            this.button_stockProduct.Size = new System.Drawing.Size(225, 43);
            this.button_stockProduct.TabIndex = 6;
            this.button_stockProduct.Text = "Stock Product";
            this.button_stockProduct.UseVisualStyleBackColor = true;
            this.button_stockProduct.Click += new System.EventHandler(this.button_stockProduct_Click);
            // 
            // button_stockCompany
            // 
            this.button_stockCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stockCompany.Location = new System.Drawing.Point(487, 154);
            this.button_stockCompany.Name = "button_stockCompany";
            this.button_stockCompany.Size = new System.Drawing.Size(225, 43);
            this.button_stockCompany.TabIndex = 7;
            this.button_stockCompany.Text = "Stock Company";
            this.button_stockCompany.UseVisualStyleBackColor = true;
            this.button_stockCompany.Click += new System.EventHandler(this.button_stockCompany_Click);
            // 
            // button_stockTracking
            // 
            this.button_stockTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stockTracking.Location = new System.Drawing.Point(12, 233);
            this.button_stockTracking.Name = "button_stockTracking";
            this.button_stockTracking.Size = new System.Drawing.Size(700, 49);
            this.button_stockTracking.TabIndex = 8;
            this.button_stockTracking.Text = "Stock Tracking";
            this.button_stockTracking.UseVisualStyleBackColor = true;
            this.button_stockTracking.Click += new System.EventHandler(this.button_stockTracking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 294);
            this.Controls.Add(this.button_stockTracking);
            this.Controls.Add(this.button_stockCompany);
            this.Controls.Add(this.button_stockProduct);
            this.Controls.Add(this.button_companyProduct);
            this.Controls.Add(this.button_comapny);
            this.Controls.Add(this.button_productPrice);
            this.Controls.Add(this.button_productInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_productInfo;
        private System.Windows.Forms.Button button_productPrice;
        private System.Windows.Forms.Button button_comapny;
        private System.Windows.Forms.Button button_companyProduct;
        private System.Windows.Forms.Button button_stockProduct;
        private System.Windows.Forms.Button button_stockCompany;
        private System.Windows.Forms.Button button_stockTracking;
    }
}

