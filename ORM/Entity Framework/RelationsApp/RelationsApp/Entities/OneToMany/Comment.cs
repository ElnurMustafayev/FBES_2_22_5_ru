using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsApp.Entities.OneToMany
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
