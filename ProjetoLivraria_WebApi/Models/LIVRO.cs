//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoLivraria_WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LIVRO
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
