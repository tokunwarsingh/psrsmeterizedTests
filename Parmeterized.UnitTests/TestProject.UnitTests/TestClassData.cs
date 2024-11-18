using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.UnitTests
{
    public class TestClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var result = new List<object[]>()
            {
                new object[] { 1, 2, 3 },
                new object[] { 11, 22, 33 },
                new object[] { 111, 222, 333 },

            };
            return result.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
