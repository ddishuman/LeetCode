public class Solution
{
    public int[] AdvantageCount(int[] A, int[] B)
    {
        int[] sortedA = (int[])A.Clone();
        Array.Sort(sortedA);
        int[] sortedB = (int[])B.Clone();
        Array.Sort(sortedB);

        var assigned = new Dictionary<int, Queue<int>>();

        for (int i = 0; i < B.Length; i++)
        {
            if (!assigned.ContainsKey(B[i]))
                assigned.Add(B[i], new Queue<int>());
        }

        Queue<int> remaining = new Queue<int>();

        int j = 0;
        for (int a = 0; a < sortedA.Length; a++)
        {
            if (sortedA[a] > sortedB[j])
                assigned[sortedB[j++]].Enqueue(sortedA[a]);
            //assigned[sortedB[j++]].Enqueue(sortedA[a]);
            else
                remaining.Enqueue(sortedA[a]);
        }

        int[] ans = new int[B.Length];
        for (int i = 0; i < B.Length; i++)
        {
            if (assigned[B[i]].Count > 0)
                ans[i] = assigned[B[i]].Dequeue();
            else
                ans[i] = remaining.Dequeue();
        }
        return ans;
    }
}