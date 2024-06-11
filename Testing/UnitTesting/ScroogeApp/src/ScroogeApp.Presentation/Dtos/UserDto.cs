using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScroogeApp.Presentation.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public bool IsInEmbargo { get; set; }
    }
}