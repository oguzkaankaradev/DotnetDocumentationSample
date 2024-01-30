using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Entity
{
    public class Blog
    {
        public BlogHeader? Header { get; set; }  // Reference navigation to dependent
    }
}
