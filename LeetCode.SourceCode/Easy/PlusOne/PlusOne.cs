namespace LeetCode.SourceCode.Easy
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            var result = digits;
            var length= digits.Length;
            int toAdd = 1;
            for(int i = length - 1; i >= -1; i--)
            {
                if (toAdd == 0) break;
                var sum = result[i] + toAdd;
                result[i] = sum % 10;
                toAdd = sum / 10;
                if (i == 0)
                {
                    if (toAdd != 0)
                    {
                        Array.Resize(ref result, ++length); // increase array length by 1
                        Array.Copy(result, 0, result, 1, length - 1);
                        result[i] = toAdd;
                    }
                    break;
                }
            }
            return result;
        }
    }
}
