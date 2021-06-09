
namespace instagramforce
{
    partial class instagramEditProfile
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtpasswordUser = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnBuscarImagen = new Guna.UI.WinForms.GunaButton();
            this.photoProfileUser = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txtNicknameUser = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.txtNameUser = new Guna.UI.WinForms.GunaTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoProfileUser)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtpasswordUser
            // 
            this.txtpasswordUser.BaseColor = System.Drawing.Color.White;
            this.txtpasswordUser.BorderColor = System.Drawing.Color.Silver;
            this.txtpasswordUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpasswordUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpasswordUser.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.txtpasswordUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpasswordUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpasswordUser.Location = new System.Drawing.Point(88, 316);
            this.txtpasswordUser.Name = "txtpasswordUser";
            this.txtpasswordUser.PasswordChar = '\0';
            this.txtpasswordUser.Size = new System.Drawing.Size(250, 40);
            this.txtpasswordUser.TabIndex = 11;
            this.txtpasswordUser.Tag = "d";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(85, 359);
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
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(88, 385);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(250, 37);
            this.gunaDateTimePicker1.TabIndex = 9;
            this.gunaDateTimePicker1.Text = "Sunday, May 23, 2021";
            this.gunaDateTimePicker1.Value = new System.DateTime(2021, 5, 23, 11, 53, 53, 561);
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
            this.btnBuscarImagen.Location = new System.Drawing.Point(148, 162);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnBuscarImagen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarImagen.OnHoverImage = null;
            this.btnBuscarImagen.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.Size = new System.Drawing.Size(145, 33);
            this.btnBuscarImagen.TabIndex = 6;
            this.btnBuscarImagen.Text = "Cambiar foto del perfil";
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // photoProfileUser
            // 
            this.photoProfileUser.BaseColor = System.Drawing.Color.White;
            this.photoProfileUser.Location = new System.Drawing.Point(148, 28);
            this.photoProfileUser.Name = "photoProfileUser";
            this.photoProfileUser.Size = new System.Drawing.Size(145, 128);
            this.photoProfileUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoProfileUser.TabIndex = 5;
            this.photoProfileUser.TabStop = false;
            this.photoProfileUser.UseTransfarantBackground = false;
            // 
            // txtNicknameUser
            // 
            this.txtNicknameUser.BaseColor = System.Drawing.Color.White;
            this.txtNicknameUser.BorderColor = System.Drawing.Color.Silver;
            this.txtNicknameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNicknameUser.Enabled = false;
            this.txtNicknameUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNicknameUser.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.txtNicknameUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNicknameUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNicknameUser.Location = new System.Drawing.Point(88, 201);
            this.txtNicknameUser.Name = "txtNicknameUser";
            this.txtNicknameUser.PasswordChar = '\0';
            this.txtNicknameUser.Size = new System.Drawing.Size(250, 40);
            this.txtNicknameUser.TabIndex = 3;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.txtNameUser);
            this.gunaPanel1.Controls.Add(this.iconButton1);
            this.gunaPanel1.Controls.Add(this.iconButton2);
            this.gunaPanel1.Controls.Add(this.txtpasswordUser);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaDateTimePicker1);
            this.gunaPanel1.Controls.Add(this.btnBuscarImagen);
            this.gunaPanel1.Controls.Add(this.photoProfileUser);
            this.gunaPanel1.Controls.Add(this.txtNicknameUser);
            this.gunaPanel1.Location = new System.Drawing.Point(61, 44);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(422, 469);
            this.gunaPanel1.TabIndex = 1;
            // 
            // txtNameUser
            // 
            this.txtNameUser.BaseColor = System.Drawing.Color.White;
            this.txtNameUser.BorderColor = System.Drawing.Color.Silver;
            this.txtNameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNameUser.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.txtNameUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNameUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameUser.Location = new System.Drawing.Point(88, 259);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.PasswordChar = '\0';
            this.txtNameUser.Size = new System.Drawing.Size(250, 40);
            this.txtNameUser.TabIndex = 16;
            this.txtNameUser.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 46);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 45;
            this.iconButton2.Location = new System.Drawing.Point(370, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(49, 46);
            this.iconButton2.TabIndex = 14;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // instagramEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 578);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instagramEditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instagramEditProfile";
            this.Load += new System.EventHandler(this.instagramEditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoProfileUser)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTextBox txtpasswordUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaButton btnBuscarImagen;
        private Guna.UI.WinForms.GunaCirclePictureBox photoProfileUser;
        private Guna.UI.WinForms.GunaTextBox txtNicknameUser;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaTextBox txtNameUser;
    }
}