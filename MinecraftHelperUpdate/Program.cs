using System;
using System.IO;
using System.Net;
using System.Text;

namespace MinecraftHelperUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/DiscoreMe/MinecraftHelper/master/REST/version");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                string content = sr.ReadLine();
                content = sr.ReadLine();
                WebClient myWebClient = new WebClient();
                string fileName = "MinecraftHelperNew.exe";
                Console.WriteLine("Загрузка файла \"{0}\"...", fileName);
                myWebClient.DownloadFile(content, fileName);
                Console.WriteLine("Файл \"{0}\" успешно загружен.", fileName);
                try { File.Delete("MinecraftHelper.exe"); }
                catch { Console.WriteLine("Ошибка в удалении старой версии"); }
                File.Move("MinecraftHelperNew.exe", "MinecraftHelper.exe");
                System.Diagnostics.Process.Start("MinecraftHelper.exe");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Обновление отменено.\nОшибка:\n\n" + ex.ToString());
            }
        }
    }
}
