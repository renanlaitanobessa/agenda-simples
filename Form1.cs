using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSimplesT4
{
    public partial class Form1 : Form
    {
        private Contato[] listaDeContatos = new Contato[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaddcontato_Click(object sender, EventArgs e)
        {


            Contato objetoContato = new Contato(txtnome.Text, txtsobrenome.Text, txttelefone.Text, txtemail.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        }

        private void Escrever(Contato contato)
        {
            StreamWriter escrevedorDeArquivos = new StreamWriter("Contatos.txt");
            escrevedorDeArquivos.WriteLine(listaDeContatos.Length);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Email); 
            
            for (int i = 0; i< listaDeContatos.Length; i++)
            {
                escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
                escrevedorDeArquivos.WriteLine(contato.Sobrenome);
                escrevedorDeArquivos.WriteLine(contato.Telefone);
                escrevedorDeArquivos.WriteLine(contato.Email);
            }
        }

 

         
          

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
