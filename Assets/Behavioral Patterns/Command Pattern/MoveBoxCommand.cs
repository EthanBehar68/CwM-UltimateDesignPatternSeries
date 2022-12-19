using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.CommandPattern
{
    public class MoveBoxCommand : RedoableCommand
    {        
        private GameObject _box;
        private Vector3 _undoLocation;
        private Vector3 _redoLocation;

        public MoveBoxCommand(GameObject box)
        {
            _box = box;
        }

        public void Execute()
        {
            Vector3 randomMovement = new Vector3(Random.Range(1, 3), Random.Range(1, 3), Random.Range(1, 3));
            _undoLocation = _box.transform.position;
            _box.transform.position = randomMovement;
        }

        public void UndoExecute()
        {
            _redoLocation = _box.transform.position;
            _box.transform.position = _undoLocation;
        }
        
        public void RedoExecute()
        {
            _undoLocation = _box.transform.position;
            _box.transform.position = _redoLocation;
        }
    }
}