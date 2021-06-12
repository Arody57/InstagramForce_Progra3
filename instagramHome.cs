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
using instagramforce.Clases.Acciones;
using System.Xml;

namespace instagramforce
{
    public partial class instagramHome : Form
    {
        public string Username;
        public string fullNameUser;
        public string photoUserName;
        public string userBirthDate;
        public string followersUser;
        public string followingUser;
        public string postUser;

        string searchData = "";
        public int y = 72;
        public int x = 56;
        public int count = 1;

        public int panelFollowersY = 7;
        public int panelFollowersX = 16;
        public int countPanelFollowers = 1;

        public int panelFollowingsY = 7;
        public int panelFollowingsX = 16;
        public int countFollowings = 1;

        public List<string> myListFeed = new List<string>();
        public List<(string, string, string, string)> myUsersFeed = new List<(string, string, string, string)>();
        public List<(string, string)> myUsersFeed1 = new List<(string, string)>();
        public List<string> myPreliminarList= new List<string>();
        public List<( string, string, string,string)> myPostListUsers = new List<(string, string, string, string)>();

        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

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
            //Carga imagen con nombre de Instagram
            pictureBox1.Image = Image.FromFile("instagramLogin.jpg");
            leerXMLUserData();
            leerXMLFollowerFollowingData();
        }
        public void leerXMLUserData()
        {
            string RunningPaths = AppDomain.CurrentDomain.BaseDirectory;
            string FileNames = string.Format("{0}Resources\\userData.xml", Path.GetFullPath(Path.Combine(RunningPaths, @"..\..\")));
            XmlDocument xmldocs = new XmlDocument();
            xmldocs.Load(FileNames);
            XmlNodeList itemsNodes = xmldocs.SelectNodes("//Usuarios//Usuario");
            foreach (XmlNode ItemNode in itemsNodes)
            {
                string USERNAME = string.Empty, PATHIMAGE = string.Empty, FULLNAME = string.Empty, BIRTHDATE = string.Empty;
                foreach (XmlNode item in ItemNode.SelectSingleNode("USERNAME"))
                {
                   USERNAME = item.InnerText;
                   foreach (XmlNode items in ItemNode.SelectSingleNode("PROFILEIMAGE"))
                   {
                        PATHIMAGE = items.InnerText;
                    }
                    foreach (XmlNode a in ItemNode.SelectSingleNode("FULLNAME"))
                    {
                        FULLNAME = a.InnerText;
                    }                    
                    foreach (XmlNode birth in ItemNode.SelectSingleNode("BIRTHDATE"))
                    {
                        BIRTHDATE = birth.InnerText;
                        if (Username == item.InnerText)
                        {
                            myUsersFeed.Add((USERNAME, PATHIMAGE, FULLNAME, BIRTHDATE));
                        }
                        myUsersFeed1.Add((USERNAME, PATHIMAGE));
                    }
                }
            }
            if (myUsersFeed.Count !=0)
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string FileName = string.Format("{0}" + myUsersFeed[0].Item2 + "", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                photoUserProfile.Image = Image.FromFile(FileName);
                Username = myUsersFeed[0].Item1;
                fullNameUser = myUsersFeed[0].Item3;
                photoUserName = myUsersFeed[0].Item2;
                userBirthDate = myUsersFeed[0].Item4;
            }
            else
            {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string FileName = string.Format("{0}Assets\\imageDefaultProfile.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                photoUserProfile.Image = Image.FromFile(FileName);
            }


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
                            myPreliminarList.Add((FOLLOWING));
                            }
                        }
                    }
                }
            }
            myPreliminarList.Add(Username);
            llerXmlFeedData();

