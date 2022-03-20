using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPetarShatanovski.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; } = 1;

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }



    }
}
