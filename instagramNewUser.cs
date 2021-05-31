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
    public partial class instagramNewUser : Form
    {
        string nickNameUser = "";
        string nameRealUser = "";
        string passwordUser = "";
        string dateOfBirthUser = "";
        string pathImagenProfileUser = "";
        public instagramNewUser()
        {
            InitializeComponent();
        }
        private void instagramNewUser_Load(object sender, EventArgs e)
        {
            txtNickNameUser.Text = "Nombre de usuario";
            txtNickNameUser.ForeColor = Color.Gray;
            txtNameUser.Text = "Nombre completo";
            txtNameUser.ForeColor = Color.Gray;
            txtPasswordUser.PasswordChar = '\0';
            txtPasswordUser.Text = "Contraseña";
            txtPasswordUser.ForeColor = Color.Gray;
            gunaPictureBox1.Image = Image.FromFile("instagramLogin.jpg");
        }

        private void txtNickNameUser_Enter(object sender, EventArgs e)
        {
            nickNameUser = txtNickNameUser.Text;
            if (txtNickNameUser.Text.Equals("") || txtNickNameUser.Text == "Nombre de usuario")
            {
                txtNickNameUser.Text = "";
                txtNickNameUser.ForeColor = Color.Black;
            }
            else
            {
                txtNickNameUser.ForeColor = Color.Black;
            }
        }

        private void txtNameUser_Enter(object sender, EventArgs e)
        {
            nameRealUser = txtNameUser.Text;
            if (txtNameUser.Text.Equals("") || txtNameUser.Text == "Nombre completo")
            {
                txtNameUser.Text = "";
                txtNameUser.ForeColor = Color.Black;
            }
            else
            {
                txtNameUser.ForeColor = Color.Black;
            }
        }
        private void txtPasswordUser_Enter(object sender, EventArgs e)
        {
            passwordUser = txtPasswordUser.Text;
            if (txtPasswordUser.Text.Equals("") || txtPasswordUser.Text == "Contraseña")
            {
                txtPasswordUser.Text = "";
                txtPasswordUser.ForeColor = Color.Black;
                txtPasswordUser.PasswordChar = '*';
            }
            else
            {
                txtPasswordUser.ForeColor = Color.Black;
            }
        }


        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            if (image.ShowDialog() == DialogResult.OK)
            {
                photoProfileUser.Image = Image.FromFile(image.FileName);
                pathImagenProfileUser = image.FileName;
                photoProfileUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void loginExistAccount_Click(object sender, EventArgs e)
        {
            login formLogin = new login();
            this.Hide();
            formLogin.Show();
        }

        private void btnRegistrarCuenta_Click(object sender, EventArgs e)
        {
            nickNameUser = txtNickNameUser.Text;
            nameRealUser =  txtNameUser.Text;
            passwordUser = txtPasswordUser.Text;
            dateOfBirthUser = gunaDateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (pathImagenProfileUser.Equals(""))
            {
                pathImagenProfileUser = "imageDefaultProfile.png";
            }

           MessageBox.Show("Bienvenido: " + nickNameUser);
            instagramHome fHome = new instagramHome();
            this.Hide();
            fHome.Show();
        }

        private void txtNameUser_Validating(object sender, CancelEventArgs e)
        {
            if(txtNameUser.Text.Equals("Nombre completo") || string.IsNullOrEmpty(txtNameUser.Text))
            {
                e.Cancel = true;
                txtNameUser.Focus();
                errorProvider.SetError(txtNameUser, "Ingrese Nombre completo");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNameUser, null);
            }
        }

        private void txtNickNameUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtNickNameUser.Text.Equals("Nombre de usuario") || string.IsNullOrEmpty(txtNickNameUser.Text))
            {
                e.Cancel = true;
                txtNameUser.Focus();
                errorProvider.SetError(txtNickNameUser, "Ingrese Nombre de usuario");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNickNameUser, null);
            }
        }

        private void txtPasswordUser_Validating(object sender, CancelEventArgs e)
        {
            if(txtPasswordUser.Text.Equals("Contraseña")|| string.IsNullOrEmpty(txtPasswordUser.Text))
            {
                e.Cancel = true;
                txtPasswordUser.Focus();
                errorProvider.SetError(txtPasswordUser, "Ingrese contraseña");
            }
            else
            {
                e.Cancel = false;
                btnRegistrarCuenta.Enabled = true;
                errorProvider.SetError(txtPasswordUser, null);
            }
        }
    }
}
