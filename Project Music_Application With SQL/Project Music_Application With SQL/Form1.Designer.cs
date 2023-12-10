namespace Project_Music_Application_With_SQL
{
    partial class Sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up));
            this.TB_Username1 = new System.Windows.Forms.TextBox();
            this.TB_Email1 = new System.Windows.Forms.TextBox();
            this.TB_Password1 = new System.Windows.Forms.TextBox();
            this.We = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Privacy = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTN_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Username1
            // 
            this.TB_Username1.Location = new System.Drawing.Point(12, 67);
            this.TB_Username1.Name = "TB_Username1";
            this.TB_Username1.Size = new System.Drawing.Size(100, 20);
            this.TB_Username1.TabIndex = 0;
            // 
            // TB_Email1
            // 
            this.TB_Email1.Location = new System.Drawing.Point(12, 118);
            this.TB_Email1.Name = "TB_Email1";
            this.TB_Email1.Size = new System.Drawing.Size(100, 20);
            this.TB_Email1.TabIndex = 1;
            this.TB_Email1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TB_Password1
            // 
            this.TB_Password1.Location = new System.Drawing.Point(12, 178);
            this.TB_Password1.Name = "TB_Password1";
            this.TB_Password1.PasswordChar = '*';
            this.TB_Password1.Size = new System.Drawing.Size(100, 20);
            this.TB_Password1.TabIndex = 2;
            // 
            // We
            // 
            this.We.AutoSize = true;
            this.We.Location = new System.Drawing.Point(13, 13);
            this.We.Name = "We";
            this.We.Size = new System.Drawing.Size(125, 13);
            this.We.TabIndex = 3;
            this.We.Text = "Hi There! Sign up to start";
            this.We.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Make a password:";
            // 
            // CB_Privacy
            // 
            this.CB_Privacy.AutoSize = true;
            this.CB_Privacy.Location = new System.Drawing.Point(157, 180);
            this.CB_Privacy.Name = "CB_Privacy";
            this.CB_Privacy.Size = new System.Drawing.Size(244, 17);
            this.CB_Privacy.TabIndex = 11;
            this.CB_Privacy.Text = "I agree to the Privacy Policy, and Register me!";
            this.CB_Privacy.UseVisualStyleBackColor = true;
            this.CB_Privacy.CheckedChanged += new System.EventHandler(this.CB_Privacy_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 84);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(266, 74);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // BTN_Register
            // 
            this.BTN_Register.Location = new System.Drawing.Point(195, 228);
            this.BTN_Register.Name = "BTN_Register";
            this.BTN_Register.Size = new System.Drawing.Size(161, 60);
            this.BTN_Register.TabIndex = 13;
            this.BTN_Register.Text = "Register";
            this.BTN_Register.UseVisualStyleBackColor = true;
            this.BTN_Register.Click += new System.EventHandler(this.BTN_Register_Click);
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 300);
            this.Controls.Add(this.BTN_Register);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CB_Privacy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.We);
            this.Controls.Add(this.TB_Password1);
            this.Controls.Add(this.TB_Email1);
            this.Controls.Add(this.TB_Username1);
            this.Name = "Sign_up";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Username1;
        private System.Windows.Forms.TextBox TB_Email1;
        private System.Windows.Forms.TextBox TB_Password1;
        private System.Windows.Forms.Label We;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CB_Privacy;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTN_Register;
    }
}

