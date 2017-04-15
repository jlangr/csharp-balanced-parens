using NUnit.Framework;

namespace csharp_balanced_parens
{
    [TestFixture]
    public class ParserTest
    {
        Parser parser = new Parser();

        [Test]
        public void Balanced_with_empty_string()
        {
            Assert.True(parser.IsBalanced(""));
        }

        [Ignore("")]
        [Test]
        public void Unbalanced_with_only_left_paren()
        {
            Assert.False(parser.IsBalanced("("));
        }

        [Ignore("")]
        [Test]
        public void Balanced_with_left_and_right_paren()
        {
            Assert.True(parser.IsBalanced("()"));
        }

        [Ignore("")]
        [Test]
        public void Not_balanced_with_left_and_right_paren_reversed()
        {
            Assert.False(parser.IsBalanced(")("));
        }

        [Ignore("")]
        [Test]
        public void Not_balanced_with_differnt_left_and_right_paren()
        {
            Assert.False(parser.IsBalanced("(}"));
        }

        [Ignore("")]
        [Test]
        public void Balanced_with_LL_RR_paren()
        {
            Assert.True(parser.IsBalanced("(())"));
        }

        [Ignore("")]
        [Test]
        public void Not_balanced_with_LLLR_paren()
        {
            Assert.False(parser.IsBalanced("((()"));
        }

        // Passes already
        [Ignore("")]
        [Test]
        public void Balanced_with_LRLR_paren()
        {
            Assert.True(parser.IsBalanced("()()"));
        }

        [Ignore("")]
        [Test]
        public void Not_balanced_with_brace_mismatch()
        {
            Assert.False(parser.IsBalanced("{"));
        }

        [Ignore("")]
        [Test]
        public void Not_balanced_when_types_cross()
        {
            Assert.False(parser.IsBalanced("({)}"));
        }

        [Ignore("")]
        [Test]
        public void Not_balanced_when_types_cross_2()
        {
            Assert.False(parser.IsBalanced("{(})"));
        }

        [Ignore("")]
        [Test]
        public void Balanced_with_mixed_types()
        {
            Assert.True(parser.IsBalanced("{({}())}"));
        }
    }
}
