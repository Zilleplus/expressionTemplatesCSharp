using System;
using System.Collections.Generic;
using System.Text;

namespace LinAlg
{
    public class VectorSum<T1,T2> : IVector
        where T1 : IVector
        where T2 : IVector
    {
        private T1 _vector1;
        private T2 _vector2;

        public VectorSum(
            T1 vector1,
            T2 vector2)
        {
            _vector1 = vector1;
            _vector2 = vector2;
        }

        public double this[int key]
        {
            get
            {
                return _vector1[key]+_vector2[key];
            }
        }

        public int Count => _vector1.Count;
    }
}
