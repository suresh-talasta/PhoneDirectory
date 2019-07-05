using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneDirectory.Models
{
   
        public class PhoneNumber
        {
            [Key]
            public int ID { get; set; }
            public string customerPhoneNumber { get; set; }
            public string customerName { get; set; }
            public string customerId { get; set; }
            public bool active { get; set; }

        }
    }