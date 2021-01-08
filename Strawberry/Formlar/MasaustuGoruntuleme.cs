using Strawberry.Araclar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatsonTcp;

namespace Strawberry.Formlar
{
    public partial class MasaustuGoruntuleme : Form
    {
        string ip;

        public MasaustuGoruntuleme(string gelenip)
        {
            InitializeComponent();
            ip = gelenip;

            Server.server.Events.MessageReceived += mesajgeldi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goruntualtimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button3.Visible = false;
        }

        private void goruntualtimer_Tick(object sender, EventArgs e)
        {
            Server.server.Send(ip, "ekrangonder"); //ekran fotosu isteği gönderiyoruz
        }

        public void mesajgeldi(object sender, MessageReceivedEventArgs args)
        {
            if (args.IpPort == ip)
            {
                if (!bytearraystringmi(args.Data))
                {
                    Image resim;

                    MemoryStream ms = new MemoryStream(args.Data, 0, args.Data.Length);
                    ms.Write(args.Data, 0, args.Data.Length);
                    resim = Image.FromStream(ms, true);

                    pictureBox1.Image = resim;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            goruntualtimer.Stop();
        }

        public static bool bytearraystringmi(IEnumerable<byte> source)
        {
            if (null == source)
                return true;

            return source.All(b => b >= 32 && b <= 127);
        }

        public bool tiklamaacik = false;

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Normal")
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;

                button5.Text = "Kontrol";
                tiklamaacik = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

                button5.Text = "Normal";
                tiklamaacik = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tiklamaacik)
            {
                Server.server.Send(ip, "tikla:" + Cursor.Position.X + ":" + Cursor.Position.Y);
            }
        }
    }
}
