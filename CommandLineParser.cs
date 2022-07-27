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

            return true;
        }
    }
}
