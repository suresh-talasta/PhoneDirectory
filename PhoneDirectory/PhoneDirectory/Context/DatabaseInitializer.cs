using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneDirectory.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

            var phoneNumber1 = new PhoneNumber()
            {
                ID = 1,
                customerId = "1111",
                customerName = "xxxxx",
                customerPhoneNumber = "041-234-5678",
                active = true
            };

            var phoneNumber2 = new PhoneNumber()
            {
                ID = 2,
                customerId = "2222",
                customerName = "yyyy",
                customerPhoneNumber = "041-235-56790",
                active = true
            };

            var phoneNumber3 = new PhoneNumber()
            {
                ID = 3,
                customerId = "3333",
                customerName = "zzzz",
                customerPhoneNumber = "042-224-5670",
                active = false
            };

            var phoneNumber4 = new PhoneNumber()
            {
                ID = 4,
                customerId = "1111",
                customerName = "xxxxx",
                customerPhoneNumber = "045-134-7654",
                active = false
            };

            context.phoneNumbers.Add(phoneNumber1);
            context.phoneNumbers.Add(phoneNumber2);
            context.phoneNumbers.Add(phoneNumber3);
            context.phoneNumbers.Add(phoneNumber4);

            context.SaveChanges();
        }
    }
}