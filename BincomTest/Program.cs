namespace BincomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1
            Console.WriteLine("Bincom Task 1:");
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(isAdmin);
            Console.WriteLine("---------------------------------------------------------");

            // Test 2
            Console.WriteLine("\nBincom Task 2:");
            Console.WriteLine("Please enter any number below...");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput} is Even number");
            }
            else
            {
                Console.WriteLine($"{userInput} is Odd number");
            }
            Console.WriteLine("---------------------------------------------------------");


            // Test 3
            Console.WriteLine("\nBincom Task 3:");
            Console.WriteLine("Printing from no 1 - 10");
            for( int i = 1; i <= 10; i++ )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------------------\n");


            // Task 4
            Console.WriteLine("\nBincom Task 4:");
            int[] nums = [2,4,6,8,10];
            int sum = 0;
            foreach(int num in nums)
            {
                Console.WriteLine(num);
                sum += num;
            }
            Console.WriteLine($"Sum = {sum}\n");
            Console.WriteLine("---------------------------------------------------------\n");


            // Test 5
            Console.WriteLine("\nBincom Task 5:");
            Greet();
            Greet("Alice");
        }

        public static void Greet(string name="")
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
