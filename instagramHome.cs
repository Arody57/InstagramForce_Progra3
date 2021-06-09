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
        public int y = 72;
        public int x = 56;

        public int picturePostY = 26;
        public int picturePostX = 57;

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
        public void addNewPanelFeed(bool flag)
        {
            
            Panel panel1 = new Panel();
            PictureBox pictureBoxPost = new PictureBox();
            PictureBox pictureUserBox = new PictureBox();
            Label nameUser = new Label();
            Label descriptionPost = new Label();

            panel1.Size = new Size(506, 424);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            nameUser.Location = new Point(90, 358);
            nameUser.Text = "usuario publicacionsadfasdfasdfasdfasdf";
            nameUser.Size = new Size(400, 13);
            panel1.Controls.Add(nameUser);

            descriptionPost.Location = new Point(90,380);
            descriptionPost.Text = "Prueba de descripcin de publicacinasdfasdfasdfasdfasdf";
            descriptionPost.Size = new Size(400, 13);
            panel1.Controls.Add(descriptionPost);

            pictureBoxPost.Location = new Point(26, 20);
            pictureBoxPost.BackColor = Color.Gray;
            pictureBoxPost.Size = new Size(450,328);
            panel1.Controls.Add(pictureBoxPost);


            pictureUserBox.Location = new Point(26, 358);
            pictureUserBox.BackColor = Color.Gray;
            pictureUserBox.Size = new Size(50, 50);
            panel1.Controls.Add(pictureUserBox);

            panel1.Location = new Point(x, y);
            panelFeed.Controls.Add(panel1);

            y =(424 * count) + 72;
            count += 1;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            for (int i =0; i <= 10; i++)
            {
            addNewPanelFeed(true);
            }
        }
        private void btnPublish_Click(object sender, EventArgs e)
        {
            instagramUserPost feedApp = new instagramUserPost();
            this.Hide();
            feedApp.Visible = true;
        }

        private void lblNoPost_Click(object sender, EventArgs e)
        {
            instagramUserProfile feedApp = new instagramUserProfile();
            this.Hide();
            feedApp.Visible = true;
        }

        private void lblFollowers_Click(object sender, EventArgs e)
        {
            instagramUserFollowers feedApp = new instagramUserFollowers();
            this.Hide();
            feedApp.Visible = true;
        }

        private void lblfollowed_Click(object sender, EventArgs e)
        {
            instagramUserFollowing feedApp = new instagramUserFollowing();
            this.Hide();
            feedApp.Visible = true;
        }

        private void lblSeguidos_Click(object sender, EventArgs e)
        {
            instagramUserFollowing feedApp = new instagramUserFollowing();
            this.Hide();
            feedApp.Visible = true;
        }

        private void lblSeguidores_Click(object sender, EventArgs e)
        {
            instagramUserFollowers feedApp = new instagramUserFollowers();
            this.Hide();
            feedApp.Visible = true;
        }
    }
}
