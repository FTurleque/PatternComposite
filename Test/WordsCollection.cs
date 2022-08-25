﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    // Concrete Collections provide one or several methods for retrieving fresh
    // iterator instances, compatible with the collection class.
    class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();
        bool _direction = false;
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        public List<string> getItems()
        {
            return _collection;
        }
        public void AddItem(string item)
        {
            this._collection.Add(item);
        }
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
