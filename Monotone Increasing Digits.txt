public class Solution {
    public int MonotoneIncreasingDigits(int N) {
        char[] digits = N.ToString().ToArray();
        int result = 0;
        bool check = false;
        for (int i = 0; i < digits.Length-1; i++)
        {
            if (digits[i] < digits[i + 1])
            {
                if (digits[i] == '0')
                {
                    result *= 10;
                    result += 9;
                    check = true;
                    continue;
                }
                result *= 10;
                result += (int)char.GetNumericValue(digits[i]);
            }
            else if (digits[i] > digits[i + 1])
            {
                result *= 10;
                result += ((int)char.GetNumericValue(digits[i])) - 1;
                while (i<digits.Length-1)
                {
                    result *= 10;
                    result += 9;
                    i++;
                }
                return result;
            }
            else
            {
                int iCount = i;
                char temp = digits[i];
                while (i+2 <digits.Length && temp == digits[i + 2]) i++;

                if (i+2== digits.Length)
                {
                    if (temp == '0') temp = '9';
                    while (iCount < digits.Length)
                    {
                        result *= 10;
                        result += (int)char.GetNumericValue(temp);
                        iCount++;
                    }
                    return result;
                }
                else if (digits[i] < digits[i + 2]) /////
                {
                    while (iCount < i+2)
                    {
                        result *= 10;
                        result += (int)char.GetNumericValue(temp);
                        iCount++;
                    }
                    i = iCount-1;
                }
                else // digits[i] > digits[i + 2]
                {
                    result *= 10;
                    result += ((int)char.GetNumericValue(digits[i])) - 1;
                    while (iCount < digits.Length-1)
                    {
                        result *= 10;
                        result += 9;
                        iCount++;
                    }
                    return result;
                }
            }
        }
        
        if (check) // Array contains 0
        {
            result *= 10;
            result += 9;
            return result;
        }
        result *= 10;
        result += (int)char.GetNumericValue(digits[digits.Length-1]);
  
        return result;
    }
}