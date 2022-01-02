using Paradox.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Shared.Entities.Concrete
{
    public class OperationClime : EntityBase, IEntity
    {
        public string Name { get; set; }
        public UserOperationClimes UserOperationClime { get; set; }
    }
}
