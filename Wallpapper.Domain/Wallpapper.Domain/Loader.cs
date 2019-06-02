using System.Collections.Generic;
using System.IO;

namespace Wallpapper.Domain
{
    public static class Loader
    {
        public static IEnumerable<string> LoadFromDirectory(string directoryPath)
        {
            return Directory.GetFiles(directoryPath, "*.jpg");
        }
    }
}
