
namespace instagramforce
{
    partial class instagramProfileFollowers
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.bttSeguir = new Guna.UI.WinForms.GunaButton();
            this.lblSeguidos = new Guna.UI.WinForms.GunaLabel();
            this.lblSeguidores = new Guna.UI.WinForms.GunaLabel();
            this.lblPost = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblUserName = new Guna.UI.WinForms.GunaLabel();
            this.imageUser = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panelFollower = new Guna.UI.WinForms.GunaPanel();
            this.bttDejardeSeguir = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.Location = new System.Drawing.Point(586, 23);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 46);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // bttSeguir
            // 
            this.bttSeguir.AnimationHoverSpeed = 0.07F;
            this.bttSeguir.AnimationSpeed = 0.03F;
            this.bttSeguir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bttSeguir.BorderColor = System.Drawing.Color.Black;
            this.bttSeguir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bttSeguir.FocusedColor = System.Drawing.Color.Empty;
            this.bttSeguir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSeguir.ForeColor = System.Drawing.Color.White;
            this.bttSeguir.Image = null;
            this.bttSeguir.ImageSize = new System.Drawing.Size(20, 20);
            this.bttSeguir.Location = new System.Drawing.Point(216, 143);
            this.bttSeguir.Name = "bttSeguir";
            this.bttSeguir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bttSeguir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bttSeguir.OnHoverForeColor = System.Drawing.Color.White;
            this.bttSeguir.OnHoverImage = null;
            this.bttSeguir.OnPressedColor = System.Drawing.Color.Black;
            this.bttSeguir.Size = new System.Drawing.Size(109, 26);
            this.bttSeguir.TabIndex = 25;
            this.bttSeguir.Text = "Seguir";
            this.bttSeguir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bttSeguir.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // lblSeguidos
            // 
            this.lblSeguidos.AutoSize = true;
            this.lblSeguidos.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblSeguidos.Location = new System.Drawing.Point(443, 71);
            this.lblSeguidos.Name = "lblSeguidos";
            this.lblSeguidos.Size = new System.Drawing.Size(14, 13);
            this.lblSeguidos.TabIndex = 24;
            this.lblSeguidos.Text = "1";
            // 
            // lblSeguidores
            // 
            this.lblSeguidores.AutoSize = true;
            this.lblSeguidores.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblSeguidores.Location = new System.Drawing.Point(359, 71);
            this.lblSeguidores.Name = "lblSeguidores";
            this.lblSeguidores.Size = new System.Drawing.Size(14, 13);
            this.lblSeguidores.TabIndex = 23;
            this.lblSeguidores.Text = "1";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblPost.Location = new System.Drawing.Point(273, 71);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(14, 13);
            this.lblPost.TabIndex = 22;
            this.lblPost.Text = "1";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(425, 102);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(66, 13);
            this.gunaLabel3.TabIndex = 21;
            this.gunaLabel3.Text = "Seguidos";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(335, 102);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(80, 13);
            this.gunaLabel2.TabIndex = 20;
            this.gunaLabel2.Text = "Seguidores";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(239, 102);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 13);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Publicaciones";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblUserName.Location = new System.Drawing.Point(35, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 17;
            // 
            // imageUser
            // 
            this.imageUser.BaseColor = System.Drawing.Color.White;
            this.imageUser.Location = new System.Drawing.Point(38, 56);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(121, 113);
            this.imageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageUser.TabIndex = 16;
            this.imageUser.TabStop = false;
            this.imageUser.UseTransfarantBackground = false;
            // 
            // panelFollower
            // 
            this.panelFollower.AutoScroll = true;
            this.panelFollower.Location = new System.Drawing.Point(12, 197);
            this.panelFollower.Name = "panelFollower";
            this.panelFollower.Size = new System.Drawing.Size(623, 426);
            this.panelFollower.TabIndex = 18;
            // 
            // bttDejardeSeguir
            // 
            this.bttDejardeSeguir.AnimationHoverSpeed = 0.07F;
            this.bttDejardeSeguir.AnimationSpeed = 0.03F;
            this.bttDejardeSeguir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bttDejardeSeguir.BorderColor = System.Drawing.Color.Black;
            this.bttDejardeSeguir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bttDejardeSeguir.FocusedColor = System.Drawing.Color.Empty;
            this.bttDejardeSeguir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDejardeSeguir.ForeColor = System.Drawing.Color.White;
            this.bttDejardeSeguir.Image = null;
            this.bttDejardeSeguir.ImageSize = new System.Drawing.Size(20, 20);
            this.bttDejardeSeguir.Location = new System.Drawing.Point(374, 143);
            this.bttDejardeSeguir.Name = "bttDejardeSeguir";
            this.bttDejardeSeguir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bttDejardeSeguir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bttDejardeSeguir.OnHoverForeColor = System.Drawing.Color.White;
            this.bttDejardeSeguir.OnHoverImage = null;
            this.bttDejardeSeguir.OnPressedColor = System.Drawing.Color.Black;
            this.bttDejardeSeguir.Size = new System.Drawing.Size(130, 26);
            this.bttDejardeSeguir.TabIndex = 28;
            this.bttDejardeSeguir.Text = "Dejar de seguir";
            this.bttDejardeSeguir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bttDejardeSeguir.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // instagramProfileFollowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 635);
            this.Controls.Add(this.bttDejardeSeguir);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.bttSeguir);
            this.Controls.Add(this.lblSeguidos);
            this.Controls.Add(this.lblSeguidores);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.imageUser);
            this.Controls.Add(this.panelFollower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instagramProfileFollowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instagramProfileFollowers";
            this.Load += new System.EventHandler(this.instagramProfileFollowers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton bttDejardeSeguir;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaButton bttSeguir;
        private Guna.UI.WinForms.GunaLabel lblSeguidos;
        private Guna.UI.WinForms.GunaLabel lblSeguidores;
        private Guna.UI.WinForms.GunaLabel lblPost;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblUserName;
        private Guna.UI.WinForms.GunaCirclePictureBox imageUser;
        private Guna.UI.WinForms.GunaPanel panelFollower;
    }
}