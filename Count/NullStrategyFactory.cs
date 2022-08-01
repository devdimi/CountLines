using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class NullStrategy : ICommentStrategy
    {
        public bool IsComment(string comment) => false;
    }
}
