﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatastorage.Entities
{
    internal class CustomerEntity
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string SocialSecurityNumber { get; set; } = null!;

        public int AddressId { get; set; }

        public AddressEntity Address { get; set; } = null!;
    }
}
