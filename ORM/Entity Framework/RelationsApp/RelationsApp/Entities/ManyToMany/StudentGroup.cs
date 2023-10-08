using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsApp.Entities.ManyToMany
{
    public class StudentGroup
    {
        public int Id { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public StudentGroup() { }
        public StudentGroup(Student student, Group group)
        {
            this.Student = student;
            this.Group = group;
        }
    }
}
