using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie07
{
    internal class CollectionTest : IEnumerable<int>
    {
        private int[] items;

        public CollectionTest(int[] items)
        {
            this.items = items;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
