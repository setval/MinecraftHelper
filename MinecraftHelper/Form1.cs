using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftHelper.Forms;
using System.Net;
using System.IO;

namespace MinecraftHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Settings settings = new Settings();
        private TellrawForm tellrawMain;
        private string last_version = "";
        private string link_new_version = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "Minecraft Helper by Discore (" + settings.version + ")";
            if (File.Exists("MinecraftHelperUpdater.exe"))
            {

                try { File.Delete("MinecraftHelperUpdater.exe"); }
                catch { }
                MessageBox.Show("Благодарим вас за установку обновления версии "+settings.version+"!\nСписок нововведений вы можете видеть справа");
            }
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/DiscoreMe/MinecraftHelper/master/REST/version");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                string content;
                last_version = sr.ReadLine();
                link_new_version = sr.ReadLine();
                req = (HttpWebRequest)WebRequest.Create("http://discoreme.github.io/MinecraftHelper/newsProgram/");
                resp = (HttpWebResponse)req.GetResponse();
                sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                content = sr.ReadToEnd();
                sr.Close();
                content = content.Replace("\\n", Environment.NewLine);
                blockNews.Text = content;
                settings.InternetExists = true;
                sr.Close();
                resp.Close();
                if (settings.version != last_version) 
                {
                    var mes = MessageBox.Show(String.Format("Доступна новая версия {0} для скачивания. Перейти к загрузке?\nДанное приложение будет перезапущено.",last_version), "Обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (mes == DialogResult.Yes)
                    {
                        try
                        {
                            WebClient myWebClient = new WebClient();
                            myWebClient.DownloadFile("https://raw.githubusercontent.com/DiscoreMe/MinecraftHelper/master/REST/MinecraftHelperUpdater.exe", "MinecraftHelperUpdater.exe");                            
                            System.Diagnostics.Process.Start("MinecraftHelperUpdater.exe");
                            Application.Exit();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    }

                }    
            }
            catch
            {
                blockNews.Text = "Нет доступа к интернету.\n\nЕсли интернет-соединение снова доступно - перезапустите проограмму";
                settings.InternetExists = false;
            }
        }

        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void programInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minecraft Helper\n\tby Discore\n\nVK: vk.com/id109841256");
        }

        private void tellrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            tellrawMain = new TellrawForm();
            settings.Generate = "tellraw";
            foreach(Control control in tellrawMain.returnControls())
            {
                panel.Controls.Add(control);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(settings.Generate)
            {
                case "tellraw":
                {
                    Clipboard.SetText(tellrawMain.TellrawGen());
                        MessageBox.Show("Команда скопирована в буфер обмена.\n Для вставки команды нажмите сочетание клавиш CTRL + V в чате или в командном блоке.");
                    break;
                }
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите на Minecraft Helper слева-сверху и откройте доступный генератор команд.");
        }


        private void blockNews_MouseEnter(object sender, EventArgs e)
        {
            blockNews.ScrollBars = ScrollBars.Vertical;
        }

        private void blockNews_MouseLeave(object sender, EventArgs e)
        {
            blockNews.ScrollBars = ScrollBars.None;
        }
    }
}
