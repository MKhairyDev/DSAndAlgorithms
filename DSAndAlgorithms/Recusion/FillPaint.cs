
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
   public class FillPaint
    {
        public static void PaintFill(Pixel[,] displayScreen, int x, int y, string originalColor, string newColor)
        {
            //O(n) complexity
            if (x < 0 || y < 0 || x >= displayScreen.GetLength(0) || y >= displayScreen.GetLength(1))
            {
                return;
            }
            if (displayScreen[y, x].getColor() != originalColor)
            {
                return;
            }
            if (displayScreen[y, x].getColor() == originalColor)
            {
                displayScreen[y, x].SetColor(newColor);

                PaintFill(displayScreen, x - 1, y, originalColor, newColor);
                PaintFill(displayScreen, x + 1, y, originalColor, newColor);
                PaintFill(displayScreen, x, y - 1, originalColor, newColor);
                PaintFill(displayScreen, x, y + 1, originalColor, newColor);
            }
        }

    }
}
