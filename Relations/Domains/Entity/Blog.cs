using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Entity
{
    public class Blog
    {
        public int Id { get; set; }
        public BlogHeader? Header { get; set; }  // Reference navigation to dependent
        public ICollection<Post> Posts { get; set; } = new List<Post>(); // Collection navigation containing dependents
    }

}
