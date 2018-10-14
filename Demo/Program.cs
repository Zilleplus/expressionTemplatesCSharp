using LinAlg;
using System;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var vec1 = new Vector(1, 1, 1);
            var vec2 = new Vector(2, 2, 2);
            var vec3 = new Vector(3, 3, 3);

            var sum = MathOperations.Sum(vec1, vec2);
            Console.WriteLine("Sum:"+ SerializeVector(sum));

            var sum2 = MathOperations.Sum(sum, vec3);
            Console.WriteLine("Sum2:" + SerializeVector(sum2));
        }

        static string SerializeVector(IVector vec) {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("[");
            for (var i = 0; i < vec.Count ; i++)
            {
                stringBuilder.Append(" " + vec[i]);
            }
            stringBuilder.Append(" ]");

            return stringBuilder.ToString();
        }
    }
}
