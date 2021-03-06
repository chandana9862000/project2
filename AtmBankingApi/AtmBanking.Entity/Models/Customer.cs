using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AtmBanking.Entity.Models
{
    public class Customer
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string email_address { get; set; }
        public int contact_info { get; set; }
        [Key]
        public int customer_id { get; set; }
        public int card_no { get; set; }
        public int pin_no { get; set; }
        public string account_type { get; set; }
        public int account_number { get; set; }
        public string Password { get; set; }
    }
}
