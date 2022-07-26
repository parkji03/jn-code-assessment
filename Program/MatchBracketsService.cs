// Programming Testing:
// Write a method that takes a string argument and returns whether or not characters in the string have matching brackets. Meaning for every { there is a corresponding } bracket. Return true if they do, return false if they do not. 
// Please unit test with the following use cases (and any others you choose to ensure functionality) - also, please be sure to show your unit tests:
// Test string - Expected result
// {} - True
// }{ - False (closed bracket can't proceed all open brackets.)
// {{} - False (one bracket pair was not closed)
// "" - True. (no brackets in the string will return True) 
// {abc...xyz} - True (non-bracket characters are ignored appropriately)

using System.Collections;

namespace MatchBrackets.Services
{
    public class MatchBracketsService
    {
        public bool IsMatching(string arg)
        {   
            if (arg == null)
            {
                throw new Exception("arg is null");
            }
        
            if (arg.Equals(""))
                return true;

            var stack = new Stack();
            var chars = arg.ToCharArray();
            for (int i = 0; i < chars.Count(); i++)
            {
                var currentChar = chars[i];
                if (currentChar.Equals('{'))
                    stack.Push(currentChar);
                
                if (currentChar.Equals('}'))
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}