using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class CppCommentStrategy : ICommentStrategy
    {
        public bool IsComment(string comment)
        {
            return comment.TrimStart(' ').StartsWith("//");
        }
    }
}
