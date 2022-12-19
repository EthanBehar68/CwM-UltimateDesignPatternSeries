using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.CommandPattern
{

    // Personally,
    // I like the idea of a CommandInvoker.
    // Something that is responsible for executing commmands.
    // Can give us more control over when/how commands are executed.
    public class CommandInvoker : MonoBehaviour
    {
        private Queue<RedoableCommand> _commandsToExecute = new();
        private Stack<RedoableCommand> _undoCommandList = new();
	    private Stack<RedoableCommand> _redoCommandList = new();

        public void AddCommand(RedoableCommand newCommand)
        {
            _commandsToExecute.Enqueue(newCommand);
        }

        public void UndoLastCommand()
        {
            RedoableCommand undoCommand = _undoCommandList.Pop();
		    _redoCommandList.Push(undoCommand);
		    undoCommand.UndoExecute();
        }

        public void RedoLastCommand()
        {
		    RedoableCommand redoCommand = _redoCommandList.Pop();
	    	_undoCommandList.Push(redoCommand);
    		redoCommand.RedoExecute();
        }


        void Update()
        {
            while (_commandsToExecute.Count > 0)
            {
                RedoableCommand nextCommand = _commandsToExecute.Dequeue();
			    _undoCommandList.Push(nextCommand);
                nextCommand.Execute();

                return;
            }
        }
    }
}