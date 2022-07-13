using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Software_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open web Client
            WebClient client = new WebClient();

            // Get user name
            string userName = Environment.UserName;
            // Get path destiny
            string pathDestiny = $@"C:\Users\{userName}\Downloads\\";

            // verify raddion button is checked
            if (nodeJs.Checked == true)
            {
                // new path destiny name file and extension
                string pathDestinyName = pathDestiny + @"\\node.msi";
                // download this file 
                client.DownloadFile("https://nodejs.org/dist/v16.16.0/node-v16.16.0-x64.msi", pathDestinyName);
            }
            if (sublimeText.Checked == true)
            {
                // new path destiny name file and extension
                string pathDestenyName = pathDestiny + @"\\sublimeText.exe";
                // download this file 
                client.DownloadFile("https://download.sublimetext.com/Sublime%20Text%20Build%203211%20x64%20Setup.exe", pathDestenyName);
            }
            if (vsCode.Checked == true)
            {
                // new path destiny name file and extension
                string pathDestinyName = pathDestiny + @"\\vscode.exe";
                // download this file 
                client.DownloadFile("https://az764295.vo.msecnd.net/stable/b06ae3b2d2dbfe28bca3134cc6be65935cdfea6a/VSCodeUserSetup-x64-1.69.1.exe", pathDestinyName);
            }
            if (git.Checked == true)
            {
                // new path destiny name file and extension
                string pathDestinyName = pathDestiny + @"\\git.exe";
                // download this file 
                client.DownloadFile("https://github.com/git-for-windows/git/releases/download/v2.37.0.windows.1/Git-2.37.0-64-bit.exe", pathDestinyName);
            }
            if (discord.Checked == true)
            {
                // new path destiny name file and extension
                string pathDestinyName = pathDestiny + @"\\Discord.exe";
                // download this file 
                client.DownloadFile("https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9005/DiscordSetup.exe", pathDestinyName);
            }

        }
    }
}
