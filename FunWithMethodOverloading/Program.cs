namespace FunWithMethodOverloading
{
    public static class AddOpperation
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static long Add(long x, long y)
        {
            return x + y;
        }
    }
}