
namespace instagramforce
{
    partial class instagramUserPost
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.bttCancelar = new Guna.UI.WinForms.GunaButton();
            this.bttPublicar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtdataPost = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscarImagen = new Guna.UI.WinForms.GunaButton();
            this.photoPost = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPost)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.bttCancelar);
            this.gunaPanel1.Controls.Add(this.bttPublicar);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.txtdataPost);
            this.gunaPanel1.Controls.Add(this.btnBuscarImagen);
            this.gunaPanel1.Controls.Add(this.photoPost);
            this.gunaPanel1.Location = new System.Drawing.Point(37, 41);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(669, 373);
            this.gunaPanel1.TabIndex = 8;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(17, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(159, 18);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Crear publicación";
            // 
            // bttCancelar
            // 
            this.bttCancelar.AnimationHoverSpeed = 0.07F;
            this.bttCancelar.AnimationSpeed = 0.03F;
            this.bttCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bttCancelar.BorderColor = System.Drawing.Color.Black;
            this.bttCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bttCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.bttCancelar.Font = new System.Drawing.Font("Verdana", 10F);
            this.bttCancelar.ForeColor = System.Drawing.Color.White;
            this.bttCancelar.Image = null;
            this.bttCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.bttCancelar.Location = new System.Drawing.Point(578, 333);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bttCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bttCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.bttCancelar.OnHoverImage = null;
            this.bttCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.bttCancelar.Size = new System.Drawing.Size(78, 28);
            this.bttCancelar.TabIndex = 13;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // bttPublicar
            // 
            this.bttPublicar.AnimationHoverSpeed = 0.07F;
            this.bttPublicar.AnimationSpeed = 0.03F;
            this.bttPublicar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(184)))), ((int)(((byte)(23)))));
            this.bttPublicar.BorderColor = System.Drawing.Color.Black;
            this.bttPublicar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bttPublicar.FocusedColor = System.Drawing.Color.Empty;
            this.bttPublicar.Font = new System.Drawing.Font("Verdana", 10F);
            this.bttPublicar.ForeColor = System.Drawing.Color.White;
            this.bttPublicar.Image = null;
            this.bttPublicar.ImageSize = new System.Drawing.Size(20, 20);
            this.bttPublicar.Location = new System.Drawing.Point(501, 333);
            this.bttPublicar.Name = "bttPublicar";
            this.bttPublicar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(69)))));
            this.bttPublicar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bttPublicar.OnHoverForeColor = System.Drawing.Color.White;
            this.bttPublicar.OnHoverImage = null;
            this.bttPublicar.OnPressedColor = System.Drawing.Color.Black;
            this.bttPublicar.Size = new System.Drawing.Size(71, 28);
            this.bttPublicar.TabIndex = 12;
            this.bttPublicar.Text = "Publicar";
            this.bttPublicar.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gunaLabel1.Location = new System.Drawing.Point(423, 106);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(135, 13);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "¿Qué estás pensando?";
            // 
            // txtdataPost
            // 
            this.txtdataPost.BaseColor = System.Drawing.Color.White;
            this.txtdataPost.BorderColor = System.Drawing.Color.Silver;
            this.txtdataPost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdataPost.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdataPost.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtdataPost.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdataPost.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtdataPost.Location = new System.Drawing.Point(340, 133);
            this.txtdataPost.MaxLength = 150;
            this.txtdataPost.MultiLine = true;
            this.txtdataPost.Name = "txtdataPost";
            this.txtdataPost.PasswordChar = '\0';
            this.txtdataPost.Size = new System.Drawing.Size(300, 135);
            this.txtdataPost.TabIndex = 10;
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
            this.btnBuscarImagen.Location = new System.Drawing.Point(131, 317);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnBuscarImagen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarImagen.OnHoverImage = null;
            this.btnBuscarImagen.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.Size = new System.Drawing.Size(61, 34);
            this.btnBuscarImagen.TabIndex = 9;
            this.btnBuscarImagen.Text = "Buscar";
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // photoPost
            // 
            this.photoPost.BackColor = System.Drawing.Color.Gainsboro;
            this.photoPost.BaseColor = System.Drawing.Color.White;
            this.photoPost.Location = new System.Drawing.Point(20, 64);
            this.photoPost.Name = "photoPost";
            this.photoPost.Size = new System.Drawing.Size(277, 247);
            this.photoPost.TabIndex = 8;
            this.photoPost.TabStop = false;
            // 
            // instagramUserPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 452);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instagramUserPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instagramUserPost";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtdataPost;
        private Guna.UI.WinForms.GunaButton btnBuscarImagen;
        private Guna.UI.WinForms.GunaPictureBox photoPost;
        private Guna.UI.WinForms.GunaButton bttCancelar;
        private Guna.UI.WinForms.GunaButton bttPublicar;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}