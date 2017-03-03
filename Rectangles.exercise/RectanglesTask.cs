using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            return r1.Left <= r2.Left + r2.Width && r2.Left <= r1.Left + r1.Width
                && r1.Top <= r2.Top + r2.Height && r2.Top <= r1.Top + r1.Height;
		}

		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            if (!AreIntersected(r1, r2))
                return 0;
            return (Math.Min(r1.Left + r1.Width, r2.Left + r2.Width) - Math.Max(r1.Left, r2.Left))
                * (Math.Min(r1.Top + r1.Height, r2.Top + r2.Height) - Math.Max(r1.Top, r2.Top));
        } 

        public static bool IsRectangleInner(Rectangle r1, Rectangle r2)
        {
            return (r1.Left <= r2.Left && r1.Left + r1.Width >= r2.Left + r2.Width &&
                r1.Top <= r2.Top && r1.Top + r1.Height >= r2.Top + r2.Height);
        }
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
            if (IsRectangleInner(r1, r2))
                return 1;
            if (IsRectangleInner(r2, r1))
                return 0;
            return -1;
		}
	}
}