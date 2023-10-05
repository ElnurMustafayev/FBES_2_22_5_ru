using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsApp.Entities.OneToMany
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Text { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
