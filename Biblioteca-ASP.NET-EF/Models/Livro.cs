using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteca_ASP.NET_EF.Models
{
    public class Livro
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="O campo Título não pode ser nulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Autor não pode ser nulo")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "O campo Categoria não pode ser nulo")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "O campo Quantidade não pode ser nulo")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O campo Sinopse não pode ser nulo")]
        public string Sinopse { get; set; }

    }

    public class EFCodeFirst : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

    }
}