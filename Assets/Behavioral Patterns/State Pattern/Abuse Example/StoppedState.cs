using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StatePattern
{
    public class StoppedState : State
    {
        private Stopwatch _stopwatch;

        public StoppedState(Stopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }

        public void Click()
        {
            _stopwatch.CurrentState = new RunningState(_stopwatch);
            Debug.Log("Running");
        }
    }
}
