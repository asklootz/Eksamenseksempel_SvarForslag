namespace Eksamenseksempel_SvarForslag
{
    class Program
    {
        static void Main(string[] args)
        {
            // Del 1, oppgave 4
            Console.WriteLine("\nDel 1, oppgave 4"); //For å vise klart i terminal
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            // Del 1, oppgave 5
            Console.WriteLine("\nDel 1, oppgave 5"); //For å vise klart i terminal
            int x = 5;
            Console.WriteLine(x++);
            Console.WriteLine(x);

            // Del 1, oppgave 6
            Console.WriteLine("\nDel 1, oppgave 6"); //For å vise klart i terminal
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[3]);

            // Del 1, oppgave 17
            Console.WriteLine("\nDel 1, oppgave 17"); //For å vise klart i terminal

            [Fact]
            public void Add_TwoNumbers_ReturnsCorrectSum()
            {
                Calculator c = new Calculator();
                int result = c.Add(2, 3);
                Assert.Equal(5, result);
            }

            // Del 1, oppgave 20
            string text = null;
            Console.WriteLine(text.Length);
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}