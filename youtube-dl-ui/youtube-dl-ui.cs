using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace youtube_dl_ui
{
    public partial class youtube_dl_ui : Form
    {
        public youtube_dl_ui()
        {
            InitializeComponent();

            downloader = new youtube_dl();
        }

        youtube_dl downloader;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Clear_URLs_Click(object sender, EventArgs e)
        {
            downloader.Clear();
            txt_URLs.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            youtube_dl_ui_about frm_About = new youtube_dl_ui_about();
            frm_About.ShowDialog();
        }

        private void btn_Load_URLs_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.InitialDirectory = Application.ExecutablePath;
            diag.Filter = "Text files|*.txt|All files|*.*";
            if(diag.ShowDialog() == DialogResult.OK)
            {
                downloader.LoadFromFile(diag.FileName);

                txt_URLs.Clear();
                foreach(string URL in downloader.GetURLs())
                {
                    txt_URLs.Text += URL + Environment.NewLine;
                }
            }
        }

        private void youtube_dl_ui_Load(object sender, EventArgs e)
        {
            txt_Command.Text = youtube_dl.DEFAULT_COMMAND;
        }

        private void btn_Reset_Command_Click(object sender, EventArgs e)
        {
            downloader.ResetCommand();
            txt_Command.Text = downloader.Command;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            downloader.Clear();
            foreach (string URL in txt_URLs.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
            {
                downloader.Add(URL);
            }

            string output = String.Empty, 
                   error  = String.Empty;

            downloader.Download();
            
        }

        private void loadURLsFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Load_URLs.PerformClick();
        }
    }
}
