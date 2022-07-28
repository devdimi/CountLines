using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public interface IResultPrinter
    {
        void PrintResult(CountResult result, CommandLineOptions options);
    }
}
