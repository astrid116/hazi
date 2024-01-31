namespace hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new int[12];
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int minPosInArr = 0;
            int maxPosInArr = 0;
            float avg = 0;
            int input;

            Console.WriteLine("Írd be, hogy mennyit spóroltál:");
            

            for (int i = 1; i < num.Length + 1; i++)
            {
                Console.Write("{0}. hónap: ", i);
                input = int.Parse(Console.ReadLine());
                num[i - 1] = input;
            }
 
            for (int i = 1; i < num.Length + 1; i++)
            {
                Console.WriteLine("{0}. hónap spórolása: {1} ", i, num[i - 1]);
            }

            for (int i = 1; i < num.Length + 1; i++)
            {
                if (num[i - 1] < minValue)
                {
                    minValue = num[i - 1];
                    minPosInArr = i;
                }
                if (num[i - 1] > maxValue)
                {
                    maxValue = num[i - 1];
                    maxPosInArr = i;
                }
            }
            Console.WriteLine("\nLegkevesebb spórolás a(z) {0}. hónapban volt {1}Ft-al.", minPosInArr, minValue);
            Console.WriteLine("Legmagasabb spórolás a(z) {0}. hónapban volt {1}Ft-al.\n", maxPosInArr, maxValue);

            for (int i = 1; i < num.Length + 1; i++)
            {
                avg += num[i - 1];
            }
            avg = avg / 12;
            Console.WriteLine("Átlag spórolás: {0:0.00}", avg);


            Console.ReadKey();
        }
    }
}