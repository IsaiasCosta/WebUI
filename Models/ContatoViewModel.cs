using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WebUI.Models
{
    public class ContatoViewModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Campo nome é Obrigatório")]
        [MinLength(3,ErrorMessage ="O nome deve conter no mínimo 3 caracteres")]
        
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required (ErrorMessage ="Campo SobreNome é Obrigatório")]
        [MinLength(1,ErrorMessage ="O SobreNome deve conter no mínimo 2 caracteres")]
        [DisplayName("SobreNome")]
        public string SobreNome { get; set; }

        [Required (ErrorMessage ="Campo Email é Obrigatório")]
        [MinLength(10,ErrorMessage ="O Email deve conter no mínimo 10 caracteres")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Campo Celular é Obrigatório")]
        [DisplayName("Celular")]
        public string Celular { get; set; }


    }
}