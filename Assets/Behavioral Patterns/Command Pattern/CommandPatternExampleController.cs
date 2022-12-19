using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.CommandPattern
{
    public class CommandPatternExampleController : MonoBehaviour
    {

        [SerializeField]
        private CommandInvoker _commandInvoker;

        [SerializeField]
        private GameObject _boxPrefab;

        [SerializeField]
        private GameObject _currentBox;


        public void SpawnBox()
        {
            SpawnBoxCommand command = new SpawnBoxCommand(_boxPrefab);
            _commandInvoker.AddCommand(command);
        }

        public void MoveBox()
        {
            if (null == _currentBox)
            {
                // TODO Lazy Programming Ahead!
                // Not ideal, just for the example
                // Probably would work nicely with a pooling manager to ask for references
                // Makes no sense we need to query commands for references to objects they create
                Debug.Log("Set current box reference via inspector to use this command.");
                return;            
            }

            MoveBoxCommand command = new MoveBoxCommand(_currentBox);
            _commandInvoker.AddCommand(command);
        }

        public void UndoLastCommand()
        {
            _commandInvoker.UndoLastCommand();
        }

        public void RedoLastCommand()
        {
            _commandInvoker.RedoLastCommand();
        }
    }
}