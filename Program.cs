using MinimalFileSystemApi;

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

            Counter counter = new Counter(new MinimalDirectory());
            CountResult result =  counter.GetLineCount(options.DirectoryName, options.FilePatterns);
            PrintResult(result, options);
            return 0;
        }

        private static void PrintResult(CountResult result, CommandLineOptions options)
        {
            Console.WriteLine("------------");
            Console.WriteLine($"Dir: {options.DirectoryName}");
            Console.WriteLine($"{DateTime.Now}");
            Console.WriteLine($"Line Count: {result.LineCount}");
        }
    }
}
