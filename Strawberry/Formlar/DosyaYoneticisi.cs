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
    public partial class DosyaYoneticisi : Form
    {
        string ipport;

        string suankipath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public DosyaYoneticisi(string ipjuan)
        {
            InitializeComponent();

            ipport = ipjuan;
        }

        private void DosyaYoneticisi_Load(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "listele:" + suankipath);
        }

        public void mesajgeldi(object sender, MessageReceivedEventArgs args)
        {
            if (args.IpPort == ipport)
            {
                string mesaj = Encoding.UTF8.GetString(args.Data);

                if (mesaj == "klasorliste")
                {
                    if (args.Metadata != null)
                    {
                        dosyayoneticisidatagrid.Columns.Clear();

                        foreach (var item in args.Metadata)
                        {
                            string dosyaadi = item.Key.ToString().Split(Path.DirectorySeparatorChar).Last();

                            dosyayoneticisidatagrid.Rows.Add(dosyaadi, item.Value.ToString(), item.Key.ToString());
                        }
                    }
                }
            }
        }

        private void dosyayoneticisidatagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dosyayoneticisidatagrid.Rows[e.RowIndex];

            if ((string)row.Cells[1].Value == "Klasor")
            {
                suankipath = Path.Combine(suankipath, (string)row.Cells[0].Value);

                Server.server.Send(ipport, "listele:" + suankipath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "listele:" + suankipath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dosyayoneticisidatagrid.CurrentRow;

            if ((string)row.Cells[1].Value == "Klasor")
            {
                Server.server.Send(ipport, "klasorsil:" + row.Cells[2].Value.ToString());
            }
            if ((string)row.Cells[1].Value == "Dosya")
            {
                Server.server.Send(ipport, "dosyasil:" + row.Cells[2].Value.ToString());
            }

            Server.server.Send(ipport, "listele:" + suankipath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dosyayoneticisidatagrid.CurrentRow;

            var mtdt = new Dictionary<object, object>();

            mtdt.Add(row.Cells[2].Value.ToString(), textBox1.Text);

            if ((string)row.Cells[1].Value == "Dosya")
            {
                Server.server.Send(ipport, "dosyayenidenadlandir", mtdt);
            }

            Server.server.Send(ipport, "listele:" + suankipath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var mtdt = new Dictionary<object, object>();

                mtdt.Add("dosyayukle", null);

                mtdt.Add(ofd.FileName.Split(Path.DirectorySeparatorChar).Last(), suankipath);

                byte[] dosyabytearr = File.ReadAllBytes(ofd.FileName);

                Server.server.Send(ipport, dosyabytearr, mtdt);
            }
        }
    }
}
