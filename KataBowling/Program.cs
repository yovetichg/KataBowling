namespace KataBowling
{
    public class Program
    {
        public static string Rolls;
        public static void Main(string[] args)
        {
            if (args == null)
            {
                throw new InvalidArgumentsException("NULL");
            }
            Rolls = args[0];
        }
    }
}
