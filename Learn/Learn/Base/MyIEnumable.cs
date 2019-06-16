using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Base
{
    public class MyIEnumable<T> : IEnumerable<T>
    {
        private T[] array;

        public MyIEnumable(T[] ds)
        {
            array = ds;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyIEnumrator<T>(array);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class MyIEnumrator<T> : IEnumerator<T>
    {
        private T[] ds;
        private int posion=-1;
        public MyIEnumrator(T[] ds)
        {
            this.ds = ds;
        }

        public T Current => ds[posion];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.Collect();
        }

        public bool MoveNext()
        {
            posion++;
            return posion < ds.Length;
        }

        public void Reset()
        {
            posion = -1;
        }
    }
}
