using System;
using System.Collections.Generic;

namespace ImageData.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public virtual IEnumerable<Tag> Tags { get; set; }
    }
}
