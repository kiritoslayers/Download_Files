using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Download_Software_Files.Forms
{
    public partial class Home : Telerik.WinControls.UI.RadForm
    {
        public Home()
        {
            InitializeComponent();
            RadMessageBox.ThemeName = "Aqua";
            RadMessageBox.Show("Para melhor aproveitamento do sistema, por gentileza ativar as notificações!");
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (Node.Checked == false && sublime.Checked == false && vscode.Checked == false && discord.Checked == false && github.Checked == false && virtualBox.Checked == false && virtualboxExtensionPath.Checked == false && steam.Checked == false && leagueoflegends.Checked == false && python.Checked == false && Sevenzip.Checked == false && brave.Checked == false && Mozilla.Checked == false && ssms.Checked == false && notion.Checked == false && insominia.Checked == false && xampp.Checked == false)
                {
                    nofitys.ShowBalloonTip(10, "Atenção", "Preencha um ou alguns campos", ToolTipIcon.Warning);
                }

                // open webclient
                WebClient client = new WebClient();
                // Get user name
                string userName = Environment.UserName;
                // Get path destiny
                string pathDestiny = $@"C:\Users\{userName}\Downloads\\";

                if (Node.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\node.msi";
                    // download this file 
                    client.DownloadFile("https://nodejs.org/dist/v16.16.0/node-v16.16.0-x64.msi", pathDestinyName);

                    // thinking about that
                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Node", ToolTipIcon.Info);

                }
                if (sublime.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\sublimeText.exe";
                    // download this file 
                    client.DownloadFile("https://download.sublimetext.com/Sublime%20Text%20Build%203211%20x64%20Setup.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Sublime text", ToolTipIcon.Info);
                }
                if (vscode.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\vscode.exe";
                    // download this file 
                    client.DownloadFile("https://az764295.vo.msecnd.net/stable/b06ae3b2d2dbfe28bca3134cc6be65935cdfea6a/VSCodeUserSetup-x64-1.69.1.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Visual Studio Code", ToolTipIcon.Info);
                }
                if (github.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\git.exe";
                    // download this file 
                    client.DownloadFile("https://github.com/git-for-windows/git/releases/download/v2.37.0.windows.1/Git-2.37.0-64-bit.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Github", ToolTipIcon.Info);

                }
                if (discord.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\Discord.exe";
                    // download this file 
                    client.DownloadFile("https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9005/DiscordSetup.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Discord", ToolTipIcon.Info);
                }
                if (virtualBox.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\VirtualBox-6.1.38-153438-Win.exe";
                    // download this file
                    client.DownloadFile("https://download.virtualbox.org/virtualbox/6.1.38/VirtualBox-6.1.38-153438-Win.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "VirtualBox", ToolTipIcon.Info);

                }
                if (steam.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\SteamSetup.exe";
                    // download this file
                    client.DownloadFile("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Steam", ToolTipIcon.Info);
                }
                if (leagueoflegends.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\live.br.exe";
                    // download this file
                    client.DownloadFile("https://lol.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.br.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "League of Legends", ToolTipIcon.Info);
                }
                if (notion.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + "\\Notion20Setup202.0.29.exe";
                    // download this file
                    client.DownloadFile("https://desktop-release.notion-static.com/Notion%20Setup%202.0.29.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Notion", ToolTipIcon.Info);

                }
                if (python.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\python-3.10.7-amd64.exe";
                    // download this file
                    client.DownloadFile("https://www.python.org/ftp/python/3.10.7/python-3.10.7-amd64.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Python", ToolTipIcon.Info);
                }
                if (Sevenzip.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\7z2201-x64.exe";
                    // download this file
                    client.DownloadFile("https://d3.7-zip.org/a/7z2201-x64.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "7zip", ToolTipIcon.Info);

                }
                if (brave.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\BraveBrowserSetup.exe";
                    // download this file
                    client.DownloadFile("https://referrals.brave.com/latest/BraveBrowserSetup.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Brave Browser", ToolTipIcon.Info);


                }
                if (Mozilla.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\FirefoxInstaller.exe";
                    // download this file
                    client.DownloadFile("https://cdn.stubdownloader.services.mozilla.com/builds/firefox-stub/pt-BR/win/2a3ff027151c6199c4a907de7311bae2180afb67cbb2bf1943dc6089d84448c5/Firefox%20Installer.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Mozilla firefox", ToolTipIcon.Info);

                }
                if (virtualboxExtensionPath.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\Oracle_VM_VirtualBox_Extension_Pack-6.1.38.vbox-extpack";
                    // download this file
                    client.DownloadFile("https://download.virtualbox.org/virtualbox/6.1.38/Oracle_VM_VirtualBox_Extension_Pack-6.1.38.vbox-extpack", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "VirtualBox Extension Pack", ToolTipIcon.Info);
                }
                if (ssms.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\SSMS-Setup-ENU.exe";
                    // download this file
                    client.DownloadFile("https://download.microsoft.com/download/8/a/8/8a8073d2-2e00-472b-9a18-88361d105915/SSMS-Setup-ENU.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "SSMS", ToolTipIcon.Info);
                }
                if (insominia.Checked == true)
                {
                    // new path destiny name file and extension
                    string pathDestinyName = pathDestiny + @"\\Insomnia.Core-2022.5.1.exe";
                    // download this file
                    client.DownloadFile("https://github.com/Kong/insomnia/releases/download/core@2022.5.1/Insomnia.Core-2022.5.1.exe", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "Insominia", ToolTipIcon.Info);
                }
                if (xampp.Checked == true)
                {
                    // new path destiny nname file and extension
                    string pathDestinyName = pathDestiny + @"\\ https://downloadsapachefriends.global.ssl.fastly.net/7.4.29/xampp-windows-x64-7.4.29-1-VC15-installer.exe?from_af=true";
                    // download this file
                    client.DownloadFile("https://downloadsapachefriends.global.ssl.fastly.net/7.4.29/xampp-windows-x64-7.4.29-1-VC15-installer.exe?from_af=true", pathDestinyName);

                    bool exists = false;

                    // a way to regret
                    while (!exists)
                    {
                        Thread.Sleep(3000);
                        if (File.Exists(pathDestinyName))
                        {
                            exists = true;
                        }
                    }

                    nofitys.ShowBalloonTip(3, "Download from finished file", "xampp", ToolTipIcon.Info);
                }

            }
            catch (Exception error)
            {
                nofitys.ShowBalloonTip(3, "Error", error.Message, ToolTipIcon.Error);
            }

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Node.Checked = true;
            sublime.Checked = true;
            vscode.Checked = true;
            github.Checked = true;
            virtualBox.Checked = true;
            virtualboxExtensionPath.Checked = true;
            steam.Checked = true;
            leagueoflegends.Checked = true;
            notion.Checked = true;
            python.Checked = true;
            Sevenzip.Checked = true;
            brave.Checked = true;
            Mozilla.Checked = true;
            discord.Checked = true;
            ssms.Checked = true;
            insominia.Checked = true;
            xampp.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Node.Checked = false;
            sublime.Checked = false;
            vscode.Checked = false;
            github.Checked = false;
            virtualBox.Checked = false;
            virtualboxExtensionPath.Checked = false;
            steam.Checked = false;
            leagueoflegends.Checked = false;
            notion.Checked = false;
            python.Checked = false;
            Sevenzip.Checked = false;
            brave.Checked = false;
            Mozilla.Checked = false;
            discord.Checked = false;
            ssms.Checked = false;
            insominia.Checked = false;
            xampp.Checked = false;
        }
    }
}
