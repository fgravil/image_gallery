using ImageData.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageData
{
    public class ImageContext : DbContext
    {
        public ImageContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Image> Images { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
