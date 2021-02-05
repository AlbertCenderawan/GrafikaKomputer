using System.Drawing;

private void DrawHorizontalLine(Bitmap bitmapPicture, int xStart, int xEnd, int y, byte RedColor, byte GreenColor, byte BlueColor)
{
    /**
        * Horizontal Line berasal dari 2 titik yang berbeda
        * Tapi nilai y sama
        */
    int xOrder;

    for (xOrder = xStart; xOrder <= xEnd; xOrder++)
    {
        int R = Convert.ToInt32(RedColor);
        int G = Convert.ToInt32(GreenColor);
        int B = Convert.ToInt32(BlueColor);

        bitmapPicture.SetPixel(xOrder, y, Color.FromArgb(R, G, B));
        pbDrawing.Image = drawingBoard;
    }
}