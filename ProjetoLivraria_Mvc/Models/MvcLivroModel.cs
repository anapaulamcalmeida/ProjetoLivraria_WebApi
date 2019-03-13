using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLivraria_Mvc.Models
{
    public class MvcLivroModel
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Nullable<System.DateTime> DataPublicacao { get; set; }
        public string ImagemCapa { get; set; }
    }
}