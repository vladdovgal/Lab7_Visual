using System.Drawing;


namespace Lab7
{
    public struct FigureSettings
    {
        public Size Dimensions;
        public Color ColorFrom;
        public Color ColorTo;

        public static FigureSettings Empty(Size clip)
        {
            return new FigureSettings
            {
                Dimensions = new Size(clip.Width / 2, clip.Height / 2),
                ColorFrom = Color.Red,
                ColorTo = Color.White
            };
        }
    }
}
