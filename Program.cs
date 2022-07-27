namespace Count // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static int Main(string[] args)
        {
            CommandLineParser commandlineParser = new CommandLineParser();
            CommandLineOptions options;
            if(!commandlineParser.TryParse(args, out options))
            {
                Console.WriteLine(CommandLineOptions.GetUsage());
                return 1;
            }

            Console.WriteLine("Hello World!");
            return 0;
        }
    }
}
