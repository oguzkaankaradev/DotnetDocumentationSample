using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; } // Required foreign key property
        public Blog Blog { get; set; } // Required reference navigation to principal
        public List<Tag> Tags { get; set; }
    }
}
