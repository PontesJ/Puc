using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Cliente
    {
        private String nome, email;
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getNome()
        {
            return nome;
        }
        public String getEmail()
        {
            return email;
        }
        public Cliente(String nome, String email)
        {
            this.nome = nome;
            this.email = email;
        }
        public Cliente()
        { }
    }
}
