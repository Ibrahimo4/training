﻿namespace POSMainForm
{
    partial class frmAddEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditProduct));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.lblProductNo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtStocksOnHand = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button3);
            this.GroupBox1.Controls.Add(this.lblProductNo);
            this.GroupBox1.Controls.Add(this.txtDescription);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtReorderLevel);
            this.GroupBox1.Controls.Add(this.txtUnitPrice);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.txtStocksOnHand);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.txtCategory);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtBarcode);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtProductCode);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(8, 73);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(755, 398);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Information";
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.DarkGray;
            this.Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button3.BackgroundImage")));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Location = new System.Drawing.Point(346, 190);
            this.Button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(30, 26);
            this.Button3.TabIndex = 4;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblProductNo
            // 
            this.lblProductNo.BackColor = System.Drawing.Color.White;
            this.lblProductNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductNo.Location = new System.Drawing.Point(152, 53);
            this.lblProductNo.Name = "lblProductNo";
            this.lblProductNo.Size = new System.Drawing.Size(192, 27);
            this.lblProductNo.TabIndex = 2;
            this.lblProductNo.Text = " ";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(152, 119);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(567, 24);
            this.txtDescription.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(19, 123);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 17);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Description :";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.BackColor = System.Drawing.Color.White;
            this.txtReorderLevel.Location = new System.Drawing.Point(527, 191);
            this.txtReorderLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(192, 24);
            this.txtReorderLevel.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.White;
            this.txtUnitPrice.Location = new System.Drawing.Point(152, 223);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(192, 24);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(394, 194);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(115, 17);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Reorder Level :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(19, 226);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(84, 17);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Unit Price :";
            // 
            // txtStocksOnHand
            // 
            this.txtStocksOnHand.BackColor = System.Drawing.Color.White;
            this.txtStocksOnHand.Location = new System.Drawing.Point(527, 156);
            this.txtStocksOnHand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStocksOnHand.Name = "txtStocksOnHand";
            this.txtStocksOnHand.Size = new System.Drawing.Size(192, 24);
            this.txtStocksOnHand.TabIndex = 6;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(394, 160);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(131, 17);
            this.Label8.TabIndex = 4;
            this.Label8.Text = "Stocks on Hand :";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.White;
            this.txtCategory.Location = new System.Drawing.Point(152, 188);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(192, 24);
            this.txtCategory.TabIndex = 3;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(19, 192);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(83, 17);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Category :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Location = new System.Drawing.Point(152, 154);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(192, 24);
            this.txtBarcode.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(19, 158);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 17);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Barcode :";
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.Color.White;
            this.txtProductCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductCode.Location = new System.Drawing.Point(152, 86);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(567, 24);
            this.txtProductCode.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(19, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(114, 17);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Product Code :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(19, 54);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(102, 17);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Product No. :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 66);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(9, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 54);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(57, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add/Edit Product";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.button4);
            this.GroupBox2.Controls.Add(this.button1);
            this.GroupBox2.Location = new System.Drawing.Point(8, 478);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Size = new System.Drawing.Size(755, 111);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button4.Location = new System.Drawing.Point(656, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 78);
            this.button4.TabIndex = 16;
            this.button4.Text = "&Cancel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(561, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 78);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 603);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label lblProductNo;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtReorderLevel;
        internal System.Windows.Forms.TextBox txtUnitPrice;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtStocksOnHand;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCategory;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtProductCode;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}