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
    public partial class login : Form
    {
        string user = "";
        string password = "";
        public login()
        {
            InitializeComponent();
        }
            
        private void login_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Usuario";
            txtUser.ForeColor = Color.Gray;
            txtPass.PasswordChar = '\0';
            txtPass.Text = "Contraseña";
            txtPass.ForeColor = Color.Gray;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (user.Equals(""))
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
            else
            {
                txtUser.Text = user;
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            user = txtUser.Text;
            if (user.Equals("Usuario"))
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Gray;
            }
            else
            {
                if (user.Equals(""))
                {
                    txtUser.Text = "Usuario";
                    txtUser.ForeColor = Color.Gray;
                }
                else
                {
                    txtUser.Text = user;
                    txtUser.ForeColor = Color.Black;
                }
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {

            if (password.Equals(""))
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
            }
            else
            {
                txtPass.Text = password;
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            password = txtPass.Text;
            if (password.Equals("Contraseña"))
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Gray;
            }
            else
            {
                if (password.Equals(""))
                {
                    txtPass.PasswordChar = '\0';
                    txtPass.Text = "Contraseña";
                    txtPass.ForeColor = Color.Gray;
                }
                else
                {
                txtPass.PasswordChar = '*';
                txtPass.Text = password;
                txtPass.ForeColor = Color.Black;
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("user "+ user + " Contraseña "+ password);

            instagramHome feedApp = new instagramHome();
            this.Hide();
            feedApp.Visible = true;
            
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void newUserProfile_Click(object sender, EventArgs e)
        {
            instagramNewUser formRegister = new instagramNewUser();
            this.Hide();
            formRegister.Show();
        }
    }
}
