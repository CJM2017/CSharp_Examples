using System;   // Includes String object


namespace Static_Methods
{

    class Test
    {
        // Public properties
        private String name;
        private int age;

        // Constructor
        public Test(String N, int A)
        {
            this.name = N;
            this.age = A;
        }

        // Public methods
        public static void print_something()
        {
            Console.WriteLine("Hello world!");
        }

        public String get_name()
        {
            return this.name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test.print_something();

            Test myTest = new Test("Connor", 25);
            Console.WriteLine(myTest.get_name());

            //myTest.print_something(); this will not work!
        }
    }
}
