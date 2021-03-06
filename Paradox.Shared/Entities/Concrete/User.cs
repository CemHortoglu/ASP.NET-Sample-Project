using Paradox.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Shared.Entities.Concrete
{
    public class User : EntityBase, IEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
    }
}
