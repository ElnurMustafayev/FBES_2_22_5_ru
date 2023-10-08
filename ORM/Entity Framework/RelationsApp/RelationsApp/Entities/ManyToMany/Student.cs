using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsApp.Entities.ManyToMany
{
    public class Student
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }

        public Student() { }

        public Student(string name, DateTime? birthDate = null)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
    }
}
