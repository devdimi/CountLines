using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class CommentStrategyFactory
    {
        private ICommentStrategy commentStrategy;

        public ICommentStrategy CppStrategy 
        { 
            get
            {
                if(this.commentStrategy == null)
                {
                    this.commentStrategy = new CppCommentStrategy();
                }

                return this.commentStrategy;
            } 
         }

        public ICommentStrategy GetStrategy(String fileName)
        {
            if(fileName.EndsWith(".cs"))
            {
                return this.CppStrategy;
            }

            throw new NotSupportedException();
        }
    }
}
