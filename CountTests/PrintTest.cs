using Count;

namespace CountTests
{
    public class Tests
    {
        [Test]
        public void PrintTest()
        {
            CountResult result = new CountResult() { LineCount = 23 };
            CommandLineOptions options = new CommandLineOptions()
            {
                DirectoryName = "C:\\test",
                FilePatterns = new List<String>() { "*.cs" }
            };
            ConsoleResultPrinter printer = new ConsoleResultPrinter();
            printer.PrintResult(result, options);
        }
    }
}