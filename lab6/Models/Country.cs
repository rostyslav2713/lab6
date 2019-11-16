using System;
using System.ComponentModel.DataAnnotations;

namespace lab6.Models
{
    public class Country
    {
        [Key]
        public int country_id { get; set; }
        public string country_name { get; set; }
        public int bank_id { get; set; }
        public int bank_credit { get; set; }
        public DateTime Date { get; set; }
    }
}