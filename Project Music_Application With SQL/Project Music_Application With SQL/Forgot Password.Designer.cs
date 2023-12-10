namespace Project_Music_Application_With_SQL
{
    partial class Forgot_Password
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
            this.TB_Pass_Retriver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_New_Pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Pass_Retriver
            // 
            this.TB_Pass_Retriver.Location = new System.Drawing.Point(130, 95);
            this.TB_Pass_Retriver.Name = "TB_Pass_Retriver";
            this.TB_Pass_Retriver.Size = new System.Drawing.Size(147, 20);
            this.TB_Pass_Retriver.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forgot Password? Enter your email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your email:";
            // 
            // BTN_New_Pass
            // 
            this.BTN_New_Pass.Location = new System.Drawing.Point(253, 202);
            this.BTN_New_Pass.Name = "BTN_New_Pass";
            this.BTN_New_Pass.Size = new System.Drawing.Size(118, 23);
            this.BTN_New_Pass.TabIndex = 3;
            this.BTN_New_Pass.Text = "Make new password";
            this.BTN_New_Pass.UseVisualStyleBackColor = true;
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 237);
            this.Controls.Add(this.BTN_New_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Pass_Retriver);
            this.Name = "Forgot_Password";
            this.Text = "Forgot_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Pass_Retriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_New_Pass;
    }
}