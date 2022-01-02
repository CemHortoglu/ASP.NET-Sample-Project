using Paradox.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Entities.Concrete
{
    public class Category : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string SeoTitel { get; set; }
        public string Keyword { get; set; }
    }
}
