using System;
using System.Diagnostics;
using System.Drawing;

namespace RefactorMe
{
    // ## Прочитайте! ##
    //
    // Ваша задача привести код в этом файле в порядок. 
    // Для начала запустите эту программу. Для этого в VS в проект подключите сборку System.Drawing.

    // Переименуйте всё, что называется неправильно. Это можно делать комбинацией клавиш Ctrl+R, Ctrl+R (дважды нажать Ctrl+R).
    // Повторяющиеся части кода вынесите во вспомогательные методы. Это можно сделать выделив несколько строк кода и нажав Ctrl+R, Ctrl+M
    // Избавьтесь от всех зашитых в коде числовых констант — положите их в переменные с понятными именами.
    // 
    // После наведения порядка проверьте, что ваш код стал лучше. 
    // На сколько проще после ваших переделок стало изменить размер фигуры? Повернуть её на некоторый угол? 
    // Научиться рисовать невозможный треугольник, вместо квадрата?

    class Risovatel
    {
        static Bitmap image = new Bitmap(800, 600);
        static float x, y;
        static Graphics drawing = Graphics.FromImage(image);
        public static void Set_pos(float x0, float y0)
        {
            x = x0;
            y = y0;
        }

        public static void Draw_Line(double L, double angle)
        {
            //Делает шаг длиной L в направлении angle и рисует пройденную траекторию
            var x1 = (float)(x + L * Math.Cos(angle));
            var y1 = (float)(y + L * Math.Sin(angle));
            drawing.DrawLine(Pens.Yellow, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void ShowResult()
        {
            image.Save("result.bmp");
            Process.Start("result.bmp");
        }
        public static void Draw_Parts(int xPos, int yPos, double radianAngle)
        {
            Set_pos(xPos, yPos);
            Draw_Line(ImpossibleSquare.sideLength, radianAngle);
            Draw_Line(ImpossibleSquare.width * Math.Sqrt(2), radianAngle + Math.PI / 4);
            Draw_Line(ImpossibleSquare.sideLength, radianAngle + Math.PI);
            Draw_Line(ImpossibleSquare.sideLength - (double)ImpossibleSquare.width, radianAngle + Math.PI / 2);
        }
    }

    public class ImpossibleSquare
    {
        public static int xLUpperPos = 0;
        public static int yLUpperPos = 0;
        public static int sideLength = 100;
        public static int width = 10;
        public static void Main()
        {
            //Рисуем четыре одинаковые части невозможного квадрата.
            // Часть первая:
            Risovatel.Draw_Parts(xLUpperPos + width, yLUpperPos, 0);
            // Часть вторая:
            Risovatel.Draw_Parts(xLUpperPos + (2 * width) + sideLength, yLUpperPos + width, Math.PI / 2);

            // Часть третья:
            Risovatel.Draw_Parts(xLUpperPos + width + sideLength, yLUpperPos + (2 * width) + sideLength, Math.PI);

            // Часть четвертая:
            Risovatel.Draw_Parts(xLUpperPos, yLUpperPos + width + sideLength, (-1) * Math.PI / 2);
            Risovatel.ShowResult();
        }
        
    }
}
