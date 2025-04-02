using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokemon151.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Height { get; set; }
        public decimal Weight { get; set; }
    }
}
