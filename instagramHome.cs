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
    public partial class instagramHome : Form
    {
        string searchData = "";
        public int y;
        public int x = 79;
        public int count = 0;
        public string Username;
        public instagramHome()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {

            if (searchData.Equals(""))
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
            else
            {
                gunaTextBox1.Text = searchData;
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {
            gunaTextBox1.Text = "Busca";
            gunaTextBox1.ForeColor = Color.Gray;
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            searchData = gunaTextBox1.Text;
            if (searchData.Equals("Busca"))
            {
                gunaTextBox1.Text = "Busca";
                gunaTextBox1.ForeColor = Color.Gray;
            }
            else
            {
                if (searchData.Equals(""))
                {
                    gunaTextBox1.Text = "Busca";
                    gunaTextBox1.ForeColor = Color.Gray;
                }
                else
                {
                    gunaTextBox1.Text = searchData;
                    gunaTextBox1.ForeColor = Color.Black;
                }
            }
        }

        private void panelFeed_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFeed_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                panelFeed.VerticalScroll.Value = e.NewValue;
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            //OpenFileDialog abrir = new OpenFileDialog();
            //if (abrir.ShowDialog() == DialogResult.OK)
            //{
            //    photoUserProfile.Image = Image.FromFile(abrir.FileName);
            //    photoUserProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
        }

        private void instagramHome_Load(object sender, EventArgs e)
        {
            //Falta validar para que agarre la imagen que trae el usuario en el XML
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Assets\\imageDefaultProfile.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            photoUserProfile.Image = Image.FromFile(FileName);

            //Carga imagen con nombre de Instagram
            pictureBox1.Image = Image.FromFile("instagramLogin.jpg");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            instagramUserProfile feedApp = new instagramUserProfile();
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            instagramHome feedApp = new instagramHome();
            this.Hide();
            feedApp.Visible = true;
        }
        public void addNewPanelFeed()
        {
            const int d = 426;
            Guna.UI.WinForms.GunaPanel panelFeedData = new Guna.UI.WinForms.GunaPanel();
            panelFeedData.Top = 80;
            panelFeedData.Height = 424;
            panelFeedData.Width = 506;
            panelFeedData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; 
            panelFeedData.Location = new Point(x, y);
            panelFeedData.BackColor = Color.Black;
            count += 1;

            y = count == 1 ? ((426 * 2) - y) : ((426 * count) - y);
            //y = ((426 * count) - y);

            panelFeed.Controls.Add(panelFeedData);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            for (int i =0; i <= 100; i++)
            {
            addNewPanelFeed();
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            addNewPanelFeed();
        }
    }
}
