namespace Simple;
public class Simple
{
    public int SumOfSquares(int n) => Enumerable.Range(1, n).Sum(x => x * x);
}
