using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instagramforce
{
    public partial class instagramUserProfile : Form
    {
        public string Username;
        public instagramUserProfile()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                gunaPanel1.VerticalScroll.Value = e.NewValue;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            instagramHome feedApp = new instagramHome();
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            instagramEditProfile feedApp = new instagramEditProfile();
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {
            //Validar para que cargue la foto del usuario
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Assets\\imageDefaultProfile.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            imageUser.Image = Image.FromFile(FileName);
        }
    }
}
