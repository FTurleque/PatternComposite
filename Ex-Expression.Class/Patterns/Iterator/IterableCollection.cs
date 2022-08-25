using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Expression.Class.Patterns.Iterator
{
    public interface IterableCollection : IEnumerator
    {

        Iterator CreateIterator();
    }
}