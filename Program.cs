namespace Line_Comparison_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("enter values for line 1");
            Console.WriteLine("enter x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var Line1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("length of line 1" + Line1);


            Console.WriteLine("enter values for line 2");
            Console.WriteLine("enter x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y4");
            int y4 = Convert.ToInt32(Console.ReadLine());

            var Line2 = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)));
            Console.WriteLine("Length of line 2" + Line2);

            if (Line1 == Line2)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (Line1 > Line2)
            {
                Console.WriteLine("Line1 is greater");
            }
            else
            {
                Console.WriteLine("Line2 is greater");
            }


        }
    }
}




