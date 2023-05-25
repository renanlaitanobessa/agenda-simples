﻿using System;
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



        private void btnAddContato_Click(object sender, EventArgs e)
        {
            Contato objetoContato = new Contato(txtnome.Text, txtsobrenome.Text, txttelefone.Text, txtemail.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        }



        private void Escrever(Contato contato)
        {
            StreamWriter escrevedorDeArquivos = new StreamWriter("contato.txt");
            escrevedorDeArquivos.WriteLine(listaDeContatos.Length + 1);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Email);
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].PrimeiroNome);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Sobrenome);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Telefone);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Email);
            }
            escrevedorDeArquivos.Close();
        }
        private void Ler()
        {
            StreamReader leitorDeArquivos = new StreamReader("Contatos.txt");
            listaDeContatos = new Contato[Convert.ToInt32(leitorDeArquivos.ReadLine())];
            // Copia os dados do arquivo de texto para o vetor listaDeContatos
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                listaDeContatos[i] = new Contato();
                listaDeContatos[i].PrimeiroNome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Sobrenome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Telefone = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Email = leitorDeArquivos.ReadLine();
            }





            leitorDeArquivos.Close();
        }
        private void AtualizarDisplay()
        {
            lstContatos.Items.Clear();
            for (int i = 0; 1 < listaDeContatos.Length; i++)
            {
                lstContatos.Items.Add(listaDeContatos[i].ToString());
            }
        }
        private void LimparFormulario()
        {
            txtnome.Text = String.Empty;
            txtsobrenome.Text = String.Empty;
            txtemail.Text = String.Empty;
            txttelefone.Text = String.Empty;
        }

    private void Form1_Load(object sender, EventArgs e)

        {

            Ler();

            AtualizarDisplay();

        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            Ordenar();
            AtualizarDisplay();
        }

        private void Ordenar()
        {
            Contato temporario;
            bool trocar = true;
            do
            {
                trocar = false;
                for (int i = 0; i < (listaDeContatos.Length - 1); i++)
                {
                    if (listaDeContatos[i].PrimeiroNome.CompareTo(listaDeContatos[i + 1].PrimeiroNome) > 0)
                    {

                        temporario = listaDeContatos[i];
                        listaDeContatos[i] = listaDeContatos[i + 1];
                        listaDeContatos[i + 1] = temporario;
                        trocar = true;

                    }
                }
            } while (trocar == true); 

 }
    }
}
















