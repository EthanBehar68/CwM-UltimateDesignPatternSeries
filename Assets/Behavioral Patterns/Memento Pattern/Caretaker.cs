using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.MementoPattern
{
    public class Caretaker : MonoBehaviour
    {
        private Stack<Memento> states = new();

        public void Push(Memento state)
        {
            states.Push(state);
        }

        public Memento Pop()
        {
            if (states.Count > 0)
                return states.Pop();

            return null;
        } 

        public int GetMementoCount()
        {
            return states.Count;
        }
    }
}
