using System;
using System.Collections.Generic;
using System.Text;

namespace LinAlg
{
    public static class MathOperations
    {
        public static VectorSum<T1, T2> Sum<T1, T2>(T1 vec1, T2 vec2)
            where T1 : IVector
            where T2 : IVector
            => new VectorSum<T1, T2>(vec1, vec2);
    }
}
