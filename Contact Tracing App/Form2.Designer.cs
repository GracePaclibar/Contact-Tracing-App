
namespace Contact_Tracing_App
{
    partial class Form2
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
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBoxFever = new System.Windows.Forms.CheckBox();
            this.chkBoxDiarrhea = new System.Windows.Forms.CheckBox();
            this.chkBoxCough = new System.Windows.Forms.CheckBox();
            this.chkBoxDifInBreathing = new System.Windows.Forms.CheckBox();
            this.chkBoxColds = new System.Windows.Forms.CheckBox();
            this.chkBoxSoreThroat = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.txtBoxDestination = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.txtBoxSex = new System.Windows.Forms.TextBox();
            this.labelContactNum = new System.Windows.Forms.Label();
            this.txtBoxContactNum = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMidName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txtBoxMidName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(324, 286);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 140;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkBoxFever);
            this.panel1.Controls.Add(this.chkBoxDiarrhea);
            this.panel1.Controls.Add(this.chkBoxCough);
            this.panel1.Controls.Add(this.chkBoxDifInBreathing);
            this.panel1.Controls.Add(this.chkBoxColds);
            this.panel1.Controls.Add(this.chkBoxSoreThroat);
            this.panel1.Location = new System.Drawing.Point(37, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 87);
            this.panel1.TabIndex = 139;
            // 
            // chkBoxFever
            // 
            this.chkBoxFever.AutoSize = true;
            this.chkBoxFever.Location = new System.Drawing.Point(0, 11);
            this.chkBoxFever.Name = "chkBoxFever";
            this.chkBoxFever.Size = new System.Drawing.Size(54, 19);
            this.chkBoxFever.TabIndex = 110;
            this.chkBoxFever.Text = "Fever";
            this.chkBoxFever.UseVisualStyleBackColor = true;
            // 
            // chkBoxDiarrhea
            // 
            this.chkBoxDiarrhea.AutoSize = true;
            this.chkBoxDiarrhea.Location = new System.Drawing.Point(118, 61);
            this.chkBoxDiarrhea.Name = "chkBoxDiarrhea";
            this.chkBoxDiarrhea.Size = new System.Drawing.Size(70, 19);
            this.chkBoxDiarrhea.TabIndex = 115;
            this.chkBoxDiarrhea.Text = "Diarrhea";
            this.chkBoxDiarrhea.UseVisualStyleBackColor = true;
            // 
            // chkBoxCough
            // 
            this.chkBoxCough.AutoSize = true;
            this.chkBoxCough.Location = new System.Drawing.Point(0, 36);
            this.chkBoxCough.Name = "chkBoxCough";
            this.chkBoxCough.Size = new System.Drawing.Size(62, 19);
            this.chkBoxCough.TabIndex = 111;
            this.chkBoxCough.Text = "Cough";
            this.chkBoxCough.UseVisualStyleBackColor = true;
            // 
            // chkBoxDifInBreathing
            // 
            this.chkBoxDifInBreathing.AutoSize = true;
            this.chkBoxDifInBreathing.Location = new System.Drawing.Point(118, 36);
            this.chkBoxDifInBreathing.Name = "chkBoxDifInBreathing";
            this.chkBoxDifInBreathing.Size = new System.Drawing.Size(141, 19);
            this.chkBoxDifInBreathing.TabIndex = 114;
            this.chkBoxDifInBreathing.Text = "Difficulty in Breathing";
            this.chkBoxDifInBreathing.UseVisualStyleBackColor = true;
            // 
            // chkBoxColds
            // 
            this.chkBoxColds.AutoSize = true;
            this.chkBoxColds.Location = new System.Drawing.Point(0, 61);
            this.chkBoxColds.Name = "chkBoxColds";
            this.chkBoxColds.Size = new System.Drawing.Size(56, 19);
            this.chkBoxColds.TabIndex = 112;
            this.chkBoxColds.Text = "Colds";
            this.chkBoxColds.UseVisualStyleBackColor = true;
            // 
            // chkBoxSoreThroat
            // 
            this.chkBoxSoreThroat.AutoSize = true;
            this.chkBoxSoreThroat.Location = new System.Drawing.Point(118, 11);
            this.chkBoxSoreThroat.Name = "chkBoxSoreThroat";
            this.chkBoxSoreThroat.Size = new System.Drawing.Size(86, 19);
            this.chkBoxSoreThroat.TabIndex = 113;
            this.chkBoxSoreThroat.Text = "Sore Throat";
            this.chkBoxSoreThroat.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(324, 315);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 138;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(323, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 137;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 227);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(355, 30);
            this.labelQuestion.TabIndex = 127;
            this.labelQuestion.Text = "Check the box if you have been sick of any of the following in the \r\nlast 14 days" +
    ".\r\n";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(185, 171);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(70, 15);
            this.labelDestination.TabIndex = 126;
            this.labelDestination.Text = "Destination:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(274, 116);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(34, 15);
            this.labelDate.TabIndex = 125;
            this.labelDate.Text = "Date:";
            // 
            // txtBoxDestination
            // 
            this.txtBoxDestination.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxDestination.Location = new System.Drawing.Point(185, 189);
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.Size = new System.Drawing.Size(214, 23);
            this.txtBoxDestination.TabIndex = 136;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxDate.Location = new System.Drawing.Point(274, 134);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(125, 23);
            this.txtBoxDate.TabIndex = 134;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(144, 116);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(28, 15);
            this.labelSex.TabIndex = 124;
            this.labelSex.Text = "Sex:";
            // 
            // txtBoxSex
            // 
            this.txtBoxSex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxSex.Location = new System.Drawing.Point(143, 134);
            this.txtBoxSex.Name = "txtBoxSex";
            this.txtBoxSex.Size = new System.Drawing.Size(125, 23);
            this.txtBoxSex.TabIndex = 133;
            // 
            // labelContactNum
            // 
            this.labelContactNum.AutoSize = true;
            this.labelContactNum.Location = new System.Drawing.Point(11, 171);
            this.labelContactNum.Name = "labelContactNum";
            this.labelContactNum.Size = new System.Drawing.Size(99, 15);
            this.labelContactNum.TabIndex = 123;
            this.labelContactNum.Text = "Contact Number:";
            // 
            // txtBoxContactNum
            // 
            this.txtBoxContactNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxContactNum.Location = new System.Drawing.Point(12, 189);
            this.txtBoxContactNum.Name = "txtBoxContactNum";
            this.txtBoxContactNum.Size = new System.Drawing.Size(167, 23);
            this.txtBoxContactNum.TabIndex = 135;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 116);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(31, 15);
            this.labelAge.TabIndex = 122;
            this.labelAge.Text = "Age:";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxAge.Location = new System.Drawing.Point(12, 134);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(125, 23);
            this.txtBoxAge.TabIndex = 132;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxAddress.Location = new System.Drawing.Point(12, 81);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(387, 23);
            this.txtBoxAddress.TabIndex = 131;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 62);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 15);
            this.labelAddress.TabIndex = 121;
            this.labelAddress.Text = "Address:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(274, 10);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 15);
            this.labelLastName.TabIndex = 120;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelMidName
            // 
            this.labelMidName.AutoSize = true;
            this.labelMidName.Location = new System.Drawing.Point(143, 9);
            this.labelMidName.Name = "labelMidName";
            this.labelMidName.Size = new System.Drawing.Size(82, 15);
            this.labelMidName.TabIndex = 119;
            this.labelMidName.Text = "Middle Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 9);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(67, 15);
            this.labelFirstName.TabIndex = 118;
            this.labelFirstName.Text = "First Name:";
            // 
            // txtBoxMidName
            // 
            this.txtBoxMidName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxMidName.Location = new System.Drawing.Point(143, 27);
            this.txtBoxMidName.Name = "txtBoxMidName";
            this.txtBoxMidName.Size = new System.Drawing.Size(125, 23);
            this.txtBoxMidName.TabIndex = 129;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxLastName.Location = new System.Drawing.Point(274, 27);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(125, 23);
            this.txtBoxLastName.TabIndex = 130;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxFirstName.Location = new System.Drawing.Point(12, 27);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(125, 23);
            this.txtBoxFirstName.TabIndex = 128;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 349);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.txtBoxDestination);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.txtBoxSex);
            this.Controls.Add(this.labelContactNum);
            this.Controls.Add(this.txtBoxContactNum);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMidName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.txtBoxMidName);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkBoxFever;
        private System.Windows.Forms.CheckBox chkBoxDiarrhea;
        private System.Windows.Forms.CheckBox chkBoxCough;
        private System.Windows.Forms.CheckBox chkBoxDifInBreathing;
        private System.Windows.Forms.CheckBox chkBoxColds;
        private System.Windows.Forms.CheckBox chkBoxSoreThroat;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtBoxDestination;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TextBox txtBoxSex;
        private System.Windows.Forms.Label labelContactNum;
        private System.Windows.Forms.TextBox txtBoxContactNum;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMidName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtBoxMidName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
    }
}