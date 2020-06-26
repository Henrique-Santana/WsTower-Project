using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WsTower.Domains
{
    public partial class Usuario
    {
        public int Id { get; set; }

        // Define que a propriedade é obrigatória
        //[Required(ErrorMessage = "O Nome do usuário é obrigatório!")]
        public string Nome { get; set; }

        // Define que a propriedade é obrigatória
        //[Required(ErrorMessage = "O e-mail do usuário é obrigatório!")]
        // Define o tipo do dado
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Define que a propriedade é obrigatória
        //[Required(ErrorMessage = "O Apelido do usuário é obrigatório!")]
        public string Apelido { get; set; }
        public byte[] Foto { get; set; }

        // Define que a propriedade é obrigatória
        //[Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        // Define os requisitos do campo
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "A senha deve conter no minimo 3 caracteres.")]
        public string Senha { get; set; }
    }
}
