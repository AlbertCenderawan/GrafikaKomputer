using System.Drawing;

private void DrawCircle(Bitmap bitmapPicture, int xCenter, int yCenter, float radius, byte RedColor, byte GreenColor, byte BlueColor)
{
    double angle, xLength = 0, yLength = 0;
    int xScreenCoordinate = 0, yScreenCoordinate = 0;
    double angleRAD;

    for (angle = 0; angle <= 360; angle+= 50/radius)
    {
        // Tentukan berapa panjang x dan panjang y untuk membentuk sebuah lingkaran (untuk koordinat kertas)
        angleRAD = angle * (Math.PI / 180);
        xLength = radius * Math.Cos(angleRAD);
        yLength = radius * Math.Sin(angleRAD);

        // Tentukan berapa panjang x dan panjang y untuk membentuk sebuah lingkaran (untuk koordinat layar)
        xScreenCoordinate = Convert.ToInt32(xCenter + xLength);
        yScreenCoordinate = Convert.ToInt32(yCenter - yLength);

        if ((xScreenCoordinate > 0 && xScreenCoordinate < pbPertemuan4.Width) && (yScreenCoordinate > 0 && yScreenCoordinate < pbPertemuan4.Height))
        {
            // set pixel
            int R = Convert.ToInt32(RedColor);
            int G = Convert.ToInt32(GreenColor);
            int B = Convert.ToInt32(BlueColor);

            int xScreenCoordinateInt = Convert.ToInt32(xScreenCoordinate);
            int yScreenCoordinateInt = Convert.ToInt32(yScreenCoordinate);

            bitmapPicture.SetPixel(xScreenCoordinate, yScreenCoordinate, Color.FromArgb(R, G, B));
            PictureBox.Image = drawingBoard;
        }
    }
}