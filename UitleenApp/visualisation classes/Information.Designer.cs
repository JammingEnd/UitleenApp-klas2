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
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.pictureBox1);
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
            // createProductCancelBtn
            // 
            this.createProductCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.createProductCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.createProductCancelBtn.Location = new System.Drawing.Point(21, 434);
            this.createProductCancelBtn.Name = "createProductCancelBtn";
            this.createProductCancelBtn.Size = new System.Drawing.Size(114, 32);
            this.createProductCancelBtn.TabIndex = 10;
            this.createProductCancelBtn.Text = "Verwijderen";
            this.createProductCancelBtn.UseVisualStyleBackColor = false;
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
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beschrijving:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opmerkingen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
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
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.saveBtn.Location = new System.Drawing.Point(312, 434);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(154, 32);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Opslaan";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(559, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 153);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UitleenApp.Properties.Resources.FC_logo_ROC_Friese_Poort;
            this.pictureBox2.Location = new System.Drawing.Point(462, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Naam:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1203, 796);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Information";
            this.Text = "Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}