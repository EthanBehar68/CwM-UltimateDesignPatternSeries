using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.IteratorPattern
{
    // Definitely would want this to be generic
    public interface IIterator
    {
        public bool HasNext();
        public string Current();
        public void Next();
    }
}