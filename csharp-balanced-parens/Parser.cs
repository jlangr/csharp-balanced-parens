using System.Collections.Generic;
using System.Linq;

namespace csharp_balanced_parens
{
    internal class Parser
    {
        IDictionary<char, int> depthsByOpeningChar = new Dictionary<char, int>()
        {
            {'(', 0},
            {'{', 0}
        };
        IDictionary<char, char> closingCharToOpeningChar = new Dictionary<char, char>()
        {
            {'}', '{'},
            {')', '('}
        };

        bool IsOpeningChar(char c)
        {
            return depthsByOpeningChar.ContainsKey(c);
        }

        private char MatchingOpeningChar(char c)
        {
            return closingCharToOpeningChar[c];
        }

        internal bool IsBalanced(string expression)
        {
            var stack = new Stack<char>();
            foreach (var c in expression)
                if (IsOpeningChar(c))
                {
                    stack.Push(c);
                    depthsByOpeningChar[c]++;
                }
                else
                {
                    var last = stack.Any() ? stack.Peek() : '\0';
                    if (last != MatchingOpeningChar(c)) return false;
                    stack.Pop();
                }
            return !stack.Any();
        }
    }
}