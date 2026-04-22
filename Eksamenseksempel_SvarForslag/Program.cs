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
            try
            {
                Console.WriteLine("\nDel 1, oppgave 6"); //For å vise klart i terminal
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[3]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            // Del 1, oppgave 19
            Console.WriteLine("\nDel 1, oppgave 19 \nKjører klassen for å vise at den virker:"); //For å vise klart i terminal
            Student ola = new Student("Ola Nordmann");
            Console.WriteLine(ola.Name);

            // Del 1, oppgave 20
            Console.WriteLine("\nDel 1, oppgave 20"); //For å vise klart i terminal
            try
            {
                string text = null;
                Console.WriteLine(text.Length);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }

    // Klasse som brukes til oppgave 17
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    
    // Klasse til oppgave 19
    class Student
    {
        public string Name { get; set; }
        public Student(string name)
        {
            Name = name;
        }
    }
}