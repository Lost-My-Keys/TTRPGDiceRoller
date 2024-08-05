namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine();
                string input = Console.ReadLine();

                var parts = input.Split('d');
                if (parts.Length != 2 || !int.TryParse(parts[0], out int numberOfDice) || !int.TryParse(parts[1], out int diceType))
                {
                    Console.WriteLine("invalid input");
                    return;
                }
                int[] results = RollDice(numberOfDice, diceType);

                Console.WriteLine($"Rolling {numberOfDice}d{diceType}...");
                Console.WriteLine("Results: " + string.Join(", ", results));
                if (diceType != 20)
                {
                    int sum = 0;
                    foreach (int result in results)
                    {
                        sum += result;
                    }
                    Console.WriteLine($"Total: {sum}");
                }
            }
        }

        static int[] RollDice(int numberOfDice, int diceType)
        {
            Random random = new Random();
            int[] results = new int[numberOfDice];
            for (int i = 0; i < numberOfDice; i++)
            {
                results[i] = random.Next(1, diceType + 1);

            }



            return results;
        }


    }
}