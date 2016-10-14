using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Settings settings = new Settings();
        private WebBrowser webNews = null;

        private void MainForm_Load(object sender, EventArgs e)
        {
            InternetConnection();
        }

        private bool returnBoolInternetConnection()
        {
            if (settings.InternetExists) return true;
            else return false;
        }
        private void InternetConnection()
        {
            System.Net.NetworkInformation.IPStatus status = System.Net.NetworkInformation.IPStatus.TimedOut;
            try
            {
                System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
                System.Net.NetworkInformation.PingReply pr = p.Send(@"google.ru");
                status = pr.Status;
            }
            catch
            {
                if (status == System.Net.NetworkInformation.IPStatus.Success) settings.InternetExists = true;
                else
                {
                    settings.InternetExists = false;
                    подключитьсяToolStripMenuItem.Visible = true;
                    webNews = blockNews;
                    this.Controls.Remove(blockNews);
                }
            }
        }
        private void sendWelcome(bool internet)
        {
            if (internet)
            {
                this.Controls.Add(webNews);
                подключитьсяToolStripMenuItem.Visible = false;
                MessageBox.Show("Вы подключены!", "Подключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            else
            {
                MessageBox.Show("Подключение закончилось провалом. Нет соединения с интернетом.", "Подключение", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
        }
        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternetConnection();
            sendWelcome(returnBoolInternetConnection());
        }

        private void programInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minecraft Helper\n\t\tby Discore\n\nVK: vk.com/id109841256");
        }
    }
}
