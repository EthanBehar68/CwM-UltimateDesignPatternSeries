using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.IteratorPattern
{
    // Now we can extend this class by adding new iterators
    // Without breaking outside classes. 
    public class BrowserHistory
    {
        private List<string> urls = new List<string>();

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            int lastIndex = urls.Count - 1;
            string lastURL = urls[lastIndex];
            urls.Remove(lastURL);

            return lastURL;
        }

        // Not needed once we created our iterator
        // public List<string> getUrls()
        // {
        //     return urls;
        // }

        // Instead...
        public IIterator createIterator()
        {
            return new ListIterator(this);
        }

        // Inner class gives us access to privates of BrowserHistory
        public class ListIterator : IIterator
        {

            private BrowserHistory _history;
            private int _index;

            public ListIterator(BrowserHistory history)
            {
                _history = history;
            }

            public bool HasNext()
            {
                return _index < _history.urls.Count;
            }

            public string Current()
            {
                return _history.urls[_index];
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}