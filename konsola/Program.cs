namespace konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string again = "t";
            do
            {

                do
                {
                    Console.WriteLine("Ile kostek chcesz rzucić?(3 - 10)");
                    n = int.Parse(Console.ReadLine()!);
                } while (n < 3 || n > 10);

                List<int> throws = new List<int>() { 0, 0, 0, 0, 0, 0 };
                Random rand = new Random();
                for(int i = 1; i <= n; i++)
                {
                    int diceIndex = rand.Next(6);
                    throws[diceIndex]++;
                    Console.WriteLine("Kostka " + i + ": " + (diceIndex + 1));
                }

                int points = 0;
                for(int i = 0; i < throws.Count; i++)
                {
                    if (throws[i] > 1)
                        points += (i + 1) * throws[i];
                }
                Console.WriteLine("Liczba uzyskanych punktów: " + points);

                Console.WriteLine("Jeszcze raz? (t/n)");
                again = Console.ReadLine();
            } while (again == "t");
        }
    }
}
