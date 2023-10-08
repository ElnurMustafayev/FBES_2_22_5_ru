using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsApp.Entities.ManyToMany
{
    public class Group
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public Group() { }

        public Group(string name)
        {
            this.Name= name;
        }
    }
}
