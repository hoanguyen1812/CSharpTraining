using System;

namespace Delegates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filter = new PhotoFilter();
            Action<Photo> filterHandler = filter.ApplyBrightness;
            //PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemoveRedEye;
            photoProcessor.Processor("ABC", filterHandler);
        }

        private static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove red eye");
        }
    }
}