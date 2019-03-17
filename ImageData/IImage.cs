using ImageData.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImageData
{
    public interface IImage
    {
        IEnumerable<Image> GetAll();
        Image GetImageById(Guid id);
        Task AddImage(Image image);
        Task UpdateImage(Image image);
        Task DeleteImage(Guid id);
    }
}
