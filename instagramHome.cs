using instagramforce.Clases.Arbol_AVL;
using instagramforce.Clases.Usuarios;
using instagramforce.Clases.XML;
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
using System.Xml;

namespace instagramforce
{
    public partial class instagramHome : Form
    {
        string searchData = "";
        public int y = 72;
        public int x = 56;
        public int count = 0;

        public int panelFollowersY = 7;
        public int panelFollowersX = 16;
        public int countPanelFollowers = 0;

        public int panelFollowingsY = 7;
        public int panelFollowingsX = 16;
        public int countFollowings = 0;

        public int inicioCount = 0;
        public int finalCount;

        public List<string> myListFeed = new List<string>();
        public List<(string, string, string, string)> myPostListUsers = new List<(string, string, string, string)>();

        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

        public string Username;
        Xml_acciones xml_acciones = new Xml_acciones();
        ArbolAVL loginUsuarios = new ArbolAVL();
        public instagramHome()
        {
            InitializeComponent();
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileFollowerFollowing = string.Format("{0}Resources\\FollowerFollowingData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            string fileFeedData = string.Format("{0}Resources\\FeedData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            //FollowerFollowingData
            if (File.Exists(fileFollowerFollowing))
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(fileFollowerFollowing);
                XmlNodeList itemsNodes = xmldoc.SelectNodes("//FOLLOWINGFOLLOWERDATA//USER");
                foreach (XmlNode ItemNode in itemsNodes)
                {
                    string follower = string.Empty, following = string.Empty;

                    foreach (XmlNode item in ItemNode.SelectSingleNode("FOLLOWER"))
                    {
                        follower = item.InnerText;
                    }
                    foreach (XmlNode item in ItemNode.SelectSingleNode("FOLLOWING"))
                    {
                        following = item.InnerText;
                    }
                    Login_Usuario loginUsers = new Login_Usuario(follower, following);
                    loginUsuarios.insertar(loginUsers);
                }
            }
            else
            {
                xml_acciones.crearXml(fileFollowerFollowing, "FOLLOWINGFOLLOWERDATA");
            }

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

        private void instagramHome_Load(object sender, EventArgs e)
        {
            //Falta validar para que agarre la imagen que trae el usuario en el XML
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Assets\\imageDefaultProfile.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            photoUserProfile.Image = Image.FromFile(FileName);

            //Carga imagen con nombre de Instagram
            pictureBox1.Image = Image.FromFile("instagramLogin.jpg");

            leerXMLFollowerFollowingData();
        }
        public void leerXMLFollowerFollowingData()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\FollowerFollowingData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            if (File.Exists(FileName))
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(FileName);
                XmlNodeList itemsNodes = xmldoc.SelectNodes("//FOLLOWINGFOLLOWERDATA//USER");
                foreach (XmlNode ItemNode in itemsNodes)
                {
                    string FOLLOWER = string.Empty, FOLLOWING = string.Empty;

                    foreach (XmlNode item in ItemNode.SelectSingleNode("FOLLOWER"))
                    {
                        if (Username == item.InnerText)
                        {
                            FOLLOWER = item.InnerText;
                            foreach (XmlNode items in ItemNode.SelectSingleNode("FOLLOWING"))
                            {
                                FOLLOWING = items.InnerText;
                                myListFeed.Add(FOLLOWING);
                            }
                        }
                    }
                }
            }
            llerXmlFeedData(); 
        }
        public void leerXmlUserData()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\UserData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            if (File.Exists(FileName))
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(FileName);
                XmlNodeList itemsNodes = xmldoc.SelectNodes("//Posts//Post");
                XmlNode user;

