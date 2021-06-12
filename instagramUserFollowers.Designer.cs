
namespace instagramforce
{
    partial class instagramUserFollowers
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
            this.panelFeed = new Guna.UI.WinForms.GunaPanel();
            this.lblfollowers = new Guna.UI.WinForms.GunaLabel();
            this.backPage = new FontAwesome.Sharp.IconButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.panelFeed);
            this.gunaPanel1.Controls.Add(this.lblfollowers);
            this.gunaPanel1.Controls.Add(this.backPage);
            this.gunaPanel1.Location = new System.Drawing.Point(30, 27);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(462, 561);
            this.gunaPanel1.TabIndex = 3;
            // 
            // panelFeed
            // 
            this.panelFeed.AutoScroll = true;
            this.panelFeed.Location = new System.Drawing.Point(94, 76);
            this.panelFeed.Name = "panelFeed";
            this.panelFeed.Size = new System.Drawing.Size(328, 456);
            this.panelFeed.TabIndex = 17;
            // 
            // lblfollowers
            // 
            this.lblfollowers.AutoSize = true;
            this.lblfollowers.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblfollowers.Location = new System.Drawing.Point(173, 27);
            this.lblfollowers.Name = "lblfollowers";
            this.lblfollowers.Size = new System.Drawing.Size(110, 22);
            this.lblfollowers.TabIndex = 16;
            this.lblfollowers.Text = "Seguidores";
            // 
            // backPage
            // 
            this.backPage.FlatAppearance.BorderSize = 0;
            this.backPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backPage.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backPage.IconColor = System.Drawing.Color.Black;
            this.backPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backPage.IconSize = 45;
            this.backPage.Location = new System.Drawing.Point(3, 3);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(49, 46);
            this.backPage.TabIndex = 15;
            this.backPage.UseVisualStyleBackColor = true;
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // instagramUserFollowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 611);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instagramUserFollowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instagramUserFollowers";
            this.Load += new System.EventHandler(this.instagramUserFollowers_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lblfollowers;
        private FontAwesome.Sharp.IconButton backPage;
        private Guna.UI.WinForms.GunaPanel panelFeed;
    }
}