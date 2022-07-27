using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    /// <summary>Holds the command line options</summary>
    public class CommandLineOptions
    {
        /// <summary>Gets or sets the directory name</summary>
        public String DirectoryName { get; set; }

        public static String GetUsage()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Usage Count.exe <directory> [options]");
            return result.ToString();
        }
    }
}
