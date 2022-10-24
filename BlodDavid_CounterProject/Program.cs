public class Program
{
    public static void Main(string[] args)
    {
        int start = Convert.ToInt32(args[0]);
        int end = Convert.ToInt32(args[1]);

        for (int current = start; current < end; current++)
        {
            Console.WriteLine(current);
        }
    }
}