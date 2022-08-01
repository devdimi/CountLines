using MinimalFileSystemApi;

namespace Count
{
    public class Counter
    {
        private IDirectory directory;

        public Counter(IDirectory directory)
        {
            this.directory = directory;
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
            String line;
            while(null != (line = reader.ReadLine()))
            {
                count++;
            }

            result.LineCount += count;
        }
    }
}
