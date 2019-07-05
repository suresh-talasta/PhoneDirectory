using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneDirectory.Models
{
    public class PhoneNumberRequest
    {
        public int id;
        public string customerId;
        public string customerName;
        public string customerPhoneNumber;
        public bool active;
    }
}