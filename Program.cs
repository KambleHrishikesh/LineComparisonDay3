namespace Line_Comparison_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Program");

            Console.WriteLine("enter x1");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y1");
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x2");
            int x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y2");
            int y2=Convert.ToInt32(Console.ReadLine());

            var Line = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(Line);



        }
    }
}




