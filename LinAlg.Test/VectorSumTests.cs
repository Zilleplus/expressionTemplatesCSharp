using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LinAlg.Test
{
    public class VectorSumTests
    {
        [Fact]
        public static void Give_Two_Vectors_Check_Sum()
        {
            var vec1 = new Vector(1, 1, 1);
            var vec2 = new Vector(2, 2, 2);
            var vec3 = new Vector(3, 3, 3);

            var sum = MathOperations.Sum(vec1, vec2);
            for (int i = 0; i < 3; i++)
            {
                Assert.Equal(3, sum[i]);
            } 

            var sum2 = MathOperations.Sum(sum, vec3);
            for (int i = 0; i < 3; i++)
            {
                Assert.Equal(6, sum2[i]);
            }
        }
    }
}
