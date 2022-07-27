namespace Count
{
    public class CommandLineParser
    {
        public bool TryParse(String[] args, out CommandLineOptions options)
        {
            options = new CommandLineOptions();
            if(args.Count() == 0)
            {
                return false;
            }

            options = new CommandLineOptions()
            {
                DirectoryName = args[0]
            };

            List<String> result = new List<string>();
            for(int i = 1; i < args.Length; i++)
            {
                if (args[i].StartsWith("*."))
                {
                    result.Add(args[i]);
                }
            }

            options.FilePatterns = result;
            
            return true;
        }
    }
}
