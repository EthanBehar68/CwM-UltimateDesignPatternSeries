using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StatePattern
{

    // The commented out code is a perfectly acceptable simple solution for a stopwatch.
    // The active code is a overly complicated forced usage of the State Pattern.
    // We have our core logic spread out over two classes that implement a unnecessary interface.
    // We have complicated our code and spread it amongst many files
    // While not gaining any benefits of the State Pattern.
    // No usage for extensibility b/c a Stopwatch won't have more than these two states.
    // So, we solved the "problems" of maintainability and reusability when they weren't even present.
    // Thus making this a bad solution.
    public class Stopwatch
    {

        private State _currentState;

        public State CurrentState { get => _currentState; set => _currentState = value; }

        void Awake()
        {
            _currentState = new StoppedState(this);
        }

        public void Click()
        {
            _currentState.Click();
        }

        // private bool isRunning;

        // public void Click()
        // {
        //     if (isRunning)
        //     {
        //         isRunning = !isRunning;
        //         Debug.Log("Stopped");
        //     }
        //     else
        //     {
        //         isRunning = !isRunning;
        //         Debug.Log("Running");
        //     }
        // }
    }   
}
