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
    public partial class Music_Menu : Form
    {
        public Music_Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Music_Player().Show();
        }

        private void Music_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
