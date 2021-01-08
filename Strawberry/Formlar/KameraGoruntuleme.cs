using Strawberry.Araclar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatsonTcp;

namespace Strawberry.Formlar
{
    public partial class KameraGoruntuleme : Form
    {
        string ip;

        public KameraGoruntuleme(string gelenip)
        {
            InitializeComponent();
            ip = gelenip;

            Server.server.Events.MessageReceived += mesajgeldi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.server.Send(ip, "kamerabaslat");
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

        public void mesajgeldi(object sender, MessageReceivedEventArgs args)
        {
            Image resim;

            MemoryStream ms = new MemoryStream(args.Data, 0, args.Data.Length);
            ms.Write(args.Data, 0, args.Data.Length);
            resim = Image.FromStream(ms, true);

            pictureBox1.Image = resim;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Server.server.Send(ip, "kameradurdur");
        }
    }
}
