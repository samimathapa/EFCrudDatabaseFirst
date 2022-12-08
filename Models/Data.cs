using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EntityDatabase.Models
{
    public class Data
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0, 100)]
        public int QTY { get; set; }
        [Range(0, 1000000000)]
        public int Price { get; set; }
    }
}
