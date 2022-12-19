using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.StatePattern
{
    public class RunningState : State
    {
        private Stopwatch _stopwatch;

        public RunningState(Stopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }

        public void Click()
        {
            _stopwatch.CurrentState = new StoppedState(_stopwatch);
            Debug.Log("Stopped");
        }
    }
}