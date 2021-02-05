internal void DrawLine(Bitmap bitmapPicture, int xStart, int yStart, int xEnd, int yEnd, byte RedColor, byte GreenColor, byte BlueColor)
{
    /**
        * Buat Line antar 2 titik
        * Dengan sudut yang fleksibel (tidak hanya 45 derajat)
        */

    int xDistance, yDistance, Count, countOrder;
    float xOrder, yOrder, xRatio, yRatio, lineWidth, lineLength;
    // NB: bila lineWidth = integer, nantinya: Int32/ Int32 = Int32 (tidak bisa ke float)
    // Sehingga lineWidth dan lineLength harus berformat desimal (float)

    xOrder = xStart;
    yOrder = yStart;

    xDistance = xEnd - xStart; // Bisa positif, bisa negatif
    yDistance = yEnd - yStart; // Bisa positif, bisa negatif

    lineLength = Math.Abs(xDistance); // panjang koordinat x
    lineWidth = Math.Abs(yDistance); // panjang koordinat y

    // Bila panjang > lebar
    if (lineLength > lineWidth)
    {
        xRatio = 1;
        yRatio = lineWidth / lineLength;
        Count = Convert.ToInt32(lineLength);
    }
    // Bila panjang < lebar
    else
    {
        yRatio = 1;
        xRatio = lineLength / lineWidth;
        Count = Convert.ToInt32(lineWidth);
    }

    for (countOrder = 0; countOrder <= Count; countOrder++)
    {
        int R = Convert.ToInt32(RedColor);
        int G = Convert.ToInt32(GreenColor);
        int B = Convert.ToInt32(BlueColor);

        int xOrderInt = Convert.ToInt32(xOrder);
        int yOrderInt = Convert.ToInt32(yOrder);

        bitmapPicture.SetPixel(xOrderInt, yOrderInt, Color.FromArgb(R, G, B));

        if (xDistance > 0 && yDistance >= 0) // Kuadran 1
        {
            xOrder += xRatio;
            yOrder += yRatio;
        }
        else if (xDistance > 0 && yDistance < 0) // Kuadran 4
        {
            xOrder += xRatio;
            yOrder -= yRatio;
        }
        else if (xDistance < 0 && yDistance > 0) // Kuadran 2
        {
            xOrder -= xRatio;
            yOrder += yRatio;
        }
        else if (xDistance < 0 && yDistance < 0) // Kuadran 3
        {
            xOrder -= xRatio;
            yOrder -= yRatio;
        }
    }
}