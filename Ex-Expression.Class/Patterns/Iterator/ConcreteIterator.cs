using Ex_Expression.Class.Pattern.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Expression.Class.Patterns.Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteCollection collection;
        private int iterationState;

        public ConcreteIterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public object Current => throw new NotImplementedException();

        public void GetNext()
        {
            throw new NotImplementedException();
        }

        public bool HasMore()
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

        Expression Iterator.GetNext()
        {
            throw new NotImplementedException();
        }
    }
}