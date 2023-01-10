namespace LargestWinsFromChaos;

internal class Algorithm
{
    internal static int FindLargest(int[] numbers)
    {
        var list = numbers.ToList();
        return list.Max();
    }
}
