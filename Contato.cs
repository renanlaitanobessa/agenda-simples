using System;
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
        private string email;



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
        public string Email
        {
            get { return email; }
            set { email = value; }
        }



        public string Telefone
        {
            get { return telefone; }
            set
            {
                
                if (value.Length == 11)
                    telefone = value;

                else
                    telefone = "00000000000";
            }
        }

        public Contato()
        {
            PrimeiroNome = "Jose";
            Sobrenome = "Da Silva";
            Telefone = "11912345678";
            Email = "renanbessa@hotmail.com"; 
        }

        public Contato(string primeiroNome, string sobrenome, string telefone , string email)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email; 

        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1} , {2}" , PrimeiroNome, Sobrenome, Email );
            saida += " ";
            saida += String.Format("{0}-{1}-{2}", 
                Telefone.Substring(0, 2), 
                Telefone.Substring(2, 5), 
                Telefone.Substring(7, 4));
            
            saida += " ";
            saida += String.Format("{0}", Email);


            return saida; 

        }



    }
}

