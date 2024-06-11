using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScroogeApp.Core.Exceptions
{
    public class NotFoundException : Exception
    {
        private readonly string entity;
        public NotFoundException(string entity)
        {
            this.entity = entity;
        }

        public override string Message => $"Entity '{this.entity}' not found!";
    }
}