using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSimplesT4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaddcontato_Click(object sender, EventArgs e)
        {
            Contato objetoContato = new Contato(txtnome.Text, txtsobrenome.Text, txttelefone.Text, txtemail.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        



         
          }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
