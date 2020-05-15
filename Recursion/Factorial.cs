namespace Recursion
{
    //Factorial 5=5*4*3*2*1
    public static class Factorial
    {
        public static int Fact(int x)
        {
            if (x==0) return 1;

            return x * Fact(x - 1);
            //Fact(5)=5*Fact(4)
            //Fact(4)=4*Fact(3)
            //Fact(3)=3*Fact(2)
            //Fact(2)=2*Fact(1)
            //Fact(1)=1;
        }
    }
}