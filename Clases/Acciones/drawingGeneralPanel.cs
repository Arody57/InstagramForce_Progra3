using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instagramforce.Clases.Acciones
{
    class drawingGeneralPanel
    {
        public  Panel addNewPanelFeed(string userName, string imagePost, string dataPost, string datePost, string imageUserPost, int x, int y)
        {
            Panel panel1 = new Panel();
            PictureBox pictureBoxPost = new PictureBox();
            PictureBox pictureUserBox = new PictureBox();
            Label nameUser = new Label();
            Label descriptionPost = new Label();

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}" + imagePost + "", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            string FileNameUser = string.Format("{0}" + imageUserPost + "", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

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
            pictureUserBox.Image = Image.FromFile(FileNameUser);
            pictureUserBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUserBox.Size = new Size(50, 50);
            panel1.Controls.Add(pictureUserBox);

            panel1.Location = new Point(x, y);
            return panel1;
        }
    }
}
