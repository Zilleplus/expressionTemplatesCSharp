namespace LinAlg
{
    public interface IVector
    {
        double this[int key] { get; }
        int Count { get;  }
    }
}