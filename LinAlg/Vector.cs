using System;
using System.Collections.Generic;
using System.Text;

namespace LinAlg
{
    public class Vector : IVector
    {
        private List<double> _elements= new List<double>();

        public Vector(params double[] elements)
        {
            _elements.AddRange(elements);
        }

        public double this[int key]
        {
            get
            {
                return _elements[key];
            }
            set
            {
                _elements[key]= value;
            }
        }

        public int Count => _elements.Count; 
    }
}
