namespace hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sum = 0;
            int avg;

            var num = new int[10];
            Console.WriteLine("Adj meg 10 számot!");
            for (int i = 0; i < num.Length; i++)
            {
                bool addNum = true;
                input = Console.ReadLine();
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j] == int.Parse(input))
                    {
                        Console.WriteLine("Egy számot csak egyszer adhatsz meg.");
                        i--;
                        addNum = false;
                        break;
                    }
                }
                if (addNum == true)
                {
                    num[i] = int.Parse(input);
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            avg = sum / num.Length;
            Console.WriteLine("A számok összege: {0}", sum);
            Console.WriteLine("A számok átlaga: {0}", avg);
            Console.ReadKey();
        }
    }
}