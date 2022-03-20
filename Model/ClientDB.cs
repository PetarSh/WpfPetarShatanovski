using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPetarShatanovski.Model
{
    public class ClientDB : DbContext
    {
        /// <summary>
        /// we are adding DefaultConnection to constructor
        /// </summary>
        public ClientDB() : base("name=DefaultConnection")

        {
        }
        /// <summary>
        /// our entities that we can query to db
        /// </summary>
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
