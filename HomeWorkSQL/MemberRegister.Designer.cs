namespace HomeWorkSQL
{
    partial class MemberRegister
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
            this.AdderGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idNumbox = new System.Windows.Forms.TextBox();
            this.Marry = new System.Windows.Forms.CheckBox();
            this.IDnum = new System.Windows.Forms.Label();
            this.registBtn = new System.Windows.Forms.Button();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdderGroup
            // 
            this.AdderGroup.Controls.Add(this.button1);
            this.AdderGroup.Controls.Add(this.idNumbox);
            this.AdderGroup.Controls.Add(this.Marry);
            this.AdderGroup.Controls.Add(this.IDnum);
            this.AdderGroup.Controls.Add(this.registBtn);
            this.AdderGroup.Controls.Add(this.birthdayPicker);
            this.AdderGroup.Controls.Add(this.label3);
            this.AdderGroup.Controls.Add(this.NameBox);
            this.AdderGroup.Controls.Add(this.label2);
            this.AdderGroup.Controls.Add(this.jobBox);
            this.AdderGroup.Controls.Add(this.label1);
            this.AdderGroup.Location = new System.Drawing.Point(8, 12);
            this.AdderGroup.Name = "AdderGroup";
            this.AdderGroup.Size = new System.Drawing.Size(242, 182);
            this.AdderGroup.TabIndex = 16;
            this.AdderGroup.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idNumbox
            // 
            this.idNumbox.Location = new System.Drawing.Point(65, 13);
            this.idNumbox.Name = "idNumbox";
            this.idNumbox.Size = new System.Drawing.Size(76, 21);
            this.idNumbox.TabIndex = 12;
            // 
            // Marry
            // 
            this.Marry.AutoSize = true;
            this.Marry.Location = new System.Drawing.Point(168, 122);
            this.Marry.Name = "Marry";
            this.Marry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Marry.Size = new System.Drawing.Size(67, 16);
            this.Marry.TabIndex = 10;
            this.Marry.Text = "Married";
            this.Marry.UseVisualStyleBackColor = true;
            // 
            // IDnum
            // 
            this.IDnum.AutoSize = true;
            this.IDnum.Location = new System.Drawing.Point(6, 17);
            this.IDnum.Name = "IDnum";
            this.IDnum.Size = new System.Drawing.Size(16, 12);
            this.IDnum.TabIndex = 13;
            this.IDnum.Text = "ID";
            // 
            // registBtn
            // 
            this.registBtn.Location = new System.Drawing.Point(79, 153);
            this.registBtn.Name = "registBtn";
            this.registBtn.Size = new System.Drawing.Size(75, 23);
            this.registBtn.TabIndex = 9;
            this.registBtn.Text = "Regist";
            this.registBtn.UseVisualStyleBackColor = true;
            this.registBtn.Click += new System.EventHandler(this.registBtn_Click);
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(65, 67);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(170, 21);
            this.birthdayPicker.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Job";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(65, 40);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(170, 21);
            this.NameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthday";
            // 
            // jobBox
            // 
            this.jobBox.Location = new System.Drawing.Point(65, 95);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(170, 21);
            this.jobBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // MemberRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 206);
            this.ControlBox = false;
            this.Controls.Add(this.AdderGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "MemberRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.AdderGroup.ResumeLayout(false);
            this.AdderGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdderGroup;
        private System.Windows.Forms.TextBox idNumbox;
        private System.Windows.Forms.CheckBox Marry;
        private System.Windows.Forms.Label IDnum;
        private System.Windows.Forms.Button registBtn;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}