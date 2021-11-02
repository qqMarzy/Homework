using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task3
    {
        static void Main(string[] args)
        {
            int allPicturesInAlbum = 52;
            int countOfPicturesInOneLine = 3;
            int completelyFilledLines;
            int remainingPictures;

            completelyFilledLines = allPicturesInAlbum / countOfPicturesInOneLine;

            Console.WriteLine("Полностью заполненных рядов - " + completelyFilledLines);

            remainingPictures = allPicturesInAlbum % countOfPicturesInOneLine;

            Console.WriteLine("Оставшиеся картинки - " + remainingPictures);

            Console.ReadKey();
        }
    }
}
