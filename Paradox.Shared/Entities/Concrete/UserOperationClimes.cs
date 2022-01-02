using Paradox.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Shared.Entities.Concrete
{
    public class UserOperationClimes : EntityBase, IEntity
    {
        public int UserId { get; set; }
        public int OperationClimeId { get; set; }

        public User User { get; set; }
        public OperationClime OperationClime { get; set; }

    }
}
