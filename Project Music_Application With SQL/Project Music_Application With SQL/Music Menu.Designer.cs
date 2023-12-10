namespace Project_Music_Application_With_SQL
{
    partial class Music_Menu
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
            this.BTN_Player = new System.Windows.Forms.Button();
            this.BTN_Playlist_osts = new System.Windows.Forms.Button();
            this.BTN_Total_Songs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTN_Playlist_Chill = new System.Windows.Forms.Button();
            this.BTN_Playlist_Rap = new System.Windows.Forms.Button();
            this.BTN_Delete1 = new System.Windows.Forms.Button();
            this.BTN_Delete2 = new System.Windows.Forms.Button();
            this.BTN_Delete3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muzio Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_Player
            // 
            this.BTN_Player.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Headphones;
            this.BTN_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Player.Location = new System.Drawing.Point(16, 77);
            this.BTN_Player.Name = "BTN_Player";
            this.BTN_Player.Size = new System.Drawing.Size(135, 96);
            this.BTN_Player.TabIndex = 1;
            this.BTN_Player.Text = "Playing now";
            this.BTN_Player.UseVisualStyleBackColor = true;
            this.BTN_Player.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Playlist_osts
            // 
            this.BTN_Playlist_osts.Location = new System.Drawing.Point(93, 193);
            this.BTN_Playlist_osts.Name = "BTN_Playlist_osts";
            this.BTN_Playlist_osts.Size = new System.Drawing.Size(149, 37);
            this.BTN_Playlist_osts.TabIndex = 3;
            this.BTN_Playlist_osts.Text = "Playlist: Game OSTs";
            this.BTN_Playlist_osts.UseVisualStyleBackColor = true;
            // 
            // BTN_Total_Songs
            // 
            this.BTN_Total_Songs.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Headphones;
            this.BTN_Total_Songs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Total_Songs.Location = new System.Drawing.Point(187, 77);
            this.BTN_Total_Songs.Name = "BTN_Total_Songs";
            this.BTN_Total_Songs.Size = new System.Drawing.Size(135, 96);
            this.BTN_Total_Songs.TabIndex = 5;
            this.BTN_Total_Songs.Text = "Total Songs:";
            this.BTN_Total_Songs.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Crysis_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Dude_that_Rap;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(16, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 37);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Chill;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(16, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 37);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // BTN_Playlist_Chill
            // 
            this.BTN_Playlist_Chill.Location = new System.Drawing.Point(93, 319);
            this.BTN_Playlist_Chill.Name = "BTN_Playlist_Chill";
            this.BTN_Playlist_Chill.Size = new System.Drawing.Size(149, 37);
            this.BTN_Playlist_Chill.TabIndex = 9;
            this.BTN_Playlist_Chill.Text = "Playlist: Chill Songs";
            this.BTN_Playlist_Chill.UseVisualStyleBackColor = true;
            // 
            // BTN_Playlist_Rap
            // 
            this.BTN_Playlist_Rap.Location = new System.Drawing.Point(93, 258);
            this.BTN_Playlist_Rap.Name = "BTN_Playlist_Rap";
            this.BTN_Playlist_Rap.Size = new System.Drawing.Size(149, 37);
            this.BTN_Playlist_Rap.TabIndex = 10;
            this.BTN_Playlist_Rap.Text = "Playlist: Rap Songs";
            this.BTN_Playlist_Rap.UseVisualStyleBackColor = true;
            // 
            // BTN_Delete1
            // 
            this.BTN_Delete1.Location = new System.Drawing.Point(266, 193);
            this.BTN_Delete1.Name = "BTN_Delete1";
            this.BTN_Delete1.Size = new System.Drawing.Size(56, 37);
            this.BTN_Delete1.TabIndex = 11;
            this.BTN_Delete1.Text = "Delete Playlist?";
            this.BTN_Delete1.UseVisualStyleBackColor = true;
            // 
            // BTN_Delete2
            // 
            this.BTN_Delete2.Location = new System.Drawing.Point(266, 258);
            this.BTN_Delete2.Name = "BTN_Delete2";
            this.BTN_Delete2.Size = new System.Drawing.Size(56, 37);
            this.BTN_Delete2.TabIndex = 12;
            this.BTN_Delete2.Text = "Delete Playlist?";
            this.BTN_Delete2.UseVisualStyleBackColor = true;
            // 
            // BTN_Delete3
            // 
            this.BTN_Delete3.Location = new System.Drawing.Point(266, 319);
            this.BTN_Delete3.Name = "BTN_Delete3";
            this.BTN_Delete3.Size = new System.Drawing.Size(56, 37);
            this.BTN_Delete3.TabIndex = 13;
            this.BTN_Delete3.Text = "Delete Playlist?";
            this.BTN_Delete3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "1324";
            // 
            // Music_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Music_Application_With_SQL.Properties.Resources.Silloehettes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Delete3);
            this.Controls.Add(this.BTN_Delete2);
            this.Controls.Add(this.BTN_Delete1);
            this.Controls.Add(this.BTN_Playlist_Rap);
            this.Controls.Add(this.BTN_Playlist_Chill);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Total_Songs);
            this.Controls.Add(this.BTN_Playlist_osts);
            this.Controls.Add(this.BTN_Player);
            this.Controls.Add(this.label1);
            this.Name = "Music_Menu";
            this.Text = "Music_Menu";
            this.Load += new System.EventHandler(this.Music_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Player;
        private System.Windows.Forms.Button BTN_Playlist_osts;
        private System.Windows.Forms.Button BTN_Total_Songs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTN_Playlist_Chill;
        private System.Windows.Forms.Button BTN_Playlist_Rap;
        private System.Windows.Forms.Button BTN_Delete1;
        private System.Windows.Forms.Button BTN_Delete2;
        private System.Windows.Forms.Button BTN_Delete3;
        private System.Windows.Forms.Label label2;
    }
}