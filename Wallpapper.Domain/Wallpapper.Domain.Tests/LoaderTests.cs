using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wallpapper.Domain.Tests
{
    [TestClass]
    public class LoaderTests
    {

        [TestMethod]
        public void LoadImagesFromDirectory()
        {
            var directoryPath = @"E:\Обои";
            var imagesPath = Loader.LoadFromDirectory(directoryPath);
        }
    }
}
