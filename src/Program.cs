using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DwWallpaperChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "";
            if (args.Length > 0)
            {
                type = args[0];
            }

            string path = "";

            if(type == "-WarDoctor")
            {
                path = @".\withWar\";
            }
            else
            {
                path = @".\noWar\";
            }

            DateTime time = DateTime.Now;
            Console.WriteLine(time.Hour);

            Uri imagePath = new Uri("C:\\");

            switch (time.Hour)
            {
                case 1: case 13:
                    imagePath = new Uri(Path.GetFullPath(path + "01.jpg"));
                    break;
                case 2: case 14:
                    imagePath = new Uri(Path.GetFullPath(path + "02.jpg"));
                    break;
                case 3: case 15:
                    imagePath = new Uri(Path.GetFullPath(path + "03.jpg"));
                    break;
                case 4: case 16:
                    imagePath = new Uri(Path.GetFullPath(path + "04.jpg"));
                    break;
                case 5: case 17:
                    imagePath = new Uri(Path.GetFullPath(path + "05.jpg"));
                    break;
                case 6: case 18:
                    imagePath = new Uri(Path.GetFullPath(path + "06.jpg"));
                    break;
                case 7: case 19:
                    imagePath = new Uri(Path.GetFullPath(path + "07.jpg"));
                    break;
                case 8: case 20:
                    imagePath = new Uri(Path.GetFullPath(path + "08.jpg"));
                    break;
                case 9: case 21:
                    imagePath = new Uri(Path.GetFullPath(path + "09.jpg"));
                    break;
                case 10: case 22:
                    imagePath = new Uri(Path.GetFullPath(path + "10.jpg"));
                    break;
                case 11: case 23:
                    imagePath = new Uri(Path.GetFullPath(path + "11.jpg"));
                    break;
                case 0: case 12:
                    imagePath = new Uri(Path.GetFullPath(path + "12.jpg"));
                    break;
            }

            Wallpaper.Set(imagePath, Wallpaper.Style.Fill);
        }
    }
}
