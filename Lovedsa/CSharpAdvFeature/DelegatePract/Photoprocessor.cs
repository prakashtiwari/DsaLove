using System;
namespace CSharpAdvFeature.DelegatePract
{
    public class Photoprocessor
    {
        public delegate void PhotoProcessHandler(Photo photo);
        public void ProcessPhoto(string path, PhotoProcessHandler handler)
        {
            Photo photo = Photo.LoadPhoto(path);
            handler(photo);
        }
        public void ProcessPhotoNew(string path, Action<Photo> handler)
        {
            Photo photo = Photo.LoadPhoto(path);
            handler(photo);
        }
    }
}
