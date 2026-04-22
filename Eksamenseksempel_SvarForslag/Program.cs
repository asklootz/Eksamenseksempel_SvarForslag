namespace Eksamenseksempel_SvarForslag
{
    class Program
    {
        static void Main(string[] args)
        {
            // Del 1, oppgave 4
            Console.WriteLine("\nDel 1, oppgave 4:"); //For å vise klart i terminal
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            // Del 1, oppgave 5
            Console.WriteLine("\nDel 1, oppgave 5:"); //For å vise klart i terminal
            int x = 5;
            Console.WriteLine(x++);
            Console.WriteLine(x);

            // Del 1, oppgave 6
            // Bruker feilhåndtering for å kunne skrive ut feilmeldingen og la programmet fortsette
            Console.WriteLine("\nDel 1, oppgave 6:"); //For å vise klart i terminal
            try
            {
                
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[3]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            // Del 1, oppgave 19
            Console.WriteLine("\nDel 1, oppgave 19 \nKjører klassen for å vise at den virker:"); //For å vise klart i terminal
            Student1 ola = new Student1("Ola Nordmann");
            Console.WriteLine(ola.Name);

            // Del 1, oppgave 20
            Console.WriteLine("\nDel 1, oppgave 20:"); //For å vise klart i terminal
            // Bruker feilhåndtering for å kunne skrive ut feilmeldingen og la programmet fortsette
            try
            {
                string text = null;
                Console.WriteLine(text.Length);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            // Del 3
            // Kode før endring:
            /*
            Product p = new Product("Mouse", 500);
            Console.WriteLine(p.GetDiscountedPrice(10));
            */
            Console.WriteLine("\nDel 3:"); //For å vise klart i terminal
            // Opprett produktobjektet
            Product p = new Product("Mouse", 500);
            Console.WriteLine(p.GetDiscountedPrice(101));

            
            // Del 4
            Console.WriteLine("\nDel 4:"); //For å vise klart i terminal
            // Opprett studentobjektet
            Student student = new Student("Ola Nordmann", 12345);
            
            // Legg till karakterer
            student.AddGrade(2);
            student.AddGrade(1);
            student.AddGrade(2);
            student.AddGrade(4);
            
            // Kjører metode for å regne ut gjennomsnitt og printer respons
            Console.WriteLine(student.GetAverage());
            
            // Kjører metode for å se om student har passert og printer respons
            Console.WriteLine(student.HasPassed());
        }
    }

    // Klasse som brukes til del 1, oppgave 17
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    
    // Klasse til del 1, oppgave 19
    class Student1
    {
        public string Name { get; set; }
        public Student1(string name)
        {
            Name = name;
        }
    }
    
    // Klasse til del 3
    
    // Kode før endring
    /*
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double GetDiscountedPrice(double percent)
        {
            return Price - (Price * percent / 100);
        }
    }*/
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        // Kreve at pris ikke er negativ via egenskaper:
        /*
         public double Price { get; set
            {
                if  (value < 0)
                {
                    Console.WriteLine("Prisen kan ikke være negativ");
                    return;
                }
                field = value;
            }
        }*/



    public Product(string name, double price)
        {
            Name = name;
            if (price < 0)
            {
                Console.WriteLine("Prisen kan ikke være negativ");
                return;
            }
            Price = price;
        }

        public double GetDiscountedPrice(double percent)
        {
            if (percent is <= 0 or >= 100)
            {
                Console.WriteLine("Rabattprosent må være mellom 0 og 100");
                return Price; // Gir tilbake full pris om de prøver å sette rabbat lavere enn 0 eller høyere enn 100
            }
            return Price - (Price * percent / 100);
        }
    }
    
    // Klasse til del 4
    class Student
    {
        public string Name { get; private set; }
        public int StudentId { get; init; }
        private List<int> Grades { get; set; }
        public Student(string name,  int studentId)
        {
            Name = name;
            StudentId = studentId;
            Grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            if (grade is <= 0 or >= 7)
            {
                Console.WriteLine("Karakteren må være mellom 1 og 6");
                return;
            }
            Grades.Add(grade);
            Console.WriteLine($"Karakteren {grade} er lagt til for student {Name}");
        }

        public double GetAverage()
        {
            // Enkles i kode:
            return Grades.Average();
            
            // Alternativ måte:
            /*
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Count;
            */
        }

        public bool HasPassed()
        {
            // Enklest i kode:
            return (GetAverage() >= 2.5);
            
            // Alternativ måte:
            /*
            if (GetAverage() >= 2.5)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }


    }
}