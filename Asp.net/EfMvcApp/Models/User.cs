using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfMvcApp.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? AvatarPath { get; set; }
    }
}