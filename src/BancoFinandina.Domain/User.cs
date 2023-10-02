﻿using System.ComponentModel.DataAnnotations;

namespace BancoFinandina.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
    }
}