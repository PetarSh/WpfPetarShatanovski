﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPetarShatanovski.Model
{
   public class ClientData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }
    }
}
