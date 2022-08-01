using Count;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTests
{
    [TestFixture]
    public class CppCommentStrategyTest
    {
        [Test]
        public void TestCppComment()
        {
            CppCommentStrategy cppComment = new CppCommentStrategy();
            Assert.IsTrue(cppComment.IsComment("// futher line"));
            Assert.IsTrue(cppComment.IsComment("      // futher line"));
            Assert.IsTrue(cppComment.IsComment("futher line"));
        }
    }
}
