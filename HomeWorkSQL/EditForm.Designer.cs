﻿namespace HomeWorkSQL
{
    partial class EditForm
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
      this.EditGroup = new System.Windows.Forms.GroupBox();
      this.button1 = new System.Windows.Forms.Button();
      this.idNumboxEdit = new System.Windows.Forms.TextBox();
      this.MarryEdit = new System.Windows.Forms.CheckBox();
      this.IDnum = new System.Windows.Forms.Label();
      this.Edit = new System.Windows.Forms.Button();
      this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.nameBoxEdit = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.jobBoxEdit = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.EditGroup.SuspendLayout();
      this.SuspendLayout();
      // 
      // EditGroup
      // 
      this.EditGroup.Controls.Add(this.button1);
      this.EditGroup.Controls.Add(this.idNumboxEdit);
      this.EditGroup.Controls.Add(this.MarryEdit);
      this.EditGroup.Controls.Add(this.IDnum);
      this.EditGroup.Controls.Add(this.Edit);
      this.EditGroup.Controls.Add(this.birthdayPicker);
      this.EditGroup.Controls.Add(this.label3);
      this.EditGroup.Controls.Add(this.nameBoxEdit);
      this.EditGroup.Controls.Add(this.label2);
      this.EditGroup.Controls.Add(this.jobBoxEdit);
      this.EditGroup.Controls.Add(this.label1);
      this.EditGroup.Location = new System.Drawing.Point(8, 12);
      this.EditGroup.Name = "EditGroup";
      this.EditGroup.Size = new System.Drawing.Size(242, 182);
      this.EditGroup.TabIndex = 16;
      this.EditGroup.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(160, 153);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 16;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // idNumboxEdit
      // 
      this.idNumboxEdit.Location = new System.Drawing.Point(65, 13);
      this.idNumboxEdit.Name = "idNumboxEdit";
      this.idNumboxEdit.ReadOnly = true;
      this.idNumboxEdit.Size = new System.Drawing.Size(76, 21);
      this.idNumboxEdit.TabIndex = 12;
      // 
      // MarryEdit
      // 
      this.MarryEdit.AutoSize = true;
      this.MarryEdit.Location = new System.Drawing.Point(168, 131);
      this.MarryEdit.Name = "MarryEdit";
      this.MarryEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.MarryEdit.Size = new System.Drawing.Size(67, 16);
      this.MarryEdit.TabIndex = 10;
      this.MarryEdit.Text = "Married";
      this.MarryEdit.UseVisualStyleBackColor = true;
      // 
      // IDnum
      // 
      this.IDnum.AutoSize = true;
      this.IDnum.Location = new System.Drawing.Point(6, 22);
      this.IDnum.Name = "IDnum";
      this.IDnum.Size = new System.Drawing.Size(16, 12);
      this.IDnum.TabIndex = 13;
      this.IDnum.Text = "ID";
      // 
      // Edit
      // 
      this.Edit.Location = new System.Drawing.Point(79, 153);
      this.Edit.Name = "Edit";
      this.Edit.Size = new System.Drawing.Size(75, 23);
      this.Edit.TabIndex = 9;
      this.Edit.Text = "Edit";
      this.Edit.UseVisualStyleBackColor = true;
      this.Edit.Click += new System.EventHandler(this.Edit_Click);
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
      this.label3.Location = new System.Drawing.Point(8, 98);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "Job";
      // 
      // nameBoxEdit
      // 
      this.nameBoxEdit.Location = new System.Drawing.Point(65, 40);
      this.nameBoxEdit.Name = "nameBoxEdit";
      this.nameBoxEdit.Size = new System.Drawing.Size(170, 21);
      this.nameBoxEdit.TabIndex = 4;
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
      // jobBoxEdit
      // 
      this.jobBoxEdit.Location = new System.Drawing.Point(65, 95);
      this.jobBoxEdit.Name = "jobBoxEdit";
      this.jobBoxEdit.Size = new System.Drawing.Size(170, 21);
      this.jobBoxEdit.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // EditForm
      // 
      this.ClientSize = new System.Drawing.Size(257, 206);
      this.ControlBox = false;
      this.Controls.Add(this.EditGroup);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Location = new System.Drawing.Point(100, 100);
      this.MaximizeBox = false;
      this.Name = "EditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "EditForm";
      this.Load += new System.EventHandler(this.EditForm_Load);
      this.EditGroup.ResumeLayout(false);
      this.EditGroup.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EditGroup;
        private System.Windows.Forms.TextBox idNumboxEdit;
        private System.Windows.Forms.CheckBox MarryEdit;
        private System.Windows.Forms.Label IDnum;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBoxEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobBoxEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}