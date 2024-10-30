namespace konsola
{
    internal class Program
    {
        static List<int> DrawDices(int n)
        {
            Random random = new Random();
            List<int> draws = new List<int>();
            for (int i = 0; i < n; i++)
            {
                draws.Add(random.Next(1, 7));
            }
            return draws;
        }

        static int CountPoints(List<int> draws)
        {
            int points = 0;
            List<int> numberOfDraws = new List<int>() { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < draws.Count; i++)
            {
                numberOfDraws[draws[i] - 1]++;
            }

            for (int i = 0; i < numberOfDraws.Count; i++)
            {
                if (numberOfDraws[i] > 1)
                    points += (i + 1) * numberOfDraws[i];
            }

            return points;
        }

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

                List<int> draws = DrawDices(n);
                for(int i = 0; i < draws.Count; i++)
                {
                    Console.WriteLine("Kostka " + (i + 1) + ": " + draws[i]);
                }
                int points = CountPoints(draws);
                Console.WriteLine("Liczba uzyskanych punktów: " + points);

                Console.WriteLine("Jeszcze raz? (t/n)");
                again = Console.ReadLine();
            } while (again == "t");
        }
    }
}
