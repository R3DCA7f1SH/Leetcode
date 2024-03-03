using System.Text;

namespace LeetCode.SourceCode.Easy
{
    public class AddBinarySolution
    {
        private int CharToInt(char ch) => ch - '0';

        public string AddBinary(string a, string b) 
        { 
            var aLength = a.Length - 1;
            var bLength = b.Length - 1;
            var stack = new Stack<int>();
            var carry = 0;
            while (aLength >= 0 || bLength >= 0)
            {
                var aValue = 0;
                var bValue = 0;
                if (aLength >= 0) aValue = CharToInt(a[aLength--]);
                if (bLength >= 0) bValue = CharToInt(b[bLength--]);
                var sum = carry + aValue + bValue;
                carry = sum / 2;
                var digit = sum % 2;
                stack.Push(digit);
            }
            if (carry > 0) stack.Push(carry);
            var result = new StringBuilder();
            while (stack.Count > 0)
            {
                result.Append(stack.Peek());
                stack.Pop();
            }
            return result.ToString();
        }
    }
}
