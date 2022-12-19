using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.CommandPattern
{
    public class CompositeCommand : RedoableCommand
    {
        private List<RedoableCommand> _commands = new();

        public void Execute()
        {
            List<RedoableCommand>.Enumerator iterator = _commands.GetEnumerator();
            while (iterator.MoveNext())
            {
                var command = iterator.Current;
                command.Execute();
            }
        }

        public void UndoExecute()
        {
            List<RedoableCommand>.Enumerator iterator = _commands.GetEnumerator();
            while (iterator.MoveNext())
            {
                var command = iterator.Current;
                command.UndoExecute();
            }
        }

        public void RedoExecute()
        {
            List<RedoableCommand>.Enumerator iterator = _commands.GetEnumerator();
            while (iterator.MoveNext())
            {
                var command = iterator.Current;
                command.RedoExecute();
            }
        }
    }
}