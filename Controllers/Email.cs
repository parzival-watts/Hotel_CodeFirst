using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_CodeFirst.Models
{
    public class Email
    {
        [Key]
        public int Codigo_Email { get; set; }

        [Required]
        public int Codigo_Cliente { get; set; }

        [Required]
        [StringLength(100)]
        public string Endereco_Email { get; set; }

        public Cliente Cliente { get; set; }
    }
}