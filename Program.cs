namespace Weak_1._1_MainTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpetNumber;
            int largCarpetNumber;
            int cost;
            double tax;
            double totalEstimate;

            Console.WriteLine("Estimate for carpet cleaning service");

            Console.Write("Number of small carpets: ");
            smallCarpetNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            largCarpetNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");

            cost = (smallCarpetNumber * 25) + (largCarpetNumber * 35);
            tax = Convert.ToDouble((cost * 6)) / 100;

            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax : ${tax}");

            Console.WriteLine("===============================");

            totalEstimate = cost + tax;

            Console.WriteLine($"Total Estimate : ${totalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");





        }
    }
}
