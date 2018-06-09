namespace youtube_dl_ui
{
    partial class youtube_dl_ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(youtube_dl_ui));
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.txt_URLs = new System.Windows.Forms.TextBox();
            this.txt_Command = new System.Windows.Forms.TextBox();
            this.lbl_Command = new System.Windows.Forms.Label();
            this.lbl_URLs = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Load_URLs = new System.Windows.Forms.Button();
            this.btn_Clear_URLs = new System.Windows.Forms.Button();
            this.btn_Reset_Command = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadURLsFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Main.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 327);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(438, 22);
            this.statusStrip_Main.TabIndex = 0;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(438, 24);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadURLsFromFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.btn_Reset_Command);
            this.panel_Main.Controls.Add(this.btn_Clear_URLs);
            this.panel_Main.Controls.Add(this.btn_Load_URLs);
            this.panel_Main.Controls.Add(this.btn_Download);
            this.panel_Main.Controls.Add(this.lbl_URLs);
            this.panel_Main.Controls.Add(this.lbl_Command);
            this.panel_Main.Controls.Add(this.txt_Command);
            this.panel_Main.Controls.Add(this.txt_URLs);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 24);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(438, 303);
            this.panel_Main.TabIndex = 2;
            // 
            // txt_URLs
            // 
            this.txt_URLs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_URLs.Location = new System.Drawing.Point(15, 178);
            this.txt_URLs.Multiline = true;
            this.txt_URLs.Name = "txt_URLs";
            this.txt_URLs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_URLs.Size = new System.Drawing.Size(411, 83);
            this.txt_URLs.TabIndex = 0;
            // 
            // txt_Command
            // 
            this.txt_Command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Command.Location = new System.Drawing.Point(15, 41);
            this.txt_Command.Multiline = true;
            this.txt_Command.Name = "txt_Command";
            this.txt_Command.Size = new System.Drawing.Size(411, 80);
            this.txt_Command.TabIndex = 1;
            // 
            // lbl_Command
            // 
            this.lbl_Command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Command.Location = new System.Drawing.Point(12, 15);
            this.lbl_Command.Name = "lbl_Command";
            this.lbl_Command.Size = new System.Drawing.Size(414, 23);
            this.lbl_Command.TabIndex = 2;
            this.lbl_Command.Text = "Command";
            this.lbl_Command.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_URLs
            // 
            this.lbl_URLs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_URLs.Location = new System.Drawing.Point(12, 152);
            this.lbl_URLs.Name = "lbl_URLs";
            this.lbl_URLs.Size = new System.Drawing.Size(414, 23);
            this.lbl_URLs.TabIndex = 3;
            this.lbl_URLs.Text = "URL of the videos(one on each line)";
            this.lbl_URLs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Download.Location = new System.Drawing.Point(15, 267);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 4;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Load_URLs
            // 
            this.btn_Load_URLs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Load_URLs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load_URLs.Location = new System.Drawing.Point(96, 267);
            this.btn_Load_URLs.Name = "btn_Load_URLs";
            this.btn_Load_URLs.Size = new System.Drawing.Size(128, 23);
            this.btn_Load_URLs.TabIndex = 5;
            this.btn_Load_URLs.Text = "Load URLs from file";
            this.btn_Load_URLs.UseVisualStyleBackColor = true;
            this.btn_Load_URLs.Click += new System.EventHandler(this.btn_Load_URLs_Click);
            // 
            // btn_Clear_URLs
            // 
            this.btn_Clear_URLs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear_URLs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear_URLs.Location = new System.Drawing.Point(230, 267);
            this.btn_Clear_URLs.Name = "btn_Clear_URLs";
            this.btn_Clear_URLs.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear_URLs.TabIndex = 6;
            this.btn_Clear_URLs.Text = "Clear URLs";
            this.btn_Clear_URLs.UseVisualStyleBackColor = true;
            this.btn_Clear_URLs.Click += new System.EventHandler(this.btn_Clear_URLs_Click);
            // 
            // btn_Reset_Command
            // 
            this.btn_Reset_Command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset_Command.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset_Command.Location = new System.Drawing.Point(311, 267);
            this.btn_Reset_Command.Name = "btn_Reset_Command";
            this.btn_Reset_Command.Size = new System.Drawing.Size(115, 23);
            this.btn_Reset_Command.TabIndex = 7;
            this.btn_Reset_Command.Text = "Reset command";
            this.btn_Reset_Command.UseVisualStyleBackColor = true;
            this.btn_Reset_Command.Click += new System.EventHandler(this.btn_Reset_Command_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loadURLsFromFileToolStripMenuItem
            // 
            this.loadURLsFromFileToolStripMenuItem.Name = "loadURLsFromFileToolStripMenuItem";
            this.loadURLsFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadURLsFromFileToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.loadURLsFromFileToolStripMenuItem.Text = "L&oad URLs from file...";
            this.loadURLsFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadURLsFromFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // youtube_dl_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 349);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MinimumSize = new System.Drawing.Size(454, 387);
            this.Name = "youtube_dl_ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "youtube-dl-ui";
            this.Load += new System.EventHandler(this.youtube_dl_ui_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label lbl_URLs;
        private System.Windows.Forms.Label lbl_Command;
        private System.Windows.Forms.TextBox txt_Command;
        private System.Windows.Forms.TextBox txt_URLs;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Load_URLs;
        private System.Windows.Forms.Button btn_Reset_Command;
        private System.Windows.Forms.Button btn_Clear_URLs;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadURLsFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}