            lblFollowerrss.Text = Convert.ToString(myPreliminarList.Count);
            followersUser = Convert.ToString(myPreliminarList.Count);
            foreach (var lists in myUsersFeed1)
            {
                foreach (var items in myPreliminarList)
                {
                    if (lists.Item1 == items)
                    {
                        addNewPanelFollowers(lists.Item1, lists.Item2);
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

                for (int a = 0; a < myPreliminarList.Count; a++)
                {
                    for (int i = 0; i < itemsNodes.Count; i++)
                    {
                        user = itemsNodes.Item(i);
                        string userNames = user.SelectSingleNode("USERNAME").InnerText;
                        if (userNames == myPreliminarList[a])
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
                foreach (var a in myUsersFeed1)
                {
                    if (list.Item1 == a.Item1)
                    {
                    addNewPanelFeeds(list.Item1,list.Item2, list.Item3, list.Item4, a.Item2);
                    }
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            instagramUserProfile feedApp = new instagramUserProfile();
            feedApp.Username = Username;
            feedApp.fullNameUser = fullNameUser;
            feedApp.photoUserName = photoUserName;
            feedApp.userBirthDate = userBirthDate;
            feedApp.followersUser = followersUser;
            feedApp.followingUser= followingUser;
            feedApp.postUser= postUser;
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
        public void addNewPanelFeeds(string userName, string imagePost, string dataPost, string datePost, string imageUserPost)
        {
            drawingGeneralPanel panels = new drawingGeneralPanel();
            panels.Username= Username;
            Panel panelComponentes = panels.addNewPanelFeed( userName,  imagePost,  dataPost,  datePost,  imageUserPost,  x,  y);
            panelFeed.Controls.Add(panelComponentes);
            y = (424 * count) + 72;
            count += 1;
        }
        public void addNewPanelFollowers(string nameFollower, string pathImage)
        {
            if(nameFollower != Username)
            {

            
                //Creacion de paneles para Seguidores
                Panel panelFollowers = new Panel();
                Guna.UI.WinForms.GunaCirclePictureBox pictureBoxFollowers = new Guna.UI.WinForms.GunaCirclePictureBox();
            
                Label nameFollowers= new Label();
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string FilePhoto = string.Format("{0}" + pathImage + "", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                //creacion del panel
                panelFollowers.Size = new Size(234, 86);
                panelFollowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                //Creacion del pictureBox
                pictureBoxFollowers.Location = new Point(14, 12);
                pictureBoxFollowers.Image = Image.FromFile(FilePhoto);
                pictureBoxFollowers.Size = new Size(70, 63);
                panelFollowers.Controls.Add(pictureBoxFollowers);

                //Creacion de la label
                nameFollowers.Location = new Point(89, 32);
                nameFollowers.Text = nameFollower;
                nameFollowers.Cursor = Cursors.Hand;
                nameFollowers.Click += new EventHandler(lblEvent_Click);
                nameFollowers.Size = new Size(68, 15);
                panelFollowers.Controls.Add(nameFollowers);

                panelFollowers.Location = new Point(panelFollowersX, panelFollowersY);
                panelFollowersHome.Controls.Add(panelFollowers);

                panelFollowersY = (86 * countPanelFollowers) + 7;
                countPanelFollowers += 1;
            }
        }

        private void lblEvent_Click(object sender, EventArgs e)
        {
            Label lblUsers = (Label)sender;
            string user = lblUsers.Text;
            instagramProfileFollowers feedAp = new instagramProfileFollowers();
            feedAp.Username = Username;
            feedAp.perfilUser = user;
            feedAp.fullNameUser = fullNameUser;
            feedAp.photoUserName = photoUserName;
            feedAp.userBirthDate = userBirthDate;
            feedAp.followersUser = followersUser;
            feedAp.followingUser = followingUser;
            feedAp.postUser = postUser;
            feedAp.Visible = true;
            this.Hide();
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
            feedApp.Username = Username;
            feedApp.fullNameUser = fullNameUser;
            feedApp.photoUserName = photoUserName;
            feedApp.userBirthDate = userBirthDate;
            feedApp.followersUser = followersUser;
            feedApp.followingUser = followingUser;
            feedApp.postUser = postUser;
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

        private void bttSearch_Click(object sender, EventArgs e)
        {
            instagramSearch feedApp = new instagramSearch();
            feedApp.Username = Username;
            this.Hide();
            feedApp.Visible = true;
        }
    }
}
