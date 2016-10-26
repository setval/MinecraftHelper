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
        private TextBox webNews = null;
        private TellrawForm tellrawMain;

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest req;
                HttpWebResponse resp;
                StreamReader sr;
                string content;
                req = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/DiscoreMe/MinecraftHelper/master/REST/news");
                resp = (HttpWebResponse)req.GetResponse();
                sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                content = sr.ReadToEnd();
                sr.Close();
                content = content.Replace("\\n", Environment.NewLine);
                blockNews.Text = content;
            }
            catch
            {
                blockNews.Text = "Нет доступа к интернету.\n\nЕсли интернет-соединение снова доступно - перезапустите проограмму";
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

        private void проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не работает =(");
        }
    }
}
