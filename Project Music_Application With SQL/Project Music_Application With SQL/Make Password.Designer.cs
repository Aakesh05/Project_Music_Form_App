namespace Project_Music_Application_With_SQL
{
    partial class Make_Password
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
            this.TB_Updated_Pass = new System.Windows.Forms.TextBox();
            this.BTN_Update_Passw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make a new password (Remember this password)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Updated_Pass
            // 
            this.TB_Updated_Pass.Location = new System.Drawing.Point(122, 122);
            this.TB_Updated_Pass.Name = "TB_Updated_Pass";
            this.TB_Updated_Pass.PasswordChar = '*';
            this.TB_Updated_Pass.Size = new System.Drawing.Size(119, 20);
            this.TB_Updated_Pass.TabIndex = 1;
            this.TB_Updated_Pass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTN_Update_Passw
            // 
            this.BTN_Update_Passw.Location = new System.Drawing.Point(246, 199);
            this.BTN_Update_Passw.Name = "BTN_Update_Passw";
            this.BTN_Update_Passw.Size = new System.Drawing.Size(110, 23);
            this.BTN_Update_Passw.TabIndex = 2;
            this.BTN_Update_Passw.Text = "Update Password!";
            this.BTN_Update_Passw.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Make a new password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Make_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 234);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Update_Passw);
            this.Controls.Add(this.TB_Updated_Pass);
            this.Controls.Add(this.label1);
            this.Name = "Make_Password";
            this.Text = "Make_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Updated_Pass;
        private System.Windows.Forms.Button BTN_Update_Passw;
        private System.Windows.Forms.Label label2;
    }
}