using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Grupo6.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public Usuario()
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }
    }
}
