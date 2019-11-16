using System.ComponentModel.DataAnnotations;

namespace lab6.Models
{
    public class Bank
    {
        [Key]
        public int bank_id { get; set; }
        public string bank_name { get; set; }
        public int bank_amount_of_clients { get; set; }
    }
}