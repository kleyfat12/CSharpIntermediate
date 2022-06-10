namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Refrigerator refrigerator = new(30, 0);

            refrigerator.SetDefrostEvent(new Refrigerator.DefrostEvent(GradesReport));
            refrigerator.SetLowReservesEvent(new Refrigerator.LowReservesEvent(KilosReport));

            while(refrigerator.Kilos > 5 && refrigerator.Grades < 20)
            {
                refrigerator.Work(random.Next(1, 3));
            }
        }

        public static void KilosReport(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Low reserves (I am in main)");
            Console.WriteLine("Kilos remaining: " + kilos);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void GradesReport(int grades)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("High temperature (I am in main)");
            Console.WriteLine("The temperature is " + grades + " degrees");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

