using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpMyKnowlege
{
    class Yield : IEnumerable<int>
    {
        int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        /*public IEnumerator<int> GetEnumerator()
        {
            foreach (var x in i)
                yield return x;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var x in i)
                yield return x;
        }*/

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var x in i)
                yield return x;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var x in i)
                yield return x;
        }
    }
}
