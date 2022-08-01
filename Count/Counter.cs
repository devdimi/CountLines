using MinimalFileSystemApi;

namespace Count
{
    public class Counter
    {
        private IDirectory directory;

        private CommentStrategyFactory factory;
        
        public Counter(IDirectory directory, CommentStrategyFactory factory)
        {
            this.directory = directory;
            this.factory = factory;
        }

        public CountResult GetLineCount(String dir,  ICollection<String> patterns)
        {
            var result = new CountResult();
            foreach (var pattern in patterns)
            {
                var fileEnumerator = this.directory.GetFiles(dir, pattern);
                foreach (ILineReader reader in fileEnumerator)
                {
                    using (reader)
                    {
                        this.ProcessFile(reader, result, reader.FileName);
                    }
                }
            }

            return result;
        }

        private void ProcessFile(ILineReader reader, CountResult result, String fileName)
        {
            int count = 0;
            int commentLines = 0;
            String line;
            ICommentStrategy commentStrategy = this.factory.GetStrategy(fileName);
            while(null != (line = reader.ReadLine()))
            {
                if(!commentStrategy.IsComment(line))
                {
                    count++;
                } else
                {
                    commentLines++;
                }
                
            }

            result.LineCount += count;
            result.CommentCount += commentLines;
        }
    }
}
