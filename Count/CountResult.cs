using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class CountResult
    {
        public Int32 LineCount { get; set; }
        public Int32 CommentCount { get; set; }

        public Int32 EmptyLines { get; set; }
    }
}
