using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wallpapper.Domain.Tests
{
    [TestClass]
    public class ChangerTests
    {
        [TestMethod]
        public void SetWallpaper()
        {
            // ReSharper disable once StringLiteralTypo
            string imagePath = "E:\\Обои\\Absord.JPG";
            Changer.SetWallpaper(imagePath);

            string imapePath2 = "";
            Changer.SetWallpaper(imapePath2);
        }
    }
}
