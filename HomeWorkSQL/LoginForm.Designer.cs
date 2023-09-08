namespace HomeWorkSQL
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.IDInputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.DBconnection = new System.Windows.Forms.Button();
            this.LoginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(77, 20);
            this.textBox_ID.MaxLength = 30;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(160, 21);
            this.textBox_ID.TabIndex = 0;
            this.textBox_ID.Text = "admin123";
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(77, 48);
            this.textBox_PassWord.MaxLength = 30;
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.PasswordChar = '*';
            this.textBox_PassWord.Size = new System.Drawing.Size(160, 21);
            this.textBox_PassWord.TabIndex = 1;
            this.textBox_PassWord.Text = "1234567";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(243, 20);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 50);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // IDInputLabel
            // 
            this.IDInputLabel.AutoSize = true;
            this.IDInputLabel.Location = new System.Drawing.Point(6, 23);
            this.IDInputLabel.Name = "IDInputLabel";
            this.IDInputLabel.Size = new System.Drawing.Size(20, 12);
            this.IDInputLabel.TabIndex = 3;
            this.IDInputLabel.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(249, 100);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.textBox_PassWord);
            this.LoginBox.Controls.Add(this.IDInputLabel);
            this.LoginBox.Controls.Add(this.label2);
            this.LoginBox.Controls.Add(this.textBox_ID);
            this.LoginBox.Controls.Add(this.LoginButton);
            this.LoginBox.Location = new System.Drawing.Point(6, 12);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(330, 85);
            this.LoginBox.TabIndex = 7;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login";
            // 
            // DBconnection
            // 
            this.DBconnection.Location = new System.Drawing.Point(168, 100);
            this.DBconnection.Name = "DBconnection";
            this.DBconnection.Size = new System.Drawing.Size(75, 23);
            this.DBconnection.TabIndex = 8;
            this.DBconnection.Text = "DBconfig";
            this.DBconnection.UseVisualStyleBackColor = true;
            this.DBconnection.Click += new System.EventHandler(this.DBconnection_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 135);
            this.ControlBox = false;
            this.Controls.Add(this.DBconnection);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label IDInputLabel;
        private System.Windows.Forms.Label label2;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Button DBconnection;
    }
}

