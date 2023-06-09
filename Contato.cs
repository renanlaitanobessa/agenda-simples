﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSimplesT4
{
    internal class Contato
    {
        private string primeiroNome;
        private string sobrenome;
        private string telefone;



        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }



        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }



        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)
                    Telefone = value;
                else
                    Telefone = "00000000000";
            }
        }

        public Contato()
        {
            PrimeiroNome = "Jose";
            Sobrenome = "Da Silva";
            Telefone = "11912345678"; 
        }

        public Contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;

        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}" , PrimeiroNome, Sobrenome );
            saida += " ";
            saida += String.Format("{0}-{1}-{2}", Telefone.Substring(0, 1), Telefone.Substring(2, 4), Telefone.Substring(7, 3);   

            return saida; 

        }



    }
}

