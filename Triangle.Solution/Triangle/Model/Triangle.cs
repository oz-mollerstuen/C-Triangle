namespace TriangleTracker
{

    public class Triangle
    {


        public static bool isNotTriangle(int side1, int side2, int side3)
        {

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isEqualTriangle(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isIsoTriangle(int side1, int side2, int side3)
        {
            if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isScalTriangle(int side1, int side2, int side3)
        {
            if (side1 != side2 && side2 != side3 && side1 != side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}