
namespace instagramforce
{
    partial class instagramNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.txtPasswordUser = new Guna.UI.WinForms.GunaTextBox();
            this.txtNickNameUser = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnRegistrarCuenta = new Guna.UI.WinForms.GunaButton();
            this.btnBuscarImagen = new Guna.UI.WinForms.GunaButton();
            this.photoProfileUser = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txtNameUser = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.loginExistAccount = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoProfileUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.txtPasswordUser);
            this.gunaPanel1.Controls.Add(this.txtNickNameUser);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaDateTimePicker1);
            this.gunaPanel1.Controls.Add(this.btnRegistrarCuenta);
            this.gunaPanel1.Controls.Add(this.btnBuscarImagen);
            this.gunaPanel1.Controls.Add(this.photoProfileUser);
            this.gunaPanel1.Controls.Add(this.txtNameUser);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(278, 49);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(439, 573);
            this.gunaPanel1.TabIndex = 0;
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.BaseColor = System.Drawing.Color.White;
            this.txtPasswordUser.BorderColor = System.Drawing.Color.Silver;
            this.txtPasswordUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPasswordUser.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.txtPasswordUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordUser.Location = new System.Drawing.Point(94, 255);
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.PasswordChar = '\0';
            this.txtPasswordUser.Size = new System.Drawing.Size(250, 30);
            this.txtPasswordUser.TabIndex = 12;
            this.txtPasswordUser.Enter += new System.EventHandler(this.txtPasswordUser_Enter);
            this.txtPasswordUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordUser_Validating);
            // 
            // txtNickNameUser
            // 
            this.txtNickNameUser.BaseColor = System.Drawing.Color.White;
            this.txtNickNameUser.BorderColor = System.Drawing.Color.Silver;
            this.txtNickNameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNickNameUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNickNameUser.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.txtNickNameUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNickNameUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNickNameUser.Location = new System.Drawing.Point(94, 210);
            this.txtNickNameUser.Name = "txtNickNameUser";
            this.txtNickNameUser.PasswordChar = '\0';
            this.txtNickNameUser.Size = new System.Drawing.Size(250, 30);
            this.txtNickNameUser.TabIndex = 11;
            this.txtNickNameUser.Enter += new System.EventHandler(this.txtNickNameUser_Enter);
            this.txtNickNameUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtNickNameUser_Validating);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(94, 298);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(124, 13);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "Fecha de nacimiento";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(94, 317);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(250, 30);
            this.gunaDateTimePicker1.TabIndex = 9;
            this.gunaDateTimePicker1.Text = "domingo, 23 de mayo de 2021";
            this.gunaDateTimePicker1.Value = new System.DateTime(2021, 5, 23, 11, 53, 53, 561);
            // 
            // btnRegistrarCuenta
            // 
            this.btnRegistrarCuenta.AnimationHoverSpeed = 0.07F;
            this.btnRegistrarCuenta.AnimationSpeed = 0.03F;
            this.btnRegistrarCuenta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(233)))));
            this.btnRegistrarCuenta.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarCuenta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrarCuenta.Enabled = false;
            this.btnRegistrarCuenta.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrarCuenta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCuenta.Image = null;
            this.btnRegistrarCuenta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrarCuenta.Location = new System.Drawing.Point(94, 520);
            this.btnRegistrarCuenta.Name = "btnRegistrarCuenta";
            this.btnRegistrarCuenta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnRegistrarCuenta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrarCuenta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrarCuenta.OnHoverImage = null;
            this.btnRegistrarCuenta.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrarCuenta.Size = new System.Drawing.Size(250, 35);
            this.btnRegistrarCuenta.TabIndex = 8;
            this.btnRegistrarCuenta.Text = "Registrarte";
            this.btnRegistrarCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrarCuenta.Click += new System.EventHandler(this.btnRegistrarCuenta_Click);
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.AnimationHoverSpeed = 0.07F;
            this.btnBuscarImagen.AnimationSpeed = 0.03F;
            this.btnBuscarImagen.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(233)))));
            this.btnBuscarImagen.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarImagen.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarImagen.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnBuscarImagen.ForeColor = System.Drawing.Color.White;
            this.btnBuscarImagen.Image = null;
            this.btnBuscarImagen.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarImagen.Location = new System.Drawing.Point(94, 353);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnBuscarImagen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarImagen.OnHoverImage = null;
            this.btnBuscarImagen.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.Size = new System.Drawing.Size(108, 25);
            this.btnBuscarImagen.TabIndex = 6;
            this.btnBuscarImagen.Text = "Buscar Imagen";
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // photoProfileUser
            // 
            this.photoProfileUser.BaseColor = System.Drawing.Color.White;
            this.photoProfileUser.Location = new System.Drawing.Point(151, 384);
            this.photoProfileUser.Name = "photoProfileUser";
            this.photoProfileUser.Size = new System.Drawing.Size(133, 117);
            this.photoProfileUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoProfileUser.TabIndex = 5;
            this.photoProfileUser.TabStop = false;
            this.photoProfileUser.UseTransfarantBackground = false;
            // 
            // txtNameUser
            // 
            this.txtNameUser.BaseColor = System.Drawing.Color.White;
            this.txtNameUser.BorderColor = System.Drawing.Color.Silver;
            this.txtNameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNameUser.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.txtNameUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNameUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUser.Location = new System.Drawing.Point(94, 165);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.PasswordChar = '\0';
            this.txtNameUser.Size = new System.Drawing.Size(250, 30);
            this.txtNameUser.TabIndex = 3;
            this.txtNameUser.Enter += new System.EventHandler(this.txtNameUser_Enter);
            this.txtNameUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameUser_Validating);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(38, 125);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(376, 18);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Regístrate para ver fotos y vídeos de tus amigos.";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(111, 31);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(222, 76);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.loginExistAccount);
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Location = new System.Drawing.Point(278, 639);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(439, 65);
            this.gunaPanel2.TabIndex = 1;
            // 
            // loginExistAccount
            // 
            this.loginExistAccount.AutoSize = true;
            this.loginExistAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginExistAccount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginExistAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(246)))));
            this.loginExistAccount.Location = new System.Drawing.Point(272, 27);
            this.loginExistAccount.Name = "loginExistAccount";
            this.loginExistAccount.Size = new System.Drawing.Size(48, 14);
            this.loginExistAccount.TabIndex = 3;
            this.loginExistAccount.Text = "Entrar";
            this.loginExistAccount.Click += new System.EventHandler(this.loginExistAccount_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Verdana", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(119, 27);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(137, 14);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "¿Tienes una cuenta?";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // instagramNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 737);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 550);
            this.Name = "instagramNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instagramNewUser";
            this.Load += new System.EventHandler(this.instagramNewUser_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoProfileUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox photoProfileUser;
        private Guna.UI.WinForms.GunaTextBox txtNameUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnBuscarImagen;
        private Guna.UI.WinForms.GunaButton btnRegistrarCuenta;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel loginExistAccount;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtNickNameUser;
        private Guna.UI.WinForms.GunaTextBox txtPasswordUser;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}