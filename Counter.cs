using MinimalFileSystemApi.Interfaces;
using MinimalFileSystemApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class Counter
    {
        public Counter()
        {

        }

        public CountResult LineCount(String dir)
        {
            var r = new CountResult();
            ILineReader reader = new LineReader()
        }

    }
}
