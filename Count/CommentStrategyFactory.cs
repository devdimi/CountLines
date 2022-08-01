using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class CommentStrategyFactory
    {
        private ICommentStrategy cppStrategy;
        private ICommentStrategy nullStrategy;

        public ICommentStrategy CppStrategy 
        { 
            get
            {
                if(this.cppStrategy == null)
                {
                    this.cppStrategy = new CppCommentStrategy();
                }

                return this.cppStrategy;
            } 
         }

        public ICommentStrategy NullStrategy
        {
            get
            {
                if (this.nullStrategy == null)
                {
                    this.nullStrategy = new NullStrategy();
                }

                return new NullStrategy();
            }
        }

        public ICommentStrategy GetStrategy(String fileName)
        {
            if(fileName.EndsWith(".cs"))
            {
                return this.CppStrategy;
            }

            return this.NullStrategy;
        }
    }
}