                for (int a = 0; a < myListFeed.Count; a++)
                {
                    for (int i = 0; i < itemsNodes.Count; i++)
                    {
                        user = itemsNodes.Item(i);
                        string userNames = user.SelectSingleNode("USERNAME").InnerText;
                        if (userNames == myListFeed[a])
                        {
                            string imagePost = user.SelectSingleNode("IMAGEPOST").InnerText;
                            string dataPost = user.SelectSingleNode("DATAPOST").InnerText;
                            string datePost = user.SelectSingleNode("DATEPOST").InnerText;

                            myPostListUsers.Add((userNames, imagePost, dataPost, datePost));
                        }
                    }
                }

            }
        }
        public void llerXmlFeedData()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\FeedData.xml", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            if (File.Exists(FileName))
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(FileName);
                XmlNodeList itemsNodes = xmldoc.SelectNodes("//Posts//Post");
                XmlNode user;

                for (int a = 0; a < myListFeed.Count; a++)
                {
                    for (int i = 0; i < itemsNodes.Count; i++)
                    {
                        user = itemsNodes.Item(i);
                        string userNames = user.SelectSingleNode("USERNAME").InnerText;
                        if (userNames == myListFeed[a])
                        {
                            string imagePost = user.SelectSingleNode("IMAGEPOST").InnerText;
                            string dataPost = user.SelectSingleNode("DATAPOST").InnerText;
                            string datePost = user.SelectSingleNode("DATEPOST").InnerText;

                            myPostListUsers.Add((userNames, imagePost, dataPost, datePost));
                        }
                    }
                }
                
            }
            foreach (var list in myPostListUsers)
            {
                addNewPanelFeed(list.Item1, list.Item2, list.Item3, list.Item4);
            }
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
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;
        }
        public void addNewPanelFeed(string userName, string imagePost, string dataPost, string datePost)
        {
            Panel panel1 = new Panel();
            PictureBox pictureBoxPost = new PictureBox();
            PictureBox pictureUserBox = new PictureBox();
            Label nameUser = new Label();
            Label descriptionPost = new Label();

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}"+ imagePost+"", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            panel1.Size = new Size(506, 424);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            nameUser.Location = new Point(90, 358);
            nameUser.Text = userName;
            nameUser.Cursor = Cursors.Hand;
            nameUser.Size = new Size(400, 13);
            panel1.Controls.Add(nameUser);

            descriptionPost.Location = new Point(90, 380);
            descriptionPost.Text = dataPost;
            descriptionPost.Size = new Size(400, 13);
            panel1.Controls.Add(descriptionPost);

            pictureBoxPost.Location = new Point(26, 20);
            pictureBoxPost.BackColor = Color.Gray;
            pictureBoxPost.Image = Image.FromFile(FileName);
            pictureBoxPost.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPost.Size = new Size(450, 328);
            panel1.Controls.Add(pictureBoxPost);


            pictureUserBox.Location = new Point(26, 358);
            pictureUserBox.BackColor = Color.Gray;
            pictureUserBox.Size = new Size(50, 50);
            panel1.Controls.Add(pictureUserBox);

            panel1.Location = new Point(x, y);
            panelFeed.Controls.Add(panel1);

            y = (424 * count) + 72;
            count += 1;
        }
        public void addNewPanelFollowers(string pathImage, string nameFollower)
        {
            //Creacion de paneles para Seguidores
            Panel panelFollowers = new Panel();
            Guna.UI.WinForms.GunaCirclePictureBox pictureBoxFollowers = new Guna.UI.WinForms.GunaCirclePictureBox();
            
            Label nameFollowers= new Label();

            //creacion del panel
            panelFollowers.Size = new Size(234, 86);
            panelFollowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //Creacion del pictureBox
            pictureBoxFollowers.Location = new Point(14, 12);
            pictureBoxFollowers.BackColor = Color.Gray;
            pictureBoxFollowers.Size = new Size(70, 63);
            panelFollowers.Controls.Add(pictureBoxFollowers);

            //Creacion de la label
            nameFollowers.Location = new Point(89, 32);
            nameFollowers.Text = "PRUEBA USUARIO";
            nameFollowers.Cursor = Cursors.Hand;
            nameFollowers.Size = new Size(68, 15);
            panelFollowers.Controls.Add(nameFollowers);

            panelFollowers.Location = new Point(panelFollowersX, panelFollowersY);
            panelFollowersHome.Controls.Add(panelFollowers);

            panelFollowersY = (86 * countPanelFollowers) + 7;
            countPanelFollowers += 1;
        }
        public void addNewPanelFollowing(string pathImage, string nameFollowing)
        {
            Panel panelFollowers = new Panel();
            Guna.UI.WinForms.GunaCirclePictureBox pictureBoxFollowers = new Guna.UI.WinForms.GunaCirclePictureBox();
            
            Label nameFollowers= new Label();

            //creacion del panel
            panelFollowers.Size = new Size(234, 86);
            panelFollowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //Creacion del pictureBox
            pictureBoxFollowers.Location = new Point(14, 12);
            pictureBoxFollowers.BackColor = Color.Gray;
            pictureBoxFollowers.Size = new Size(70, 63);
            panelFollowers.Controls.Add(pictureBoxFollowers);

            //Creacion de la label
            nameFollowers.Location = new Point(89, 32);
            nameFollowers.Text = "PRUEBA USUARIO";
            nameFollowers.Cursor = Cursors.Hand;
            nameFollowers.Size = new Size(68, 15);
            panelFollowers.Controls.Add(nameFollowers);

            panelFollowers.Location = new Point(panelFollowingsX, panelFollowingsY);
            panelFollowing.Controls.Add(panelFollowers);

            panelFollowingsY = (86 * countFollowings) + 7;
            countFollowings += 1;
        }
        private void btnPublish_Click(object sender, EventArgs e)
        {
            instagramUserPost feedApp = new instagramUserPost();
            feedApp.Username = Username;
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

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            instagramSearch feedApp = new instagramSearch();
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;
        }
    }
}
