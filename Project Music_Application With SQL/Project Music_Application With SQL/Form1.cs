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
    public partial class Sign_up : Form
    {
       

        public Sign_up()
        {
            InitializeComponent();
            

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CB_Privacy_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Privacy.Checked)
            {
                MessageBox.Show("Thank you for accepting");
            }
            else
            {
                MessageBox.Show("Please accept the Privacy Policy");
            }
        }

        public void TB_Captcha_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Register_Click(object sender, EventArgs e)
        {
            if (CB_Privacy.Checked)
            {
                new Log_in().Show();
            }
            else
            {
                MessageBox.Show("Please accept the Privacy Policy");
            }
        }
    }
}
