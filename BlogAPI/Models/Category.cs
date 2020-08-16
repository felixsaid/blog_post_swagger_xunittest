using System;
using System.Collections.Generic;

namespace BlogAPI
{
    public partial class Category
    {
        public Category()
        {
            Post = new HashSet<Post>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
