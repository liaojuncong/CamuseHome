namespace CamuseHome
{
    partial class UpdatePwdForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.OldPwdTextBox = new System.Windows.Forms.TextBox();
            this.NewPwdTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPwdTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // OldPwdTextBox
            // 
            this.OldPwdTextBox.Location = new System.Drawing.Point(100, 27);
            this.OldPwdTextBox.Name = "OldPwdTextBox";
            this.OldPwdTextBox.PasswordChar = '*';
            this.OldPwdTextBox.Size = new System.Drawing.Size(120, 21);
            this.OldPwdTextBox.TabIndex = 3;
            // 
            // NewPwdTextBox
            // 
            this.NewPwdTextBox.Location = new System.Drawing.Point(100, 57);
            this.NewPwdTextBox.Name = "NewPwdTextBox";
            this.NewPwdTextBox.PasswordChar = '*';
            this.NewPwdTextBox.Size = new System.Drawing.Size(120, 21);
            this.NewPwdTextBox.TabIndex = 4;
            // 
            // ConfirmPwdTextBox
            // 
            this.ConfirmPwdTextBox.Location = new System.Drawing.Point(100, 87);
            this.ConfirmPwdTextBox.Name = "ConfirmPwdTextBox";
            this.ConfirmPwdTextBox.PasswordChar = '*';
            this.ConfirmPwdTextBox.Size = new System.Drawing.Size(120, 21);
            this.ConfirmPwdTextBox.TabIndex = 5;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(40, 122);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(145, 122);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UpdatePwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 157);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ConfirmPwdTextBox);
            this.Controls.Add(this.NewPwdTextBox);
            this.Controls.Add(this.OldPwdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePwdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "更改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPwdTextBox;
        private System.Windows.Forms.TextBox NewPwdTextBox;
        private System.Windows.Forms.TextBox ConfirmPwdTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
    }
}