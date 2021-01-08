using Strawberry.Araclar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strawberry.Formlar
{
    public partial class ManuelMesaj : Form
    {
        public string ip;

        public ManuelMesaj(string ipjuan)
        {
            InitializeComponent();
            
            ip = ipjuan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.server.Send(ip, textBox1.Text);
        }
    }
}
