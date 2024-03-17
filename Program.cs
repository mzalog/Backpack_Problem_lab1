namespace BackpackProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of items:");
            int numberOfItems = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed:");
            int seed = int.Parse(Console.ReadLine());

            BackpackProblem problem = new BackpackProblem(numberOfItems, seed);
            Console.WriteLine("Generated items:");
            //Console.WriteLine(problem);
            Console.WriteLine(problem.ToString());

            Console.WriteLine("Enter the capacity of the knapsack:");
            int capacity = int.Parse(Console.ReadLine());

            Result result = problem.Solve(capacity);
            Console.WriteLine("Solution:");
            //Console.WriteLine(result);
            Console.WriteLine(result.ToString());
        }

    }
}
