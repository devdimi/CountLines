using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    
    public class ConsoleResultPrinter : IResultPrinter
    {
        public void PrintResult(CountResult result, CommandLineOptions options)
        {
            int lineLength = 82;
            using (BoxWriter writer = new BoxWriter(lineLength, Console.Out))
            {
                writer.PrintLine($" Dir            :    {options.DirectoryName}");
                writer.PrintLine($" Search pattern :    {String.Join(',', options.FilePatterns)}");
                writer.PrintLine($" Date           :    {DateTime.Now}");
                writer.PrintLine($" Line count     :    {result.LineCount}");
                writer.PrintLine($" Comment lines  :    {result.CommentCount}");
                writer.PrintLine($" Grand total    :    {result.LineCount + result.CommentCount}");
            }
        }
    }
}
