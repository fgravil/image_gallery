using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageData;
using ImageData.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageService
{
    public class ImageAssetService : IImage
    {
        ImageContext context;

        public ImageAssetService(ImageContext imageContext)
        {
            context = imageContext;
        }

        public async Task AddImage(Image image)
        {
            await context.AddAsync(image);
            await SaveChanges();
        }

        public async Task DeleteImage(Guid id)
        {
            var image =  GetImageById(id);
            context.Remove(image);
            await SaveChanges();
        }

        public IEnumerable<Image> GetAll()
        {
            return context.Images.Include(i => i.Tags);
        }

        public Image GetImageById(Guid id)
        {
            return GetAll().Where(image => image.Id == id).FirstOrDefault();
        }

        public async Task UpdateImage(Image image)
        {
            context.Update(image);
            await SaveChanges();
        }

        private async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
