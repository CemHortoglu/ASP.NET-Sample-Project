using Paradox.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Entities.Concrete
{
    public class Product : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string SeoTitel { get; set; }
        public string Keyword { get; set; }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public Category Category { get; set; }
    }
}
