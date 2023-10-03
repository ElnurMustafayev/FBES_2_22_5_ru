using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedApp.Entities
{
    public class NullUser : User
    {
        public NullUser()
        {
            this.Id = 0;
            this.IsMarried = false;
            this.Name = "NOT FOUND";
            this.Surname = "NOT FOUND";
            this.Age = 0;
        }
    }
}
