using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Music_Application_With_SQL
{
    public partial class Log_in : Form
    {
        Login Obj_Data = new Login();

        public Log_in()
        {
            InitializeComponent();
            TB_Captcha.Text = Obj_Data.GenerateCaptcha();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            TB_Captcha.Text = Obj_Data.GenerateCaptcha();
        }

        private void TB_Captcha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_LogIn_Click(object sender, EventArgs e)
        {
            bool val_Captcha = Obj_Data.ValidateCaptcha(TB_ValidateCaptcha.Text);
            if (val_Captcha = true)
            {
                MessageBox.Show("Logged in and Captcha Validated");
                new Music_Menu().Show();
            }
            else if (val_Captcha = false)
            {
                MessageBox.Show("Captcha Invalid, Try again");
            }
            else
            {
                MessageBox.Show("What are you doing mate, do it again");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
