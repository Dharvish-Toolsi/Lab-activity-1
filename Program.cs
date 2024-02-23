namespace Lab_Activity_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum of N numbers
            Console.WriteLine("How many numbers?");
            int intCount = int.Parse(Console.ReadLine());
            int intSum = 0;
            int intMin = 0;
            int intMax = 0;
            for (int i = 0; i < intCount; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + "/" + intCount);
                int intTemp = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    intMin = intTemp;
                }
                if (intMax < intTemp)
                {
                    intMax = intTemp;
                }
                if (intMin > intTemp)
                {
                    intMin = intTemp;
                }
                intSum += intTemp;
            }
            //Sum of numbers
            Console.WriteLine("Sum of numbers: " + intSum);
            //Average of numbers
            Console.WriteLine("Average of numbers: " + (intSum / intCount));
            //Min of numbers
            Console.WriteLine("Min of numbers: " + intMin);
            // of numbers
            Console.WriteLine("Max of numbers: " + intMax);
        }
    }
}
