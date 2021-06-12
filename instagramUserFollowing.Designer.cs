
namespace instagramforce
{
    partial class instagramUserFollowing
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
            this.lblfollowed = new Guna.UI.WinForms.GunaLabel();
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
            this.gunaPanel1.Controls.Add(this.lblfollowed);
            this.gunaPanel1.Controls.Add(this.backPage);
            this.gunaPanel1.Location = new System.Drawing.Point(21, 24);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(481, 632);
            this.gunaPanel1.TabIndex = 2;
            // 
            // panelFeed
            // 
            this.panelFeed.AutoScroll = true;
            this.panelFeed.Location = new System.Drawing.Point(106, 67);
            this.panelFeed.Name = "panelFeed";
            this.panelFeed.Size = new System.Drawing.Size(338, 531);
            this.panelFeed.TabIndex = 17;
            // 
            // lblfollowed
            // 
            this.lblfollowed.AutoSize = true;
            this.lblfollowed.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblfollowed.Location = new System.Drawing.Point(206, 27);
            this.lblfollowed.Name = "lblfollowed";
            this.lblfollowed.Size = new System.Drawing.Size(91, 22);
            this.lblfollowed.TabIndex = 16;
            this.lblfollowed.Text = "Seguidos";
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
            this.backPage.Size = new System.Drawing.Size(59, 46);
            this.backPage.TabIndex = 15;
            this.backPage.UseVisualStyleBackColor = true;
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // instagramUserFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(545, 686);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instagramUserFollowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instagramUserFollowing";
            this.Load += new System.EventHandler(this.instagramUserFollowing_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private FontAwesome.Sharp.IconButton backPage;
        private Guna.UI.WinForms.GunaLabel lblfollowed;
        private Guna.UI.WinForms.GunaPanel panelFeed;
    }
}