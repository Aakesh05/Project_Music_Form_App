namespace Project_Music_Application_With_SQL
{
    partial class Music_Player
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
            this.BTN_MP_Back = new System.Windows.Forms.Button();
            this.BTN_Settings = new System.Windows.Forms.Button();
            this.BTN_Fave = new System.Windows.Forms.Button();
            this.BTN_Play_Pause = new System.Windows.Forms.Button();
            this.BTN_Previous = new System.Windows.Forms.Button();
            this.BTN_Next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_MP_Back
            // 
            this.BTN_MP_Back.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Pink_Overlay_shapes;
            this.BTN_MP_Back.Location = new System.Drawing.Point(12, 12);
            this.BTN_MP_Back.Name = "BTN_MP_Back";
            this.BTN_MP_Back.Size = new System.Drawing.Size(75, 62);
            this.BTN_MP_Back.TabIndex = 0;
            this.BTN_MP_Back.Text = "Back to Home";
            this.BTN_MP_Back.UseVisualStyleBackColor = true;
            this.BTN_MP_Back.Click += new System.EventHandler(this.BTN_MP_Back_Click);
            // 
            // BTN_Settings
            // 
            this.BTN_Settings.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Pink_Overlay_shapes;
            this.BTN_Settings.Location = new System.Drawing.Point(230, 12);
            this.BTN_Settings.Name = "BTN_Settings";
            this.BTN_Settings.Size = new System.Drawing.Size(75, 63);
            this.BTN_Settings.TabIndex = 1;
            this.BTN_Settings.Text = "Settings";
            this.BTN_Settings.UseVisualStyleBackColor = true;
            // 
            // BTN_Fave
            // 
            this.BTN_Fave.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Heart;
            this.BTN_Fave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Fave.Location = new System.Drawing.Point(132, 35);
            this.BTN_Fave.Name = "BTN_Fave";
            this.BTN_Fave.Size = new System.Drawing.Size(51, 40);
            this.BTN_Fave.TabIndex = 2;
            this.BTN_Fave.Text = "Fave";
            this.BTN_Fave.UseVisualStyleBackColor = true;
            // 
            // BTN_Play_Pause
            // 
            this.BTN_Play_Pause.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Happy_LED_Skull;
            this.BTN_Play_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Play_Pause.Image = global::Project_Music_Application_With_SQL.Properties.Resources.Happy_LED_Skull;
            this.BTN_Play_Pause.Location = new System.Drawing.Point(123, 332);
            this.BTN_Play_Pause.Name = "BTN_Play_Pause";
            this.BTN_Play_Pause.Size = new System.Drawing.Size(73, 54);
            this.BTN_Play_Pause.TabIndex = 3;
            this.BTN_Play_Pause.Text = "Play/Pause";
            this.BTN_Play_Pause.UseVisualStyleBackColor = true;
            // 
            // BTN_Previous
            // 
            this.BTN_Previous.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Rainbow_Spiral;
            this.BTN_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Previous.Location = new System.Drawing.Point(12, 360);
            this.BTN_Previous.Name = "BTN_Previous";
            this.BTN_Previous.Size = new System.Drawing.Size(76, 53);
            this.BTN_Previous.TabIndex = 4;
            this.BTN_Previous.Text = "Previous song";
            this.BTN_Previous.UseVisualStyleBackColor = true;
            // 
            // BTN_Next
            // 
            this.BTN_Next.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Rainbow_Spiral;
            this.BTN_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Next.Location = new System.Drawing.Point(230, 360);
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.Size = new System.Drawing.Size(75, 53);
            this.BTN_Next.TabIndex = 5;
            this.BTN_Next.Text = "Next Song";
            this.BTN_Next.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Project_Music_Application_With_SQL.Properties.Resources.Polo_G_Gang_Gang;
            this.pictureBox1.Location = new System.Drawing.Point(74, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 288);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(293, 20);
            this.progressBar2.TabIndex = 8;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "GANG GANG - Polo G";
            // 
            // Music_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Sunset_Sillouhette;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Next);
            this.Controls.Add(this.BTN_Previous);
            this.Controls.Add(this.BTN_Play_Pause);
            this.Controls.Add(this.BTN_Fave);
            this.Controls.Add(this.BTN_Settings);
            this.Controls.Add(this.BTN_MP_Back);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Music_Player";
            this.Text = "Music_Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_MP_Back;
        private System.Windows.Forms.Button BTN_Settings;
        private System.Windows.Forms.Button BTN_Fave;
        private System.Windows.Forms.Button BTN_Play_Pause;
        private System.Windows.Forms.Button BTN_Previous;
        private System.Windows.Forms.Button BTN_Next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
    }
}