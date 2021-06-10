using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instagramforce
{
    public partial class instagramProfileFollowers : Form
    {
        public instagramProfileFollowers()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            instagramHome feedApp = new instagramHome();
            this.Hide();
            feedApp.Visible = true;
        }
    }
}
