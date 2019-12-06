using System;
using System.ComponentModel.DataAnnotations;

namespace lab6.Models
{
    public class Stadium
    {
        [Key]
        public int stadiumId { get; set; }
        public string stadiumName { get; set; }
        public string stadiumLocation { get; set; }
        public int stadiumArea { get; set; }
        public DateTime Date { get; set; }
    }
}