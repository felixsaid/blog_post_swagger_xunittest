using System;
using System.Collections.Generic;

namespace BlogAPI
{
    public partial class Post
    {
        public int PostId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public virtual Category Category { get; set; }
    }
}
