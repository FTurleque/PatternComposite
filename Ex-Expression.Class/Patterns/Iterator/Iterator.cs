using Ex_Expression.Class.Pattern.Composite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Expression.Class.Patterns.Iterator
{
    public interface Iterator : IEnumerator
    {
        Expression GetNext();
        bool HasMore();
    }
}