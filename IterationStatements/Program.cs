namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Thousands()
        {
            for (int i = 1000; i >= -1000; i--) 
            {
                Console.WriteLine(i);
            }
        }
        
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void TriplesToThousand()
        {
            for (int i = 3; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualsXY()
        {
            Console.WriteLine("Please provide x (to determine if it equals y): ");
            int xuser = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide y:");
            int yuser = int.Parse(Console.ReadLine());
            bool ans = xuser == yuser;
            Console.WriteLine(ans);
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOdd()
        {
            Console.WriteLine("Please provide a number: ");
            int x = int.Parse(Console.ReadLine());
            string ans = (x % 2 == 0) ? $"{x} is Even" : $"{x} is Odd";
            Console.WriteLine(ans);
        }
        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg()
        {
            Console.WriteLine("Please give a number to determine if its positive or negative: ");
            var num = int.Parse(Console.ReadLine());
            var ans = (num > -1) ? $"{num} is positive!" : $"{num} is negative!"; 
            Console.WriteLine(ans);
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void DetermineVoting()
        {
            Console.WriteLine("What is your age?");
            var age = int.Parse(Console.ReadLine());
            var ans = (age >= 18) ? "You can vote!" : "Sorry can't vote";
            Console.WriteLine(ans);
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IsInRange()
        {
            Console.WriteLine("Please provide a number: ");
            var num = int.Parse(Console.ReadLine());
            var ans = (num <= 10 && num >= -10) ? "Your number is in the range -10 to 10" : "Number not in range -10 to 10";
            Console.WriteLine(ans);
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable()
        {
            Console.WriteLine("Please provide a number:");
            var num = int.Parse(Console.ReadLine()) ;
            for (int i = 1;i <= 12; i++) 
            {
                int total = i * num;
                Console.WriteLine($"{i} x {num} = {total}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Thousands();
            TriplesToThousand();
            EqualsXY();
            EvenOdd();
            PosOrNeg();
            DetermineVoting();
            IsInRange();
            MultTable();
        }
    }
}
