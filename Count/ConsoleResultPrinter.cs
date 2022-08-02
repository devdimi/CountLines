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
            int total = result.LineCount + result.CommentCount + result.EmptyLines;
            int numDigits = total.ToString().Length;
            String formatString = "{0," + numDigits + "}";
            using (BoxWriter writer = new BoxWriter(lineLength, Console.Out))
            {
                writer.PrintLine($" Dir            :    {options.DirectoryName}");
                writer.PrintLine($" Search pattern :    {String.Join(',', options.FilePatterns)}");
                writer.PrintLine($" Date           :    {DateTime.Now}");
                writer.PrintLine($" Comment lines  :    {String.Format(formatString, result.CommentCount)}  ({GetPerCent(result.CommentCount, total)})");
                writer.PrintLine($" Empty   lines  :    {String.Format(formatString, result.EmptyLines)}  ({GetPerCent(result.EmptyLines, total)})");
                writer.PrintLine($" Code    lines  :    {String.Format(formatString, result.LineCount)}  ({GetPerCent(result.LineCount, total)})");
                writer.PrintLine(String.Empty);
                writer.PrintLine($" Total   lines  :    {String.Format(formatString, total)}");
            }
        }

        public String GetPerCent(int count, int total)
        {
            double result = count / (double)((double)total / 100.0);
            String formatted = $"{RoundUp(result, 3)}%";
            return formatted;
            
        }

        public static double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }
    }
}
