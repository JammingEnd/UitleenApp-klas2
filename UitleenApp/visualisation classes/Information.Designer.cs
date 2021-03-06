namespace UitleenApp.visualisation_classes
{
    partial class Information
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.buttonfix = new System.Windows.Forms.Button();
            this.buttondeletefr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.barcodeBox = new System.Windows.Forms.PictureBox();
            this.createProductCancelBtn = new System.Windows.Forms.Button();
            this.editProductCategory = new System.Windows.Forms.TextBox();
            this.editProductDesc = new System.Windows.Forms.TextBox();
            this.editRemark = new System.Windows.Forms.TextBox();
            this.EditStatusList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditProductName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelDelete);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.barcodeBox);
            this.panel1.Controls.Add(this.createProductCancelBtn);
            this.panel1.Controls.Add(this.editProductCategory);
            this.panel1.Controls.Add(this.editProductDesc);
            this.panel1.Controls.Add(this.editRemark);
            this.panel1.Controls.Add(this.EditStatusList);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EditProductName);
            this.panel1.Location = new System.Drawing.Point(233, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 478);
            this.panel1.TabIndex = 3;
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDelete.Controls.Add(this.buttonfix);
            this.panelDelete.Controls.Add(this.buttondeletefr);
            this.panelDelete.Controls.Add(this.label8);
            this.panelDelete.Location = new System.Drawing.Point(251, 145);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(257, 156);
            this.panelDelete.TabIndex = 17;
            // 
            // buttonfix
            // 
            this.buttonfix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.buttonfix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.buttonfix.Location = new System.Drawing.Point(32, 111);
            this.buttonfix.Name = "buttonfix";
            this.buttonfix.Size = new System.Drawing.Size(85, 32);
            this.buttonfix.TabIndex = 18;
            this.buttonfix.Text = "Nee";
            this.buttonfix.UseVisualStyleBackColor = false;
            this.buttonfix.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttondeletefr
            // 
            this.buttondeletefr.BackColor = System.Drawing.Color.PaleGreen;
            this.buttondeletefr.Location = new System.Drawing.Point(151, 111);
            this.buttondeletefr.Name = "buttondeletefr";
            this.buttondeletefr.Size = new System.Drawing.Size(85, 32);
            this.buttondeletefr.TabIndex = 18;
            this.buttondeletefr.Text = "Ja";
            this.buttondeletefr.UseVisualStyleBackColor = false;
            this.buttondeletefr.Click += new System.EventHandler(this.buttondeletefr_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Weet u zeker dat u dit \r\nproduct wilt verwijderen?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Click to save";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Print Barcode";
            // 
            // Print
            // 
            this.Print.Image = global::UitleenApp.Properties.Resources._3022251;
            this.Print.Location = new System.Drawing.Point(582, 407);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(95, 42);
            this.Print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Print.TabIndex = 14;
            this.Print.TabStop = false;
            this.Print.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Naam:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.saveBtn.Location = new System.Drawing.Point(407, 434);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 32);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Opslaan";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // barcodeBox
            // 
            this.barcodeBox.Location = new System.Drawing.Point(546, 218);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(171, 153);
            this.barcodeBox.TabIndex = 11;
            this.barcodeBox.TabStop = false;
            this.barcodeBox.Click += new System.EventHandler(this.barcodeBox_Click);
            // 
            // createProductCancelBtn
            // 
            this.createProductCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.createProductCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.createProductCancelBtn.Location = new System.Drawing.Point(270, 434);
            this.createProductCancelBtn.Name = "createProductCancelBtn";
            this.createProductCancelBtn.Size = new System.Drawing.Size(114, 32);
            this.createProductCancelBtn.TabIndex = 10;
            this.createProductCancelBtn.Text = "Verwijderen";
            this.createProductCancelBtn.UseVisualStyleBackColor = false;
            this.createProductCancelBtn.Click += new System.EventHandler(this.createProductCancelBtn_Click);
            // 
            // editProductCategory
            // 
            this.editProductCategory.Location = new System.Drawing.Point(298, 173);
            this.editProductCategory.Multiline = true;
            this.editProductCategory.Name = "editProductCategory";
            this.editProductCategory.Size = new System.Drawing.Size(190, 22);
            this.editProductCategory.TabIndex = 8;
            // 
            // editProductDesc
            // 
            this.editProductDesc.Location = new System.Drawing.Point(298, 217);
            this.editProductDesc.Multiline = true;
            this.editProductDesc.Name = "editProductDesc";
            this.editProductDesc.Size = new System.Drawing.Size(190, 96);
            this.editProductDesc.TabIndex = 7;
            // 
            // editRemark
            // 
            this.editRemark.Location = new System.Drawing.Point(298, 335);
            this.editRemark.Multiline = true;
            this.editRemark.Name = "editRemark";
            this.editRemark.Size = new System.Drawing.Size(190, 84);
            this.editRemark.TabIndex = 6;
            // 
            // EditStatusList
            // 
            this.EditStatusList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EditStatusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditStatusList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditStatusList.FormattingEnabled = true;
            this.EditStatusList.Items.AddRange(new object[] {
            "Aanwezig",
            "Afwezig",
            "Niet meer leverbaar"});
            this.EditStatusList.Location = new System.Drawing.Point(298, 135);
            this.EditStatusList.Name = "EditStatusList";
            this.EditStatusList.Size = new System.Drawing.Size(121, 21);
            this.EditStatusList.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beschrijving:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opmerkingen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // EditProductName
            // 
            this.EditProductName.Location = new System.Drawing.Point(283, 20);
            this.EditProductName.Multiline = true;
            this.EditProductName.Name = "EditProductName";
            this.EditProductName.Size = new System.Drawing.Size(205, 28);
            this.EditProductName.TabIndex = 0;
            this.EditProductName.TextChanged += new System.EventHandler(this.createProductName_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UitleenApp.Properties.Resources.FC_logo_ROC_Friese_Poort;
            this.pictureBox2.Location = new System.Drawing.Point(462, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(491, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Prodcut Bewerken";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1203, 796);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Information";
            this.Text = "Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox barcodeBox;
        private System.Windows.Forms.Button createProductCancelBtn;
        private System.Windows.Forms.TextBox editProductCategory;
        private System.Windows.Forms.TextBox editProductDesc;
        private System.Windows.Forms.TextBox editRemark;
        private System.Windows.Forms.ComboBox EditStatusList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditProductName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Print;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button buttonfix;
        private System.Windows.Forms.Button buttondeletefr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}