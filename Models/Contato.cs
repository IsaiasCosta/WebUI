using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
namespace WebUI.Models
{
    public class Contato
    { 
         public int Id{get;set;}

        [DisplayName("Nome")]
        public string Nome { get; set; }

         [DisplayName("SobreNome")]
        public string SobreNome { get; set; }
         [DisplayName("Email")]
        public string Email { get; set; }
          [DisplayName("Celular")]
        public string Celular { get; set; }


    }

}