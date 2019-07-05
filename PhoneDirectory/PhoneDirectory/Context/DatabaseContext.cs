using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneDirectory.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("PhoneNoDBContext") { }
        public DbSet<PhoneNumber> phoneNumbers { get; set; }
    }
}