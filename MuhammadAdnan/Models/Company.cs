using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MuhammadAdnan.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string location { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public class CompanyDBContext : DbContext
        {
            public DbSet <Company> Companys { get; set; }
        }
    }
}