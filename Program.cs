namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var imageStorage = new ImageStorage();
            imageStorage.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("b", new PngCompressor(), new BlackAndWhiteFilter());
        }
    }
}
