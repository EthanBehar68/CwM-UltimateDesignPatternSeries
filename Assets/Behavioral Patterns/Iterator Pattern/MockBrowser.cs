using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Vectorform.DesignPatternCookbook.IteratorPattern
{
    public class MockBrowser : MonoBehaviour
    {
        [SerializeField]    
        private Transform urlParent;

        [SerializeField]    
        private TextMeshProUGUI urlPrefab;

        void Awake()
        {
            BrowserHistory history = new BrowserHistory();
            history.Push("url1");
            history.Push("url2");
            history.Push("url3");
            history.Push("url4");
            history.Push("url5");
            history.Push("url6");

            // Now it doesn't matter what data structure we
            // use in BrowserHistory so long it implements the
            // iterator interface properly!
            // Internals of BrowserHistory are hidden from the users.
            IIterator iterator = history.createIterator();
            while (iterator.HasNext())
            {
                string url = iterator.Current();

                TextMeshProUGUI urlText = Instantiate(urlPrefab, urlParent).GetComponent<TextMeshProUGUI>();
                urlText.text = url;

                iterator.Next();
            }

            urlPrefab.gameObject.SetActive(false);
        }
    }
}