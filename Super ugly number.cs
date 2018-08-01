public class Solution {
    public int NthSuperUglyNumber(int n, int[] primes) {
        int[] index = Enumerable.Repeat(0, primes.Length).ToArray();
        int[] ugly = new int[n];
        int[] uglyClone = Enumerable.Repeat(1, primes.Length).ToArray();
        ugly[0] = 1;
        uglyClone[0] = 1;

        int next = 1;
        for (int i = 0; i < ugly.Length; i++)
        {
            ugly[i] = next;
            next = int.MaxValue;
            for (int j = 0; j < primes.Length; j++)
            {
                if (uglyClone[j] == ugly[i])
                    uglyClone[j] = ugly[index[j]++] * primes[j];

                next = Math.Min(next, uglyClone[j]);
            }

        }

        return ugly[n - 1];
    }
}