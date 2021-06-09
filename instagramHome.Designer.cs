
namespace instagramforce
{
    partial class instagramHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instagramHome));
            this.d = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnPublish = new FontAwesome.Sharp.IconButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblfollowed = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.lblSeguidores = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.lblSeguidos = new Guna.UI.WinForms.GunaLabel();
            this.lblFollowers = new Guna.UI.WinForms.GunaLabel();
            this.lblNoPost = new Guna.UI.WinForms.GunaLabel();
            this.photoUserProfile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panelFeed = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel8 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel9 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel6.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoUserProfile)).BeginInit();
            this.gunaPanel8.SuspendLayout();
            this.gunaPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // d
            // 
            this.d.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btnPublish);
            this.gunaPanel1.Controls.Add(this.gunaTextBox1);
            this.gunaPanel1.Controls.Add(this.iconButton2);
            this.gunaPanel1.Controls.Add(this.iconButton1);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(956, 83);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // btnPublish
            // 
            this.btnPublish.FlatAppearance.BorderSize = 0;
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublish.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnPublish.IconColor = System.Drawing.Color.Black;
            this.btnPublish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPublish.IconSize = 45;
            this.btnPublish.Location = new System.Drawing.Point(798, 22);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(49, 46);
            this.btnPublish.TabIndex = 15;
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.Black;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(350, 22);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(199, 30);
            this.gunaTextBox1.TabIndex = 14;
            this.gunaTextBox1.Enter += new System.EventHandler(this.gunaTextBox1_Enter);
            this.gunaTextBox1.Leave += new System.EventHandler(this.gunaTextBox1_Leave);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 45;
            this.iconButton2.Location = new System.Drawing.Point(853, 22);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(49, 46);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.Location = new System.Drawing.Point(738, 22);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 46);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::instagramforce.Properties.Resources.instagramLogin;
            this.pictureBox1.Location = new System.Drawing.Point(32, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaButton1);
            this.gunaPanel2.Controls.Add(this.gunaLabel3);
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.lblfollowed);
            this.gunaPanel2.Controls.Add(this.gunaPanel6);
            this.gunaPanel2.Controls.Add(this.gunaPanel3);
            this.gunaPanel2.Controls.Add(this.lblFollowers);
            this.gunaPanel2.Controls.Add(this.lblNoPost);
            this.gunaPanel2.Controls.Add(this.photoUserProfile);
            this.gunaPanel2.Location = new System.Drawing.Point(655, 89);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(293, 594);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gunaLabel3.Location = new System.Drawing.Point(195, 75);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(72, 13);
            this.gunaLabel3.TabIndex = 9;
            this.gunaLabel3.Text = "gunaLabel3";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gunaLabel2.Location = new System.Drawing.Point(195, 44);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(72, 13);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "gunaLabel2";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(210, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(72, 13);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "gunaLabel1";
            // 
            // lblfollowed
            // 
            this.lblfollowed.AutoSize = true;
            this.lblfollowed.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfollowed.Location = new System.Drawing.Point(108, 75);
            this.lblfollowed.Name = "lblfollowed";
            this.lblfollowed.Size = new System.Drawing.Size(66, 13);
            this.lblfollowed.TabIndex = 6;
            this.lblfollowed.Text = "Seguidos";
            this.lblfollowed.Click += new System.EventHandler(this.lblfollowed_Click);
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.AutoScroll = true;
            this.gunaPanel6.Controls.Add(this.gunaPanel9);
            this.gunaPanel6.Controls.Add(this.lblSeguidores);
            this.gunaPanel6.Location = new System.Drawing.Point(3, 345);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(286, 246);
            this.gunaPanel6.TabIndex = 5;
            // 
            // lblSeguidores
            // 
            this.lblSeguidores.AutoSize = true;
            this.lblSeguidores.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguidores.Location = new System.Drawing.Point(105, 14);
            this.lblSeguidores.Name = "lblSeguidores";
            this.lblSeguidores.Size = new System.Drawing.Size(80, 13);
            this.lblSeguidores.TabIndex = 10;
            this.lblSeguidores.Text = "Seguidores";
            this.lblSeguidores.Click += new System.EventHandler(this.lblSeguidores_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.AutoScroll = true;
            this.gunaPanel3.Controls.Add(this.gunaPanel8);
            this.gunaPanel3.Controls.Add(this.lblSeguidos);
            this.gunaPanel3.Location = new System.Drawing.Point(3, 105);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(286, 234);
            this.gunaPanel3.TabIndex = 4;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(6, 75);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(99, 33);
            this.gunaButton1.TabIndex = 10;
            this.gunaButton1.Text = "gunaButton1";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // lblSeguidos
            // 
            this.lblSeguidos.AutoSize = true;
            this.lblSeguidos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguidos.Location = new System.Drawing.Point(105, 12);
            this.lblSeguidos.Name = "lblSeguidos";
            this.lblSeguidos.Size = new System.Drawing.Size(66, 13);
            this.lblSeguidos.TabIndex = 10;
            this.lblSeguidos.Text = "Seguidos";
            this.lblSeguidos.Click += new System.EventHandler(this.lblSeguidos_Click);
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowers.Location = new System.Drawing.Point(108, 44);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(80, 13);
            this.lblFollowers.TabIndex = 2;
            this.lblFollowers.Text = "Seguidores";
            this.lblFollowers.Click += new System.EventHandler(this.lblFollowers_Click);
            // 
            // lblNoPost
            // 
            this.lblNoPost.AutoSize = true;
            this.lblNoPost.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPost.Location = new System.Drawing.Point(108, 18);
            this.lblNoPost.Name = "lblNoPost";
            this.lblNoPost.Size = new System.Drawing.Size(96, 13);
            this.lblNoPost.TabIndex = 1;
            this.lblNoPost.Text = "Publicaciones";
            this.lblNoPost.Click += new System.EventHandler(this.lblNoPost_Click);
            // 
            // photoUserProfile
            // 
            this.photoUserProfile.BaseColor = System.Drawing.Color.White;
            this.photoUserProfile.Location = new System.Drawing.Point(13, 14);
            this.photoUserProfile.Name = "photoUserProfile";
            this.photoUserProfile.Size = new System.Drawing.Size(85, 76);
            this.photoUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoUserProfile.TabIndex = 0;
            this.photoUserProfile.TabStop = false;
            this.photoUserProfile.UseTransfarantBackground = false;
            // 
            // panelFeed
            // 
            this.panelFeed.AutoScroll = true;
            this.panelFeed.Location = new System.Drawing.Point(12, 89);
            this.panelFeed.Name = "panelFeed";
            this.panelFeed.Size = new System.Drawing.Size(637, 594);
            this.panelFeed.TabIndex = 2;
            this.panelFeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelFeed_Scroll);
            this.panelFeed.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFeed_Paint);
            // 
            // gunaPanel8
            // 
            this.gunaPanel8.Controls.Add(this.gunaLabel4);
            this.gunaPanel8.Location = new System.Drawing.Point(28, 43);
            this.gunaPanel8.Name = "gunaPanel8";
            this.gunaPanel8.Size = new System.Drawing.Size(236, 61);
            this.gunaPanel8.TabIndex = 11;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(120, 25);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "gunaLabel4";
            // 
            // gunaPanel9
            // 
            this.gunaPanel9.Controls.Add(this.gunaLabel5);
            this.gunaPanel9.Controls.Add(this.gunaCirclePictureBox2);
            this.gunaPanel9.Location = new System.Drawing.Point(28, 45);
            this.gunaPanel9.Name = "gunaPanel9";
            this.gunaPanel9.Size = new System.Drawing.Size(236, 61);
            this.gunaPanel9.TabIndex = 12;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(120, 25);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "gunaLabel5";
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(3, 3);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(64, 55);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox2.TabIndex = 0;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // instagramHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 695);
            this.Controls.Add(this.panelFeed);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instagramHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.instagramHome_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel6.ResumeLayout(false);
            this.gunaPanel6.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoUserProfile)).EndInit();
            this.gunaPanel8.ResumeLayout(false);
            this.gunaPanel8.PerformLayout();
            this.gunaPanel9.ResumeLayout(false);
            this.gunaPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse d;
        private Guna.UI.WinForms.GunaPanel panelFeed;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaCirclePictureBox photoUserProfile;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaLabel lblFollowers;
        private Guna.UI.WinForms.GunaLabel lblNoPost;
        private Guna.UI.WinForms.GunaLabel lblfollowed;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblSeguidores;
        private Guna.UI.WinForms.GunaLabel lblSeguidos;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private FontAwesome.Sharp.IconButton btnPublish;
        private Guna.UI.WinForms.GunaPanel gunaPanel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaPanel gunaPanel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}