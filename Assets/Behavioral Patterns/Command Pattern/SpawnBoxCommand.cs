using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.CommandPattern
{
    public class SpawnBoxCommand : RedoableCommand
    {        
        private GameObject _boxPrefab;
        private GameObject _box;

        public SpawnBoxCommand(GameObject boxPrefab)
        {
            _boxPrefab = boxPrefab;
        }

        public void Execute()
        {
            _box = Object.Instantiate(_boxPrefab, Vector3.zero, Quaternion.identity);
        }

        public void UndoExecute()
        {
            Object.Destroy(_box);
        }
        
        public void RedoExecute()
        {
            _box = Object.Instantiate(_boxPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}