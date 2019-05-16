using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Wallpapper.Domain
{
    public static class Changer
    {
        private const int SetDesktopBackground = 20;
        private const int UpdateIniFile = 1;
        private const int SendWindowsIniChange = 2;


        public static void SetWallpaper(string imagePath)
        {
            using (var key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true))
            {
                if (key == null) throw new Exception("Key not found");

                key.SetValue("PicturePosition", "10");
                key.SetValue("TileWallpaper", "0");
            }

            NativeMethods.SystemParametersInfo(SetDesktopBackground, 0, imagePath,
                UpdateIniFile | SendWindowsIniChange);
        }
    }

    internal sealed class NativeMethods
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int SystemParametersInfo(
            int uAction,
            int uParam,
            string lpvParam,
            int fuWinIni);
    }
}