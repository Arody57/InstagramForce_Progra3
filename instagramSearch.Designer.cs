
namespace instagramforce
{
    partial class instagramSearch
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
            this.lblSearch = new Guna.UI.WinForms.GunaLabel();
            this.backPage = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 9;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.txtSearch);
            this.gunaPanel1.Controls.Add(this.panelFeed);
            this.gunaPanel1.Controls.Add(this.lblSearch);
            this.gunaPanel1.Controls.Add(this.backPage);
            this.gunaPanel1.Location = new System.Drawing.Point(51, 44);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(612, 519);
            this.gunaPanel1.TabIndex = 3;
            // 
            // panelFeed
            // 
            this.panelFeed.AutoScroll = true;
            this.panelFeed.Location = new System.Drawing.Point(79, 109);
            this.panelFeed.Name = "panelFeed";
            this.panelFeed.Size = new System.Drawing.Size(470, 384);
            this.panelFeed.TabIndex = 17;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 13F);
            this.lblSearch.Location = new System.Drawing.Point(285, 14);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 22);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Buscar";
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(187, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 20);
            this.txtSearch.TabIndex = 18;
            // 
            // instagramSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 605);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instagramSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instagramSearch";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private Guna.UI.WinForms.GunaPanel panelFeed;
        private Guna.UI.WinForms.GunaLabel lblSearch;
        private FontAwesome.Sharp.IconButton backPage;
    }
}