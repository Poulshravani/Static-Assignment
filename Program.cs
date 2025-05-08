namespace Static_Assignment
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            int lintA, lintB;

            Console.WriteLine("Enter value for a");
            lintA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b");
            lintB = Convert.ToInt32(Console.ReadLine());


            Simplecode lobj1 = new Simplecode();
            int lintSum = lobj1.Addition(lintA, lintB);
            lobj1.PrintValues();

            Simplecode lobj2 = new Simplecode();
            int lintSub = lobj2.Substract(lintA, lintB);
            lobj2.PrintValues();

            Console.WriteLine("Addition =" + lintSum);
            Console.WriteLine("Subtraction =" + lintSum);



            
            Simplecode lobj = new Simplecode();

            Console.Write("Enter name:");
            lobj1.Name = Console.ReadLine();

            Console.Write("Enter age: ");
            lobj.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nStudent Details:");
            lobj.ShowInfo();

            




        }

    }
}         
        