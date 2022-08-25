using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Expression.Class.Patterns.Iterator
{
    public class ConcreteCollection : IterableCollection
    {
        public object Current => throw new NotImplementedException();

        public Iterator CreateIterator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}