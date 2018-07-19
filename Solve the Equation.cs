public class Solution
{
    public string SolveEquation(string equation)
    {
        int n = equation.Length, sign = 1, coeffi = 0, total = 0, j = 0;
        for (int i = 0; i < n; i++)
        {
            if (equation[i] == '+' || equation[i] == '-')
            {
                if (i > j)
                    total += sign * int.Parse(equation.Substring(j, i - j));
                j = i;
            }
            else if (equation[i] == 'x')
            {
                if (i == j || equation[i - 1] == '+')
                    coeffi += sign;
                else if (equation[i - 1] == '-')
                    coeffi -= sign;
                else
                    coeffi += sign * int.Parse(equation.Substring(j, i - j));
                j = i + 1;
            }
            else if (equation[i] == '=')
            {
                if (i > j)
                    total += sign * int.Parse(equation.Substring(j, i - j));
                sign = -1;
                j = i + 1;
            }
        }

        if (j < n) total += sign * int.Parse(equation.Substring(j));
        if (coeffi == 0 && total == 0) return "Infinite solutions";
        if (coeffi == 0 && total != 0) return "No solution";
        int ans = -total / coeffi;
        return "x=" + ans.ToString();
    }
}