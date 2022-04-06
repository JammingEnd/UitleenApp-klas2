
namespace UitleenApp.visualisation_classes
{
    partial class AddScreen
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
            this.createProductConfirmBtn = new System.Windows.Forms.Button();
            this.createProductCategory = new System.Windows.Forms.TextBox();
            this.createProductDesc = new System.Windows.Forms.TextBox();
            this.createRemark = new System.Windows.Forms.TextBox();
            this.createStatusList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createProductName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.createProductCancelBtn);
            this.panel1.Controls.Add(this.createProductConfirmBtn);
            this.panel1.Controls.Add(this.createProductCategory);
            this.panel1.Controls.Add(this.createProductDesc);
            this.panel1.Controls.Add(this.createRemark);
            this.panel1.Controls.Add(this.createStatusList);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.createProductName);
            this.panel1.Location = new System.Drawing.Point(227, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 478);
            this.panel1.TabIndex = 1;
            // 
            // createProductCancelBtn
            // 
            this.createProductCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.createProductCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(31)))));
            this.createProductCancelBtn.Location = new System.Drawing.Point(21, 434);
            this.createProductCancelBtn.Name = "createProductCancelBtn";
            this.createProductCancelBtn.Size = new System.Drawing.Size(114, 32);
            this.createProductCancelBtn.TabIndex = 10;
            this.createProductCancelBtn.Text = "Annuleren";
            this.createProductCancelBtn.UseVisualStyleBackColor = false;
            this.createProductCancelBtn.Click += new System.EventHandler(this.createProductCancelBtn_Click);
            // 
            // createProductConfirmBtn
            // 
            this.createProductConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(241)))), ((int)(((byte)(151)))));
            this.createProductConfirmBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(241)))), ((int)(((byte)(151)))));
            this.createProductConfirmBtn.FlatAppearance.BorderSize = 4;
            this.createProductConfirmBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createProductConfirmBtn.Location = new System.Drawing.Point(335, 434);
            this.createProductConfirmBtn.Name = "createProductConfirmBtn";
            this.createProductConfirmBtn.Size = new System.Drawing.Size(114, 32);
            this.createProductConfirmBtn.TabIndex = 9;
            this.createProductConfirmBtn.Text = "Aanmaken";
            this.createProductConfirmBtn.UseVisualStyleBackColor = false;
            this.createProductConfirmBtn.Click += new System.EventHandler(this.createProductConfirmBtn_Click);
            // 
            // createProductCategory
            // 
            this.createProductCategory.Location = new System.Drawing.Point(298, 173);
            this.createProductCategory.Multiline = true;
            this.createProductCategory.Name = "createProductCategory";
            this.createProductCategory.Size = new System.Drawing.Size(190, 22);
            this.createProductCategory.TabIndex = 8;
            // 
            // createProductDesc
            // 
            this.createProductDesc.Location = new System.Drawing.Point(298, 217);
            this.createProductDesc.Multiline = true;
            this.createProductDesc.Name = "createProductDesc";
            this.createProductDesc.Size = new System.Drawing.Size(190, 96);
            this.createProductDesc.TabIndex = 7;
            // 
            // createRemark
            // 
            this.createRemark.Location = new System.Drawing.Point(298, 335);
            this.createRemark.Multiline = true;
            this.createRemark.Name = "createRemark";
            this.createRemark.Size = new System.Drawing.Size(190, 84);
            this.createRemark.TabIndex = 6;
            // 
            // createStatusList
            // 
            this.createStatusList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.createStatusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createStatusList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createStatusList.FormattingEnabled = true;
            this.createStatusList.Items.AddRange(new object[] {
            "Aanwezig",
            "Afwezig",
            "Niet meer leverbaar"});
            this.createStatusList.Location = new System.Drawing.Point(298, 135);
            this.createStatusList.Name = "createStatusList";
            this.createStatusList.Size = new System.Drawing.Size(121, 21);
            this.createStatusList.TabIndex = 5;
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
            // createProductName
            // 
            this.createProductName.Location = new System.Drawing.Point(283, 20);
            this.createProductName.Multiline = true;
            this.createProductName.Name = "createProductName";
            this.createProductName.Size = new System.Drawing.Size(205, 28);
            this.createProductName.TabIndex = 0;
            this.createProductName.Text = "Vul hier de naam in:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UitleenApp.Properties.Resources.FC_logo_ROC_Friese_Poort;
            this.pictureBox1.Location = new System.Drawing.Point(456, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1203, 796);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddScreen";
            this.Text = "AddScreen";
            this.Load += new System.EventHandler(this.AddScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createProductName;
        private System.Windows.Forms.TextBox createProductCategory;
        private System.Windows.Forms.TextBox createProductDesc;
        private System.Windows.Forms.TextBox createRemark;
        private System.Windows.Forms.ComboBox createStatusList;
        private System.Windows.Forms.Button createProductCancelBtn;
        private System.Windows.Forms.Button createProductConfirmBtn;
    }
}